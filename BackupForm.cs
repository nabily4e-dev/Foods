using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foods
{
    public partial class BackupForm : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;

        public BackupForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            Close();

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

            panelHeader.Width = Width;

        }



        private void PanelHeader_DoubleClick(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;

        }

        private void CreateBacupButton_Click(object sender, EventArgs e)
        {

            Database.CloseConnection();

            try
            {

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "الرجاء إختيار مسار التسخة الإحتياطية.";

                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    DateTime Now = DateTime.Now;
                    string FileName = fbd.SelectedPath + "\\myfoods_" + Now.Year + "_" + Now.Month + "_" + Now.Day + "___" + Now.Hour + "_" + Now.Minute + "_" + Now.Second;

                    File.Copy("foods", FileName);

                    MessageBox.Show("تم أخذ النسخة الإحتياطية بنجاح." + "\n" + "مسار النسخة: " + FileName);



                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            Database.OpenConnection();

        }
    }
}
