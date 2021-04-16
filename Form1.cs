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
    public partial class Form1 : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;


        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

                int newX = (this.Location.X - lastLocation.X) + e.X;
                int newY = (this.Location.Y - lastLocation.Y) + e.Y;

                this.Location = new Point(newX, newY);

            }

        }
    }
}
