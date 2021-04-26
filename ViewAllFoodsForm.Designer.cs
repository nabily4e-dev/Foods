namespace Foods
{
    partial class ViewAllFoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.componentsRadioButton = new System.Windows.Forms.RadioButton();
            this.howToRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.MaximizeScreenButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Controls.Add(this.MaximizeScreenButton);
            this.panelHeader.Controls.Add(this.closeButton);
            this.panelHeader.Location = new System.Drawing.Point(-1, 1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(992, 42);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.DoubleClick += new System.EventHandler(this.PanelHeader_DoubleClick);
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
            this.closeButton.Location = new System.Drawing.Point(948, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AllowUserToAddRows = false;
            this.foodDataGridView.AllowUserToDeleteRows = false;
            this.foodDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.foodDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.foodDataGridView.Location = new System.Drawing.Point(11, 77);
            this.foodDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.ReadOnly = true;
            this.foodDataGridView.Size = new System.Drawing.Size(969, 500);
            this.foodDataGridView.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemname";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "الأكلة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "itemimage";
            this.Column2.HeaderText = "الصورة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "categories";
            this.Column3.HeaderText = "التصنيفات";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 97;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "itemcomponents";
            this.Column4.HeaderText = "المقادير";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "itemdescription";
            this.Column5.HeaderText = "التحضير";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 88;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "itemcode";
            this.Column6.HeaderText = "كود الأكلة";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 77;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(325, 49);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.searchTextBox.Size = new System.Drawing.Size(431, 24);
            this.searchTextBox.TabIndex = 47;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // componentsRadioButton
            // 
            this.componentsRadioButton.AutoSize = true;
            this.componentsRadioButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.componentsRadioButton.Location = new System.Drawing.Point(161, 47);
            this.componentsRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.componentsRadioButton.Name = "componentsRadioButton";
            this.componentsRadioButton.Size = new System.Drawing.Size(72, 26);
            this.componentsRadioButton.TabIndex = 46;
            this.componentsRadioButton.Text = "المقادير";
            this.componentsRadioButton.UseVisualStyleBackColor = true;
            // 
            // howToRadioButton
            // 
            this.howToRadioButton.AutoSize = true;
            this.howToRadioButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.howToRadioButton.Location = new System.Drawing.Point(240, 47);
            this.howToRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.howToRadioButton.Name = "howToRadioButton";
            this.howToRadioButton.Size = new System.Drawing.Size(81, 26);
            this.howToRadioButton.TabIndex = 45;
            this.howToRadioButton.Text = "التحضير";
            this.howToRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.categoryRadioButton.Location = new System.Drawing.Point(73, 47);
            this.categoryRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(82, 26);
            this.categoryRadioButton.TabIndex = 44;
            this.categoryRadioButton.Text = "التصنيف";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameRadioButton.Location = new System.Drawing.Point(11, 47);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(58, 26);
            this.nameRadioButton.TabIndex = 43;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "الأسم";
            this.nameRadioButton.UseVisualStyleBackColor = true;
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
            this.MaximizeScreenButton.Click += new System.EventHandler(this.MaximizeScreenButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CountLabel.Location = new System.Drawing.Point(760, 55);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 20);
            this.CountLabel.TabIndex = 49;
            this.CountLabel.Text = ".";
            // 
            // ViewAllFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.ControlBox = false;
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.foodDataGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.componentsRadioButton);
            this.Controls.Add(this.howToRadioButton);
            this.Controls.Add(this.categoryRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllFoodsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllFoodsForm";
            this.Load += new System.EventHandler(this.ViewAllFoodsForm_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton componentsRadioButton;
        private System.Windows.Forms.RadioButton howToRadioButton;
        private System.Windows.Forms.RadioButton categoryRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Button MaximizeScreenButton;
        private System.Windows.Forms.Label CountLabel;
    }
}