namespace APICaller
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPEMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(44, 25);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(340, 20);
            this.txtemail.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.txtPCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPEMail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POST / PUT";
            // 
            // txtPEMail
            // 
            this.txtPEMail.Location = new System.Drawing.Point(63, 25);
            this.txtPEMail.Name = "txtPEMail";
            this.txtPEMail.Size = new System.Drawing.Size(321, 20);
            this.txtPEMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(63, 51);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(321, 20);
            this.txtPName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // txtPCompany
            // 
            this.txtPCompany.Location = new System.Drawing.Point(63, 77);
            this.txtPCompany.Name = "txtPCompany";
            this.txtPCompany.Size = new System.Drawing.Size(321, 20);
            this.txtPCompany.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Company";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(208, 103);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(176, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify Contact";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDEmail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete";
            // 
            // txtDEmail
            // 
            this.txtDEmail.Location = new System.Drawing.Point(44, 25);
            this.txtDEmail.Name = "txtDEmail";
            this.txtDEmail.Size = new System.Drawing.Size(340, 20);
            this.txtDEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(390, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(73, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(323, 20);
            this.txtURL.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "API URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 371);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPEMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label6;
    }
}

