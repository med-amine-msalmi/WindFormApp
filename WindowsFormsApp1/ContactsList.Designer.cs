namespace WindowsFormsApp1
{
    partial class ContactsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtGridContact = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContact)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridContact
            // 
            this.dtGridContact.AllowUserToAddRows = false;
            this.dtGridContact.AllowUserToDeleteRows = false;
            this.dtGridContact.AllowUserToOrderColumns = true;
            this.dtGridContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridContact.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGridContact.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGridContact.Location = new System.Drawing.Point(24, 152);
            this.dtGridContact.Name = "dtGridContact";
            this.dtGridContact.ReadOnly = true;
            this.dtGridContact.RowHeadersWidth = 57;
            this.dtGridContact.RowTemplate.Height = 24;
            this.dtGridContact.Size = new System.Drawing.Size(1302, 272);
            this.dtGridContact.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 91);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBtn.CausesValidation = false;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(1173, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(124, 52);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "+Contact";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ContactsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1348, 627);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dtGridContact);
            this.Name = "ContactsList";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.loadData);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContact)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button addBtn;
    }
}

