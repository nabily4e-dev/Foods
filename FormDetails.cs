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
    public partial class FormDetails : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;

        public FormDetails()
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

            this.Close();

        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {

            closeButton.Cursor = Cursors.Hand;

        }

    }

}
