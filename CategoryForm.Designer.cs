namespace Foods
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryNumberTextBox = new System.Windows.Forms.TextBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.newCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCategoriesListBox = new System.Windows.Forms.ListBox();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAllCategoriesButton = new System.Windows.Forms.Button();
            this.cancelAllCategoriesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesConfirmButton = new System.Windows.Forms.Button();
            this.categorySearchtextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelHeader.Location = new System.Drawing.Point(2, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(992, 42);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(462, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "التصنيفات";
            // 
            // categoryNumberTextBox
            // 
            this.categoryNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryNumberTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNumberTextBox.Location = new System.Drawing.Point(143, 88);
            this.categoryNumberTextBox.Name = "categoryNumberTextBox";
            this.categoryNumberTextBox.ReadOnly = true;
            this.categoryNumberTextBox.Size = new System.Drawing.Size(539, 25);
            this.categoryNumberTextBox.TabIndex = 34;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.deleteCategoryButton.FlatAppearance.BorderSize = 0;
            this.deleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteCategoryButton.Location = new System.Drawing.Point(886, 88);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(93, 59);
            this.deleteCategoryButton.TabIndex = 38;
            this.deleteCategoryButton.Text = "حذف تصنيف!";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            this.deleteCategoryButton.EnabledChanged += new System.EventHandler(this.DeleteCategoryButton_EnabledChanged);
            this.deleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "رقم التصنيف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "أسم التصنيف:";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryNameTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextBox.Location = new System.Drawing.Point(143, 119);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(539, 25);
            this.categoryNameTextBox.TabIndex = 36;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            this.categoryNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryNameTextBox_KeyDown);
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.newCategoryButton.FlatAppearance.BorderSize = 0;
            this.newCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCategoryButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.newCategoryButton.Location = new System.Drawing.Point(688, 88);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(93, 59);
            this.newCategoryButton.TabIndex = 37;
            this.newCategoryButton.Text = "جديد*";
            this.newCategoryButton.UseVisualStyleBackColor = false;
            this.newCategoryButton.Click += new System.EventHandler(this.NewCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addCategoryButton.Location = new System.Drawing.Point(787, 88);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(93, 59);
            this.addCategoryButton.TabIndex = 40;
            this.addCategoryButton.Text = "إضافة تصنيف";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.EnabledChanged += new System.EventHandler(this.AddCategoryButton_EnabledChanged);
            this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click_1);
            // 
            // addCategoriesListBox
            // 
            this.addCategoriesListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCategoriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addCategoriesListBox.FormattingEnabled = true;
            this.addCategoriesListBox.ItemHeight = 22;
            this.addCategoriesListBox.Location = new System.Drawing.Point(640, 182);
            this.addCategoriesListBox.Name = "addCategoriesListBox";
            this.addCategoriesListBox.Size = new System.Drawing.Size(339, 242);
            this.addCategoriesListBox.TabIndex = 41;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.categoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.categoryDataGridView.Location = new System.Drawing.Point(143, 215);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.Size = new System.Drawing.Size(339, 209);
            this.categoryDataGridView.TabIndex = 42;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryDataGridView_CellContentClick);
            this.categoryDataGridView.SelectionChanged += new System.EventHandler(this.CategoryDataGridView_SelectionChanged);
            this.categoryDataGridView.DoubleClick += new System.EventHandler(this.CategoryDataGridView_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "catNumber";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "م";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "catName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "التصنيف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 89;
            // 
            // addAllCategoriesButton
            // 
            this.addAllCategoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.addAllCategoriesButton.FlatAppearance.BorderSize = 0;
            this.addAllCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAllCategoriesButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addAllCategoriesButton.Location = new System.Drawing.Point(488, 252);
            this.addAllCategoriesButton.Name = "addAllCategoriesButton";
            this.addAllCategoriesButton.Size = new System.Drawing.Size(146, 38);
            this.addAllCategoriesButton.TabIndex = 43;
            this.addAllCategoriesButton.Text = "إضافة الكل";
            this.addAllCategoriesButton.UseVisualStyleBackColor = false;
            this.addAllCategoriesButton.Click += new System.EventHandler(this.AddAllCategoriesButton_Click);
            // 
            // cancelAllCategoriesButton
            // 
            this.cancelAllCategoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.cancelAllCategoriesButton.FlatAppearance.BorderSize = 0;
            this.cancelAllCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAllCategoriesButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.cancelAllCategoriesButton.Location = new System.Drawing.Point(488, 296);
            this.cancelAllCategoriesButton.Name = "cancelAllCategoriesButton";
            this.cancelAllCategoriesButton.Size = new System.Drawing.Size(146, 38);
            this.cancelAllCategoriesButton.TabIndex = 44;
            this.cancelAllCategoriesButton.Text = "إلغاء الكل";
            this.cancelAllCategoriesButton.UseVisualStyleBackColor = false;
            this.cancelAllCategoriesButton.Click += new System.EventHandler(this.CancelAllCategoriesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(139, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "إضغط مرتين للإضافة";
            // 
            // categoriesConfirmButton
            // 
            this.categoriesConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.categoriesConfirmButton.FlatAppearance.BorderSize = 0;
            this.categoriesConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesConfirmButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.categoriesConfirmButton.Location = new System.Drawing.Point(438, 456);
            this.categoriesConfirmButton.Name = "categoriesConfirmButton";
            this.categoriesConfirmButton.Size = new System.Drawing.Size(115, 35);
            this.categoriesConfirmButton.TabIndex = 47;
            this.categoriesConfirmButton.Text = "موافق";
            this.categoriesConfirmButton.UseVisualStyleBackColor = false;
            this.categoriesConfirmButton.Click += new System.EventHandler(this.CategoriesConfirmButton_Click);
            // 
            // categorySearchtextBox
            // 
            this.categorySearchtextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categorySearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categorySearchtextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchtextBox.Location = new System.Drawing.Point(143, 184);
            this.categorySearchtextBox.Name = "categorySearchtextBox";
            this.categorySearchtextBox.Size = new System.Drawing.Size(339, 32);
            this.categorySearchtextBox.TabIndex = 48;
            this.categorySearchtextBox.TextChanged += new System.EventHandler(this.CategorySearchtextBox_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.exitButton.Location = new System.Drawing.Point(563, 456);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 35);
            this.exitButton.TabIndex = 49;
            this.exitButton.Text = "إغلاق";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.messageLabel.Location = new System.Drawing.Point(138, 427);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(37, 20);
            this.messageLabel.TabIndex = 51;
            this.messageLabel.Text = ">>...";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(991, 579);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.categorySearchtextBox);
            this.Controls.Add(this.categoriesConfirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelAllCategoriesButton);
            this.Controls.Add(this.addAllCategoriesButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.addCategoriesListBox);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.newCategoryButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CategoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox categoryNumberTextBox;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.ListBox addCategoriesListBox;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button addAllCategoriesButton;
        private System.Windows.Forms.Button cancelAllCategoriesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button categoriesConfirmButton;
        private System.Windows.Forms.TextBox categorySearchtextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}