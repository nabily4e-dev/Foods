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
    public partial class LoginForm : Form
    {

        private bool mouseDown = false;
        private Point lastLocation;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void ControlSetFocus(Control control)
        {
            // Set focus to the control, if it can receive focus.
            if (control.CanFocus)
            {
                control.Focus();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            this.Close();

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

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "napil" && passwordTextBox.Text == "123")
            {

                wrongUsernameAction.BackColor = Color.MediumSpringGreen;
                wrongPassordAction.BackColor = Color.MediumSpringGreen;
                loginButton.BackColor = Color.SpringGreen;

            }


        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            ControlSetFocus(passwordTextBox);

            if (usernameTextBox.Text == "napil")
            {

                wrongUsernameAction.BackColor = Color.MediumSpringGreen;

            }

        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            LoginButton_Click(sender, e);

        }
    }
}
