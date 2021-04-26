using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foods
{
    public partial class FoodsForm : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;
        private bool addCategoryButtonWasClicked = false;


        public FoodsForm()
        {

            InitializeComponent();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {



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

        private void AutoNum()
        {

            MyGlobalVariables.Categories.Clear();

            foodCodeTextBox.Text = Database.GetData("select max(itemcode)+1 from food").Rows[0][0].ToString();

            if (foodCodeTextBox.Text.Trim() == "") foodCodeTextBox.Text = "1";

            foodNameTextBox.Text = "";
            imagePathTextBox.Text = "";
            foodPictureBox.Image = new PictureBox().Image;
            foodCategoriesTextBox.Text = "";
            componentTextBox.Text = "";
            componentsListBox.Items.Clear();
            howToTextBox.Text = "";
            //messageLabel.Text = "";
            foodNameTextBox.Select();

            addButton.Enabled = true;
            deleteButton.Enabled = false;
            editButton.Enabled = false;



        }


        DataTable dtblAll = new DataTable();
        private void ShowData()
        {

            dtblAll.Rows.Clear();
            DataTable dtblData = Database.GetData("select * from food_data");
            DataTable dtblCat = Database.GetData("select * from food_cat");
            DataTable dtblComp = Database.GetData("select * from foodcomponents");

            if (dtblAll.Columns.Count < 1)
            {

                dtblAll.Columns.Add("itemname");
                dtblAll.Columns.Add("itemimage", typeof(byte[]));
                dtblAll.Columns.Add("categories");
                dtblAll.Columns.Add("itemcomponents");
                dtblAll.Columns.Add("itemdescription");
                dtblAll.Columns.Add("itemcode");

            }

            for (int x = 0; x < dtblData.Rows.Count; x += 1)
            {

                DataRow row = dtblAll.NewRow();
                row[0] = dtblData.Rows[x][1];
                row[1] = dtblData.Rows[x][2];

                DataRow[] cat = dtblCat.Select("itemcode=" + dtblData.Rows[x][0].ToString());

                string strCat = "";

                foreach(var i in cat)
                {

                    strCat += i[1] + Environment.NewLine;

                }

                row[2] = strCat;

                DataRow[] Com = dtblComp.Select("itemcode=" + dtblData.Rows[x][0].ToString());

                string strCom = "";

                foreach(var i in Com)
                {

                    strCom += i[1]+Environment.NewLine;

                }

                row[3] = strCom;

                row[4] = dtblData.Rows[x][3];

                row[5] = dtblData.Rows[x][0];


                dtblAll.Rows.Add(row);

            }

            foodDataGridView.DataSource = dtblAll;

            CounterLabelView();
            
        }

        private void CounterLabelView()
        {

            CountLabel.Text = "معروض " + foodDataGridView.Rows.Count + " أكلة";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Icon = Icon.ExtractAssociatedIcon("Foods.exe");

            iconPictureBox.Image = Icon.ExtractAssociatedIcon("Foods.exe").ToBitmap();

            Database.OpenConnection();

            ShowData();

            AutoNum();

        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {

            addCategoryButtonWasClicked = true;

            CategoryForm catForm = new CategoryForm
            {
                Icon = this.Icon
            };
            catForm.ShowDialog();

            foodCategoriesTextBox.Text = "";

            foreach(var i in MyGlobalVariables.Categories)
            {

                foodCategoriesTextBox.Text += i.Item2 + ", ";

            }

        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog ofd = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Filter = "Image Files|*.jpg;.png"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(ofd.FileName))
                    {

                        imagePathTextBox.Text = ofd.FileName;
                        Bitmap bmp = new Bitmap(Image.FromFile(imagePathTextBox.Text), new Size(150, 150));
                        foodPictureBox.Image = bmp;

                    }

                }

            }
            catch (Exception ex)
            {

                messageLabel.Text = ">>" + "حدث خطأ، " + ex.Message;

            }

        }

        private void FoodsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Database.CloseConnection();

        }

        private void FoodPictureBox_Click(object sender, EventArgs e)
        {



        }

        private void AddComponentButton_Click(object sender, EventArgs e)
        {

            if (componentTextBox.Text.Trim() != "")
            {

                componentsListBox.Items.Add(componentTextBox.Text);

            }

            string[] StrArrayOfItems = new string[componentsListBox.Items.Count];
            componentsListBox.Items.CopyTo(StrArrayOfItems, 0);
            string[] StrArrayOfDistinctItems = StrArrayOfItems.Distinct().ToArray();

            componentsListBox.Items.Clear();
            componentsListBox.Items.AddRange(StrArrayOfDistinctItems);

            componentTextBox.Clear();

        }

        private void ComponentTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                AddComponentButton_Click(sender, e);

            }

        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {

            if (componentsListBox.Items.Count == 0)
                messageLabel.Text = ">> " + "Can not delete empty list!";
            else
            {

                messageLabel.Text = ">>";
                componentsListBox.Items.Clear();

            }
                

        }

        private void DeleteLastSelectedButton_Click(object sender, EventArgs e)
        {

            if (componentsListBox.Items.Count > 0)
            {

                componentsListBox.Items.RemoveAt(componentsListBox.Items.Count - 1);

            }

        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

            while (componentsListBox.SelectedItems.Count > 0)
            {

                componentsListBox.Items.Remove(componentsListBox.SelectedItems[0]);

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            Database.pgCommand.Parameters.Clear(); // Avoid conflicts.

            if (foodCodeTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + ".يوجد مشكلة في كود الاكلة (المخفي). الرجاء التواصل مع مطور البرنامج";

            }
            else if (foodNameTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "الأسم فارغ";
                foodNameTextBox.Select();

            }
            else if (imagePathTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "يجب إختيار صورة للطعام!";
                addImageButton.Select();

            }
            else if (foodCategoriesTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "يجب إظافة تصنيف واحد على الأقل!";
                foodCategoriesTextBox.Select();

            }
            else if (componentsListBox.Items.Count == 0)
            {

                messageLabel.Text = ">> " + "لا يوجد مقادير!";
                componentTextBox.Select();

            }
            else if (howToTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "طريقة التحضير فارغة!";

            }
            else
            {
                ////////////// Add button start here.
                messageLabel.Text = ">> ";

                try
                {

                    Database.RunRequest("insert into food values(" +
                        foodCodeTextBox.Text + ",'" + foodNameTextBox.Text +
                        "','" + howToTextBox.Text + "')");

                    messageLabel.Text += "تمت إظافة ـسم الأكلة.";


                    MemoryStream ms = new MemoryStream();
                    foodPictureBox.Image.Save(ms, ImageFormat.Jpeg);
                    Database.pgCommand.Parameters.AddWithValue("@img", ms.ToArray());
                    Database.RunRequest("insert into foodimage values(" + foodCodeTextBox.Text + ", @img )");

                    messageLabel.Text += ", " + "تم إظافة الصورة.";


                    foreach (var i in MyGlobalVariables.Categories)
                    {

                        Database.RunRequest("insert into foodcategories values(" + foodCodeTextBox.Text + ", " + i.Item1 + ")");

                    }

                    messageLabel.Text += ", " + "تم إظافة التصنيفات.";


                    foreach (var i in componentsListBox.Items)
                    {
                        Database.RunRequest("insert into foodcomponents values(" + foodCodeTextBox.Text + ", '" + i.ToString() + "')");
                    }

                    messageLabel.Text += ", " + "تم إظافة المقادير.";


                    AutoNum();

                    ShowData();

                }
                catch(Exception ex)
                {

                    messageLabel.Text += ", خطأ: " + ex.Message;

                }

            }

        }

        private void FoodCategoriesTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {

                AddCategoryButton_Click(sender, e);

            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {

            AutoNum();

        }

        private void CreateViewButton_Click(object sender, EventArgs e)
        {

            //Database.RunRequest("create view food_cat as select itemcode, catname, categories.catnumber from categories, foodcategories where categories.catnumber = foodcategories.catnumber");

            //Database.RunRequest("create view food_data as select food.itemcode, itemname, itemimage, itemdescription from food, foodimage where food.itemcode = foodimage.itemcode");

        }

        private void AddButton_EnabledChanged(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = (((Button)sender).Enabled) ? Color.FromArgb(46, 138, 230) : Color.LightGray;

        }

        private void EditButton_EnabledChanged(object sender, EventArgs e)
        {

            AddButton_EnabledChanged(sender, e);

        }

        private void DeleteButton_EnabledChanged(object sender, EventArgs e)
        {

            AddButton_EnabledChanged(sender, e);

        }

        private void FoodDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if(foodDataGridView.CurrentRow != null)
            {

                foodCodeTextBox.Text = foodDataGridView.CurrentRow.Cells[5].Value.ToString();
                foodNameTextBox.Text = foodDataGridView.CurrentRow.Cells[0].Value.ToString();
                imagePathTextBox.Text = "";

                MemoryStream ms = new MemoryStream((byte[])foodDataGridView.CurrentRow.Cells[1].Value);
                foodPictureBox.Image = Image.FromStream(ms);

                DataTable dtblCat = Database.GetData("select * from food_cat where itemcode=" + foodCodeTextBox.Text);
                MyGlobalVariables.Categories.Clear();

                foreach(DataRow dr in dtblCat.Rows)
                {

                    MyGlobalVariables.Categories.Add(new Tuple<int, string>((int)dr[2], dr[1].ToString()));

                }

                foodCategoriesTextBox.Text = "";

                foreach(var i in MyGlobalVariables.Categories)
                {

                    foodCategoriesTextBox.Text = i.Item2 + " , ";

                }

                DataTable dtblComp = Database.GetData("select * from foodcomponents where itemcode=" + foodCodeTextBox.Text);
                componentsListBox.Items.Clear();

                foreach(DataRow dr in dtblComp.Rows)
                {

                    componentsListBox.Items.Add(dr[1]);

                }

                howToTextBox.Text = foodDataGridView.CurrentRow.Cells[4].Value.ToString();

                addButton.Enabled = false;
                deleteButton.Enabled = true;
                editButton.Enabled = true
;            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            Database.pgCommand.Parameters.Clear(); // Avoid conflicts.

            if (foodCodeTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + ".يوجد مشكلة في كود الاكلة (المخفي). الرجاء التواصل مع مطور البرنامج";

            }
            else if (foodNameTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "الأسم فارغ";
                foodNameTextBox.Select();

            }
            else if (foodCategoriesTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "يجب إظافة تصنيف واحد على الأقل!";
                foodCategoriesTextBox.Select();

            }
            else if (componentsListBox.Items.Count == 0)
            {

                messageLabel.Text = ">> " + "لا يوجد مقادير!";
                componentTextBox.Select();

            }
            else if (howToTextBox.Text.Trim() == "")
            {

                messageLabel.Text = ">> " + "طريقة التحضير فارغة!";

            }
            else
            {
                /// Edit button start here.
                messageLabel.Text = ">> ";

                try
                {

                    Database.RunRequest("update food set itemname='" + foodNameTextBox.Text +
                        "',itemdescription='" + howToTextBox.Text + "' where itemcode=" + foodCodeTextBox.Text);

                    messageLabel.Text += "تم تعديل الطعام";

                    if (imagePathTextBox.Text.Trim() != "")
                    {

                        Database.RunRequest("delete from foodimage where itemcode=" + foodCodeTextBox.Text);

                        MemoryStream ms = new MemoryStream();
                        foodPictureBox.Image.Save(ms, ImageFormat.Jpeg);
                        Database.pgCommand.Parameters.AddWithValue("@img", ms.ToArray());
                        Database.RunRequest("insert into foodimage values(" + foodCodeTextBox.Text + ", @img )");

                        messageLabel.Text += ", " + "تم تعديل الصورة";

                    }


                    Database.RunRequest("delete from foodcategories where itemcode=" + foodCodeTextBox.Text);

                    foreach (var i in MyGlobalVariables.Categories)
                    {

                        Database.RunRequest("insert into foodcategories values(" + foodCodeTextBox.Text + ", " + i.Item1 + ")");

                    }

                    messageLabel.Text += ", " + "تم تعديل التصنيفات";


                    Database.RunRequest("delete from foodcomponents where itemcode=" + foodCodeTextBox.Text);

                    foreach (var i in componentsListBox.Items)
                    {
                        Database.RunRequest("insert into foodcomponents values(" + foodCodeTextBox.Text + ", '" + i.ToString() + "')");
                    }

                    messageLabel.Text += ", " + "تم تعديل المقادير";


                    ShowData();

                    AutoNum();

                }
                catch (Exception ex)
                {

                    messageLabel.Text += ", خطأ: " + ex.Message;

                }

            }

        }

        private void FoodCategoriesTextBox_TextChanged(object sender, EventArgs e)
        {

            if (addCategoryButtonWasClicked == true)
            {
                //MessageBox.Show("Wow!");
                addCategoryButtonWasClicked = false;
            }    

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            //messageLabel.Text = ">> ";

            //try
            //{

            //    Database.RunRequest("delete from foodimage where itemcode=" + foodCodeTextBox.Text);
            //    messageLabel.Text += "تم حذف الصورة";

            //    Database.RunRequest("delete from foodcategories where itemcode=" + foodCodeTextBox.Text);

            //    messageLabel.Text += ", " + "تم حذف التصنيفات";

            //    Database.RunRequest("delete from foodcomponents where itemcode=" + foodCodeTextBox.Text);
            //    messageLabel.Text += ", " + "تم حذف المقاير";

            //    Database.RunRequest("delete from food where itemcode=" + foodCodeTextBox.Text);
            //    messageLabel.Text += ", " + "تم حذف الأكلة";

            //    ShowData();

            //    AutoNum();


            //}
            //catch (Exception ex)
            //{

            //    messageLabel.Text += "خطأ: " + ex.Message;

            //}

            MyGlobalVariables.DeleteConfirmed = ">> ";

            MyGlobalVariables.GetFoodCodeTextBox = foodCodeTextBox.Text;

            new ConfirmDeletionForm().ShowDialog();

            messageLabel.Text = MyGlobalVariables.DeleteConfirmed;

            ShowData();

            AutoNum();


        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            string strPattern = "";

            if (nameRadioButton.Checked) strPattern += "itemanme";
            else if (categoryRadioButton.Checked) strPattern += "categories";
            else if (componentsRadioButton.Checked) strPattern += "components";
            else strPattern += "itemdescription";

            strPattern += " like'%" + searchTextBox.Text + "%'";

            DataView dv = new DataView(dtblAll);

            dv.RowFilter = strPattern;
            foodDataGridView.DataSource = dv;

            CounterLabelView();

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {

            ReportForm form = new ReportForm();
            form.Icon = this.Icon;

            ReportDataSource rds = new ReportDataSource("FoodDataSet", dtblAll);
            form.reportViewer1.LocalReport.DataSources.Clear();
            form.reportViewer1.LocalReport.DataSources.Add(rds);
            form.reportViewer1.LocalReport.Refresh();

            form.ShowDialog();

        }

        private void FoodSuggestionBbutton_Click(object sender, EventArgs e)
        {

            if (suggestCategoryTextBox.Text.Trim() != "")
            {

                string FilterString = "";

                for(int x = 0; x > MyGlobalVariables.Categories.Count; x += 1)
                {

                    FilterString += " categories like '%" + MyGlobalVariables.Categories[x].Item2 + "%' ";
                    if (x < MyGlobalVariables.Categories.Count - 1) FilterString += " or ";

                }

                DataRow[] rows = dtblAll.Select(FilterString);

                if (rows.Count() > 0)
                {

                    dtblAll = rows.CopyToDataTable();
                    foodDataGridView.DataSource = dtblAll;

                }
                else
                {

                    messageLabel.Text = ">> " + "لا توجد أكلات حسب التصنيف المدخل!";
                    return;

                }


            }

            if (dtblAll.Rows.Count > 0)
            {

                FormDetails form = new FormDetails();

                messageLabel.Text = ">> ";

                Random rand = new Random();

                int RandomFoodIndex = rand.Next(0, dtblAll.Rows.Count);

                form.FoodNameTextBox.Text = dtblAll.Rows[RandomFoodIndex][0].ToString();
                form.FoodCategoriesTextBox.Text = dtblAll.Rows[RandomFoodIndex][2].ToString();
                form.FoodComponentsTextBox.Text = dtblAll.Rows[RandomFoodIndex][3].ToString();
                form.HowToTextBox.Text = dtblAll.Rows[RandomFoodIndex][4].ToString();

                MemoryStream ms = new MemoryStream((byte[])dtblAll.Rows[RandomFoodIndex][1]);
                form.foodPictureBox.Image = Image.FromStream(ms);


                CounterLabelView();


                form.ShowDialog();

            }

        }

        private void AddSuggestionButton_Click(object sender, EventArgs e)
        {

            addButton.Enabled = false;
            deleteAllButton.Enabled = false;
            editButton.Enabled = false;

            MyGlobalVariables.Categories.Clear();

            CategoryForm form = new CategoryForm();

            form.Icon = this.Icon;
            form.ShowDialog();

            suggestCategoryTextBox.Clear();

            foreach(var i in MyGlobalVariables.Categories)
            {

                suggestCategoryTextBox.Text += i.Item2 + " , ";

            }

        }

        private void ViewAllFoodsButton_Click(object sender, EventArgs e)
        {

            MyGlobalVariables.dtblAll = dtblAll;

            ViewAllFoodsForm form = new ViewAllFoodsForm();

            form.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ShowData();

        }

        private void BackupOnClick_Click(object sender, EventArgs e)
        {

            new BackupForm().ShowDialog();

        }
    }

}

