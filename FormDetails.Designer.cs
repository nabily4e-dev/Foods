namespace Foods
{
    partial class FormDetails
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FoodNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foodPictureBox = new System.Windows.Forms.PictureBox();
            this.HowToTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FoodCategoriesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FoodComponentsTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Controls.Add(this.closeButton);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(992, 42);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.closeButton.Location = new System.Drawing.Point(948, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(391, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "تفاصيل الأكلة المقترحة";
            // 
            // FoodNameTextBox
            // 
            this.FoodNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FoodNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodNameTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodNameTextBox.Location = new System.Drawing.Point(206, 138);
            this.FoodNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FoodNameTextBox.Name = "FoodNameTextBox";
            this.FoodNameTextBox.ReadOnly = true;
            this.FoodNameTextBox.Size = new System.Drawing.Size(597, 25);
            this.FoodNameTextBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(68, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "أسم الأكلة        :";
            // 
            // foodPictureBox
            // 
            this.foodPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.foodPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodPictureBox.Location = new System.Drawing.Point(820, 138);
            this.foodPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.foodPictureBox.Name = "foodPictureBox";
            this.foodPictureBox.Size = new System.Drawing.Size(160, 160);
            this.foodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodPictureBox.TabIndex = 40;
            this.foodPictureBox.TabStop = false;
            // 
            // HowToTextBox
            // 
            this.HowToTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HowToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HowToTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToTextBox.Location = new System.Drawing.Point(206, 370);
            this.HowToTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HowToTextBox.Multiline = true;
            this.HowToTextBox.Name = "HowToTextBox";
            this.HowToTextBox.ReadOnly = true;
            this.HowToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HowToTextBox.Size = new System.Drawing.Size(597, 82);
            this.HowToTextBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(68, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "طريقة التحضير  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(68, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "المقداير           :";
            // 
            // FoodCategoriesTextBox
            // 
            this.FoodCategoriesTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FoodCategoriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodCategoriesTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.FoodCategoriesTextBox.Location = new System.Drawing.Point(206, 176);
            this.FoodCategoriesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FoodCategoriesTextBox.Multiline = true;
            this.FoodCategoriesTextBox.Name = "FoodCategoriesTextBox";
            this.FoodCategoriesTextBox.ReadOnly = true;
            this.FoodCategoriesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FoodCategoriesTextBox.Size = new System.Drawing.Size(597, 81);
            this.FoodCategoriesTextBox.TabIndex = 44;
            this.FoodCategoriesTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(68, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "تصنيفات الأكلة  :";
            // 
            // FoodComponentsTextBox
            // 
            this.FoodComponentsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FoodComponentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodComponentsTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.FoodComponentsTextBox.Location = new System.Drawing.Point(206, 273);
            this.FoodComponentsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FoodComponentsTextBox.Multiline = true;
            this.FoodComponentsTextBox.Name = "FoodComponentsTextBox";
            this.FoodComponentsTextBox.ReadOnly = true;
            this.FoodComponentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FoodComponentsTextBox.Size = new System.Drawing.Size(597, 81);
            this.FoodComponentsTextBox.TabIndex = 49;
            this.FoodComponentsTextBox.WordWrap = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ExitButton.Location = new System.Drawing.Point(754, 527);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 40);
            this.ExitButton.TabIndex = 50;
            this.ExitButton.Text = "خروج";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FoodComponentsTextBox);
            this.Controls.Add(this.HowToTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FoodCategoriesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FoodNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodPictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetails";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FoodNameTextBox;
        public System.Windows.Forms.PictureBox foodPictureBox;
        public System.Windows.Forms.TextBox HowToTextBox;
        public System.Windows.Forms.TextBox FoodCategoriesTextBox;
        public System.Windows.Forms.TextBox FoodComponentsTextBox;
    }
}