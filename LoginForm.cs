using System;
using System.Data;
using System.Drawing;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {

            //Database.RunRequest("INSERT INTO users (username, user_password) VALUES('napil303', '123');");
            DataTable UsersDataTable = Database.GetData("SELECT username, user_password from users");

            foreach (DataRow row in UsersDataTable.Rows)
            {

                if (usernameTextBox.Text == row["username"].ToString() && passwordTextBox.Text == row["user_password"].ToString())
                {

                    wrongUsernameAction.BackColor = Color.MediumSpringGreen;
                    wrongPassordAction.BackColor = Color.MediumSpringGreen;
                    LoginButton.BackColor = Color.SpringGreen;

                }
                else
                {

                    wrongUsernameAction.BackColor = Color.FromArgb(46, 138, 230);

                }

            }

        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataTable UsersDataTable = Database.GetData("SELECT username, user_password from users");

            //if (usernameTextBox.Text != "")
            //{

            //    foreach (DataRow row in UsersDataTable.Rows)
            //    {

            //        if (usernameTextBox.Text == row["username"].ToString())
            //        {

            //            wrongUsernameAction.BackColor = Color.MediumSpringGreen;

            //        }
            //        else
            //        {

            //            wrongUsernameAction.BackColor = Color.FromArgb(46, 138, 230);

            //        }

            //    }

            //}

            //if (Control.ModifierKeys == Keys.Enter)
            //{

            //    ControlSetFocus(passwordTextBox);

            //}

        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //DataTable UsersDataTable = Database.GetData("SELECT username, user_password from users");

            //if (passwordTextBox.Text != "")
            //{

            //    foreach (DataRow row in UsersDataTable.Rows)
            //    {

            //        if (passwordTextBox.Text == row["user_password"].ToString())
            //        {

            //            wrongPassordAction.BackColor = Color.MediumSpringGreen;

            //        }
            //        else
            //        {

            //            wrongPassordAction.BackColor = Color.FromArgb(46, 138, 230);

            //        }

            //    }

            //}

            //if (Control.ModifierKeys == Keys.Enter)
            //{

            //    //ControlSetFocus(passwordTextBox);
            //    LoginButton_Click(sender, e);


            //}


        }

        private void SohwRegistrationFormButton_Click(object sender, EventArgs e)
        {

            RegistrationForm register = new RegistrationForm();
            register.Show();
            Database.CloseConnection();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            passwordTextBox.UseSystemPasswordChar = true;
            Database.OpenConnection();

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

            DataTable UsersDataTable = Database.GetData("SELECT username, user_password from users");

            if (passwordTextBox.Text != "")
            {

                foreach (DataRow row in UsersDataTable.Rows)
                {

                    if (passwordTextBox.Text == row[0].ToString())
                    {

                        wrongPassordAction.BackColor = Color.MediumSpringGreen;

                    }
                    else
                    {

                        wrongPassordAction.BackColor = Color.FromArgb(46, 138, 230);

                    }

                }

            }

            if (Control.ModifierKeys == Keys.Enter)
            {

                ControlSetFocus(passwordTextBox);

            }

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

            DataTable UsersDataTable = Database.GetData("SELECT username, user_password from users");
            if(MyUse)
            if (usernameTextBox.Text != "")
            {


                for (int x = 0; x < UsersDataTable.Rows.Count; x++)
                {

                    DataRow row = UsersDataTable.Rows[x];

                    if (usernameTextBox.Text == row.ToString())
                    {

                        wrongUsernameAction.BackColor = Color.MediumSpringGreen;

                    }
                    else
                    {

                        wrongUsernameAction.BackColor = Color.FromArgb(46, 138, 230);

                    }

                }

            }

            if (Control.ModifierKeys == Keys.Enter)
            {

                ControlSetFocus(passwordTextBox);

            }

        }

        private void ShowPassWordPictureBox_MouseEnter(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void ShowPassWordPictureBox_MouseLeave(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }

}
