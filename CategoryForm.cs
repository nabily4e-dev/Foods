using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foods
{
    public partial class CategoryForm : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;

        List<Tuple<int, string>> data = new List<Tuple<int, string>>();

        DataTable SearchTable = new DataTable();

        public CategoryForm()
        {
            InitializeComponent();
        }


        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;

            lastLocation = e.Location;

            panelHeader.Cursor = Cursors.SizeAll;

        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
            panelHeader.Cursor = Cursors.Default;

        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {

                int newX = (this.Location.X - lastLocation.X) + e.Location.X;
                int newY = (this.Location.Y - lastLocation.Y) + e.Location.Y;

                Location = new Point(newX, newY);

            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            this.Close();
      
        }
        
        private void GetAuto()
        {

            //byte[] t = ['1','2'];

            //Encoding.Convert(srcEncoding: UTF8Encoding.UTF8, dstEncoding: UnicodeEncoding.Unicode, t);

            DataTable dataTable = Database.GetData("select max(catNumber)+1 from categories");
            categoryNumberTextBox.Text = dataTable.Rows[0][0].ToString();

            if (categoryNumberTextBox.Text.Trim() == "") categoryNumberTextBox.Text = "1";

            addCategoryButton.Enabled = true;
            deleteCategoryButton.Enabled = false;
            categoryNameTextBox.Select();

        }

        private void ShowCategorey()
        {

            categoryDataGridView.DataSource = Database.GetData("select * from categories");

        }

        private void ClearAndShow()
        {

            categoryNameTextBox.Text = "";
            ShowCategorey();
            GetAuto();
            SearchTable = Database.GetData("select * from categories");

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

            ClearAndShow();
            
        }

        private void NewCategoryButton_Click(object sender, EventArgs e)
        {

            categoryNameTextBox.Text = "";
            GetAuto();

        }


        protected void categoryNameTextBox_TextChanged(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(categoryNameTextBox.Text))

            {

                if (categoryNameTextBox.Text == categoryDataGridView.CurrentRow.Cells[1].Value.ToString())
                {

                    if (addCategoryButton.Enabled == true)
                    {

                        addCategoryButton.Enabled = false;
                        addCategoryButton.BackColor = Color.LightGray;

                        messageLabel.Text = ">> " + "التصنيف موجود مسبقا!";

                    }

                }
                else
                {

                    addCategoryButton.Enabled = true;
                    addCategoryButton.BackColor = Color.FromArgb(46, 138, 230);

                    messageLabel.Text = ">> ";

                }

            }

        }

        private void AddCategoryButton_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (categoryNameTextBox.Text.Trim() != "")
                {

                    

                    Database.RunRequest("insert into categories values(" + categoryNumberTextBox.Text + ", '" + categoryNameTextBox.Text + "')");
                    ClearAndShow();

                }



            }
            catch (Exception ex)
            {

                messageLabel.Text = ">>" + "حدث خطأ، " + ex.Message;

            }

        }

        private void CategoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if(categoryDataGridView.CurrentRow != null)
            {

                categoryNumberTextBox.Text = categoryDataGridView.CurrentRow.Cells[0].Value.ToString();
                //categoryNameTextBox.Text = categoryDataGridView.CurrentRow.Cells[1].Value.ToString();

                addCategoryButton.Enabled = false;

                if (addCategoriesListBox.Items.Count == 0) deleteCategoryButton.Enabled = true;
                else
                    deleteCategoryButton.Enabled = false;

            }

        }

        private void AddCategoryButton_EnabledChanged(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = (((Button)sender).Enabled) ? Color.FromArgb(46, 138, 230) : Color.LightGray;

        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (categoryNumberTextBox.Text.Trim() == "")
                    categoryNumberTextBox.Text = "0";

                Database.RunRequest("delete from categories where catNumber =" + categoryNumberTextBox.Text);
                ClearAndShow();

            }
            catch (Exception ex)
            {

                //messageLabel.Text = ">>" + "حدث خطأ، " + ex.Message;
                MessageBox.Show(ex.Message);

            }

        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void DeleteCategoryButton_EnabledChanged(object sender, EventArgs e)
        {

            AddCategoryButton_EnabledChanged(sender, e);

        }

        private void SetItems()
        {

            addCategoriesListBox.ValueMember = "Item1";
            addCategoriesListBox.DisplayMember = "Item2";

            BindingSource bs = new BindingSource();
            bs.DataSource = data.Distinct();
            addCategoriesListBox.DataSource = bs;

        }

        private void CategoryDataGridView_DoubleClick(object sender, EventArgs e)
        {

            if (categoryDataGridView.CurrentRow != null)
            {

                data.Add(new Tuple<int, string>((int)categoryDataGridView.CurrentRow.Cells[0].Value, categoryDataGridView.CurrentRow.Cells[1].Value.ToString()));

            }

            SetItems();

            deleteCategoryButton.Enabled = false;

        }

        private void AddAllCategoriesButton_Click(object sender, EventArgs e)
        {

            data.Clear();

            foreach (DataGridViewRow dtvr in categoryDataGridView.Rows)
            {

                data.Add(new Tuple<int, string>((int)dtvr.Cells[0].Value, dtvr.Cells[1].Value.ToString()));

            }

            SetItems();

            deleteCategoryButton.Enabled = false;

        }

        private void CancelAllCategoriesButton_Click(object sender, EventArgs e)
        {

            data.Clear();

            addCategoriesListBox.DataSource = data;

        }

        private void CategorySearchtextBox_TextChanged(object sender, EventArgs e)
        {

            DataView dataView = new DataView(SearchTable);
            dataView.RowFilter = "catName like '%" + categorySearchtextBox.Text + "%'";
            categoryDataGridView.DataSource = dataView;

        }

        private void CategoriesConfirmButton_Click(object sender, EventArgs e)
        {

            MyGlobalVariables.Categories.Clear();

            for(int x=0; x<addCategoriesListBox.Items.Count; x += 1)
            {

                addCategoriesListBox.SelectedIndex = x;
                MyGlobalVariables.Categories.Add(new 
                    Tuple<int, string>((int)addCategoriesListBox.SelectedValue,
                    addCategoriesListBox.GetItemText(addCategoriesListBox.Items[x])));

            }

            this.Close();

        }

        private void CategoryNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                AddCategoryButton_Click_1(sender, e);

            }

        }

    }

}
