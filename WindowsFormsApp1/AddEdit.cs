using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
namespace WindowsFormsApp1
{
    public partial class addEditFrm : Form
    {
        private enum Mode { Add, Update };

        private Mode mode;

        private int id;

        private Contact contact;

        public addEditFrm(int id)
        {
            this.id = id;
            if (id > 0)
                 this.mode = Mode.Update;
            else
                this.mode = Mode.Add;
            InitializeComponent();


        }
        private void fillCbCountries()
        {
            DataTable dt=Country.getCountries();
                foreach( DataRow  row in dt.Rows)
                {
                cbCountry.Items.Add(row["CountryName"]);
                }
        }
        private void addEditFrm_Load(object sender, EventArgs e)
        {
            fillCbCountries();
            cbCountry.SelectedIndex = 0;
            if(mode== Mode.Add)
            {
                lbTitle.Text = "Add new contact";
                contact= new Contact();
                return; 
                
            }
            
            if (mode == Mode.Update) {
                contact = Contact.FindContact(id);
                if (contact == null)
                {
                    MessageBox.Show("There is no Contact found ", "", MessageBoxButtons.OKCancel);
                    this.Close();
                    return;
                }
                lbTitle.Text = "Edit contact";
                txtID.Text = id.ToString();
                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtEmail.Text = contact.Email;
                txtPhone.Text = contact.PhoneNumber;
                dtDateOfBirth.Value = contact.DateOfBirth;
                if(contact.ImagePath != "")
                {
                    pbImage.Load(contact.ImagePath); 
                    lbRemoveImage.Visible = true;
                }

                cbCountry.SelectedIndex= cbCountry.FindString(Country.findById(contact.CountryID).CountryName);

                txtAddress.Text = contact.Address;



            }
            
        }

        

      
        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Set an image";
                fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = fileDialog.FileName;
                    pbImage.Load(imagePath);
                    lbRemoveImage.Visible = true;

                }


            }


        }

        private void lbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            lbRemoveImage.Visible = false;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            contact.FirstName= txtFirstName.Text;
            contact.LastName= txtLastName.Text;
            contact.Email= txtEmail.Text;
            contact.Address= txtAddress.Text;
            contact.PhoneNumber=txtPhone.Text;
            contact.DateOfBirth = dtDateOfBirth.Value;
            if (pbImage.ImageLocation != null) { 
               contact.ImagePath= pbImage.ImageLocation.ToString();
            }
            contact.CountryID = Country.findCountryByName(cbCountry.SelectedItem.ToString()).Id;
            if (contact.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                mode = Mode.Update;
                txtID.Text = contact.ID.ToString();

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            



        }
    }
}
