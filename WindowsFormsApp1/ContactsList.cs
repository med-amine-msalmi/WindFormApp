using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBusinessLayer;
namespace WindowsFormsApp1
{
    public partial class ContactsList : Form
    {
        public ContactsList()
        {
            InitializeComponent();
        }
        private void _refreshContacts()
        {
            dtGridContact.DataSource = Contact.getContacts();
        }

        private void loadData(object sender, EventArgs e)
        {
            _refreshContacts();
            dtGridContact.ContextMenuStrip = contextMenuStrip1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            addEditFrm addFrm= new addEditFrm(-1);
            addFrm.ShowDialog();
            _refreshContacts();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dtGridContact.CurrentRow.Cells[0].Value;
            addEditFrm editForm =new addEditFrm(id);
            editForm.ShowDialog();
            _refreshContacts();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this contact", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)dtGridContact.CurrentRow.Cells[0].Value;
                if (Contact.Delete(id))
                {
                    MessageBox.Show("Contact deleted Successfully");
                }
                else { MessageBox.Show("Faild to deleted Contact"); }

            }
            _refreshContacts() ;

        }
    }
}
