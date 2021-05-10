namespace Foods
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wrongPassordAction = new System.Windows.Forms.PictureBox();
            this.wrongUsernameAction = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.showPassWordPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SohwRegistrationFormButton = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassordAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongUsernameAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassWordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Controls.Add(this.closeButton);
            this.panelHeader.Location = new System.Drawing.Point(1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 34);
            this.panelHeader.TabIndex = 48;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.closeButton.Location = new System.Drawing.Point(467, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 34);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LoginButton.Location = new System.Drawing.Point(203, 210);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(166, 33);
            this.LoginButton.TabIndex = 46;
            this.LoginButton.Text = "دخول";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(105, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "كلمة المرور  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(105, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "أسم المستخدم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(218, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "النظام";
            // 
            // wrongPassordAction
            // 
            this.wrongPassordAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.wrongPassordAction.Location = new System.Drawing.Point(202, 172);
            this.wrongPassordAction.Name = "wrongPassordAction";
            this.wrongPassordAction.Size = new System.Drawing.Size(167, 3);
            this.wrongPassordAction.TabIndex = 41;
            this.wrongPassordAction.TabStop = false;
            // 
            // wrongUsernameAction
            // 
            this.wrongUsernameAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.wrongUsernameAction.Location = new System.Drawing.Point(202, 132);
            this.wrongUsernameAction.Name = "wrongUsernameAction";
            this.wrongUsernameAction.Size = new System.Drawing.Size(167, 3);
            this.wrongUsernameAction.TabIndex = 40;
            this.wrongUsernameAction.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passwordTextBox.Location = new System.Drawing.Point(203, 153);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(140, 22);
            this.passwordTextBox.TabIndex = 39;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(349, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // showPassWordPictureBox
            // 
            this.showPassWordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassWordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("showPassWordPictureBox.Image")));
            this.showPassWordPictureBox.Location = new System.Drawing.Point(349, 142);
            this.showPassWordPictureBox.Name = "showPassWordPictureBox";
            this.showPassWordPictureBox.Size = new System.Drawing.Size(20, 33);
            this.showPassWordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassWordPictureBox.TabIndex = 38;
            this.showPassWordPictureBox.TabStop = false;
            this.showPassWordPictureBox.MouseEnter += new System.EventHandler(this.ShowPassWordPictureBox_MouseEnter);
            this.showPassWordPictureBox.MouseLeave += new System.EventHandler(this.ShowPassWordPictureBox_MouseLeave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usernameTextBox.Location = new System.Drawing.Point(202, 113);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(140, 22);
            this.usernameTextBox.TabIndex = 36;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
            // 
            // SohwRegistrationFormButton
            // 
            this.SohwRegistrationFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.SohwRegistrationFormButton.FlatAppearance.BorderSize = 0;
            this.SohwRegistrationFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SohwRegistrationFormButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SohwRegistrationFormButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SohwRegistrationFormButton.Location = new System.Drawing.Point(109, 210);
            this.SohwRegistrationFormButton.Name = "SohwRegistrationFormButton";
            this.SohwRegistrationFormButton.Size = new System.Drawing.Size(88, 33);
            this.SohwRegistrationFormButton.TabIndex = 49;
            this.SohwRegistrationFormButton.Text = "إنشاء";
            this.SohwRegistrationFormButton.UseVisualStyleBackColor = false;
            this.SohwRegistrationFormButton.Click += new System.EventHandler(this.SohwRegistrationFormButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.SohwRegistrationFormButton);
            this.Controls.Add(this.wrongPassordAction);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.wrongUsernameAction);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPassWordPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassordAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongUsernameAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassWordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox wrongPassordAction;
        private System.Windows.Forms.PictureBox wrongUsernameAction;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox showPassWordPictureBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button SohwRegistrationFormButton;
    }
}