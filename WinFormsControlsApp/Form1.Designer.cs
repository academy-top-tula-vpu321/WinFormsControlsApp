namespace WinFormsControlsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            btnCancel = new Button();
            btnIgnore = new Button();
            lblLogin = new Label();
            lblPassword = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtEdit = new TextBox();
            txtCity = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 26F);
            btnOk.Location = new Point(508, 496);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(185, 80);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 26F);
            btnCancel.Location = new Point(64, 496);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 80);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnIgnore
            // 
            btnIgnore.Font = new Font("Segoe UI", 26F);
            btnIgnore.Location = new Point(286, 496);
            btnIgnore.Name = "btnIgnore";
            btnIgnore.Size = new Size(185, 80);
            btnIgnore.TabIndex = 5;
            btnIgnore.Text = "Ignore";
            btnIgnore.UseVisualStyleBackColor = true;
            btnIgnore.Click += btnIgnore_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 26F);
            lblLogin.Location = new Point(104, 26);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 47);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 26F);
            lblPassword.Location = new Point(104, 99);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(166, 47);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 26F);
            txtLogin.Location = new Point(311, 19);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(338, 54);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 26F);
            txtPassword.Location = new Point(311, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 54);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEdit
            // 
            txtEdit.AcceptsReturn = true;
            txtEdit.AcceptsTab = true;
            txtEdit.Font = new Font("Segoe UI", 16F);
            txtEdit.Location = new Point(64, 308);
            txtEdit.Multiline = true;
            txtEdit.Name = "txtEdit";
            txtEdit.ScrollBars = ScrollBars.Both;
            txtEdit.Size = new Size(629, 155);
            txtEdit.TabIndex = 6;
            txtEdit.WordWrap = false;
            // 
            // txtCity
            // 
            txtCity.AutoCompleteCustomSource.AddRange(new string[] { "Москва", "Тула", "Новосибирск", "Моршанск", "Туапсе", "Новгород" });
            txtCity.Font = new Font("Segoe UI", 20F);
            txtCity.Location = new Point(64, 162);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(629, 43);
            txtCity.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 20F);
            maskedTextBox1.Location = new Point(160, 233);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(436, 43);
            maskedTextBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(781, 605);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtCity);
            Controls.Add(txtEdit);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(btnCancel);
            Controls.Add(btnIgnore);
            Controls.Add(btnOk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Button btnIgnore;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtEdit;
        private TextBox txtCity;
        private MaskedTextBox maskedTextBox1;
    }
}
