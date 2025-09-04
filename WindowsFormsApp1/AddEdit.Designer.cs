namespace WindowsFormsApp1
{
    partial class addEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEditFrm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbSetImage = new System.Windows.Forms.LinkLabel();
            this.lbRemoveImage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dtDateOfBirth
            // 
            resources.ApplyResources(this.dtDateOfBirth, "dtDateOfBirth");
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            // 
            // cbCountry
            // 
            this.cbCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCountry, "cbCountry");
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Tag = "";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // lbSetImage
            // 
            this.lbSetImage.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.lbSetImage, "lbSetImage");
            this.lbSetImage.BackColor = System.Drawing.SystemColors.Control;
            this.lbSetImage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbSetImage.LinkColor = System.Drawing.Color.Blue;
            this.lbSetImage.Name = "lbSetImage";
            this.lbSetImage.TabStop = true;
            this.lbSetImage.UseMnemonic = false;
            this.lbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSetImage_LinkClicked);
            // 
            // lbRemoveImage
            // 
            this.lbRemoveImage.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.lbRemoveImage, "lbRemoveImage");
            this.lbRemoveImage.BackColor = System.Drawing.SystemColors.Control;
            this.lbRemoveImage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbRemoveImage.LinkColor = System.Drawing.Color.Blue;
            this.lbRemoveImage.Name = "lbRemoveImage";
            this.lbRemoveImage.TabStop = true;
            this.lbRemoveImage.UseMnemonic = false;
            this.lbRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRemoveImage_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // addEditFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRemoveImage);
            this.Controls.Add(this.lbSetImage);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbCountry);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "addEditFrm";
            this.Load += new System.EventHandler(this.addEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.LinkLabel lbSetImage;
        private System.Windows.Forms.LinkLabel lbRemoveImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}