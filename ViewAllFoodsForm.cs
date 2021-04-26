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
    public partial class ViewAllFoodsForm : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;

        public ViewAllFoodsForm()
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

        private void CloseButton_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void MaximizeScreenButton_Click(object sender, EventArgs e)
        {

            if (MaximizeScreenButton.Text == "ـــ")
            {

                WindowState = FormWindowState.Maximized;
                MaximizeScreenButton.Text = "ــ";
                MaximizeScreenButton.TextAlign = ContentAlignment.TopCenter;

            }
            else
            {

                WindowState = FormWindowState.Normal;
                MaximizeScreenButton.Text = "ـــ";
                MaximizeScreenButton.TextAlign = ContentAlignment.BottomCenter;

            }

            foodDataGridView.Width = Width - (panelHeader.Height + searchTextBox.Height + 20);
            panelHeader.Width = Width;

        }

        private void CounterLabelView()
        {

            CountLabel.Text = "معروض " + foodDataGridView.Rows.Count + " أكلة";

        }

        private void ViewAllFoodsForm_Load(object sender, EventArgs e)
        {

            foodDataGridView.DataSource = MyGlobalVariables.dtblAll;
            CounterLabelView();

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            string strPattern = "";

            if (nameRadioButton.Checked) strPattern += "itemanme";
            else if (categoryRadioButton.Checked) strPattern += "categories";
            else if (componentsRadioButton.Checked) strPattern += "components";
            else strPattern += "itemdescription";

            strPattern += " like'%" + searchTextBox.Text + "%'";

            DataView dv = new DataView(MyGlobalVariables.dtblAll);
            dv.RowFilter = strPattern;
            foodDataGridView.DataSource = dv;

            CounterLabelView();

        }

        private void PanelHeader_DoubleClick(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;

        }
    }

}
