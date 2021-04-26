namespace Foods
{
    partial class BackupForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.MaximizeScreenButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateBacupButton = new System.Windows.Forms.Button();
            this.RestoreBacupButton = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Controls.Add(this.MaximizeScreenButton);
            this.panelHeader.Controls.Add(this.closeButton);
            this.panelHeader.Location = new System.Drawing.Point(-3, 1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(992, 42);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.DoubleClick += new System.EventHandler(this.PanelHeader_DoubleClick);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // MaximizeScreenButton
            // 
            this.MaximizeScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.MaximizeScreenButton.FlatAppearance.BorderSize = 0;
            this.MaximizeScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeScreenButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MaximizeScreenButton.Location = new System.Drawing.Point(904, 0);
            this.MaximizeScreenButton.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeScreenButton.Name = "MaximizeScreenButton";
            this.MaximizeScreenButton.Size = new System.Drawing.Size(40, 40);
            this.MaximizeScreenButton.TabIndex = 4;
            this.MaximizeScreenButton.Text = "ـــ";
            this.MaximizeScreenButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaximizeScreenButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.closeButton.Location = new System.Drawing.Point(948, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(332, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 35);
            this.label8.TabIndex = 32;
            this.label8.Text = "شاشة النسخ الإحتياطي للإكلات";
            // 
            // CreateBacupButton
            // 
            this.CreateBacupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.CreateBacupButton.FlatAppearance.BorderSize = 0;
            this.CreateBacupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBacupButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBacupButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CreateBacupButton.Location = new System.Drawing.Point(266, 178);
            this.CreateBacupButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBacupButton.Name = "CreateBacupButton";
            this.CreateBacupButton.Size = new System.Drawing.Size(458, 48);
            this.CreateBacupButton.TabIndex = 33;
            this.CreateBacupButton.Text = "إنشاء نسخة إحتياطية";
            this.CreateBacupButton.UseVisualStyleBackColor = false;
            this.CreateBacupButton.Click += new System.EventHandler(this.CreateBacupButton_Click);
            // 
            // RestoreBacupButton
            // 
            this.RestoreBacupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.RestoreBacupButton.FlatAppearance.BorderSize = 0;
            this.RestoreBacupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreBacupButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreBacupButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RestoreBacupButton.Location = new System.Drawing.Point(266, 239);
            this.RestoreBacupButton.Margin = new System.Windows.Forms.Padding(2);
            this.RestoreBacupButton.Name = "RestoreBacupButton";
            this.RestoreBacupButton.Size = new System.Drawing.Size(458, 48);
            this.RestoreBacupButton.TabIndex = 34;
            this.RestoreBacupButton.Text = "إسترجاع نسخة إحتياطية";
            this.RestoreBacupButton.UseVisualStyleBackColor = false;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.ControlBox = false;
            this.Controls.Add(this.RestoreBacupButton);
            this.Controls.Add(this.CreateBacupButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupForm";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button MaximizeScreenButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateBacupButton;
        private System.Windows.Forms.Button RestoreBacupButton;
    }
}