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
    public partial class ConfirmDeletionForm : Form
    {

        public ConfirmDeletionForm()
        {

            InitializeComponent();

        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {

            this.Opacity += 0.1;
            if (this.Opacity >= 1) FadeInTimer.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            FadeOutTimer.Enabled = true;

        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {

            this.Opacity -= 0.1;
            if (this.Opacity <= 0) this.Close();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            MyGlobalVariables.GetFoodCodeTextBox = ">> ";

            try
            {

                Database.RunRequest("delete from foodimage where itemcode=" + MyGlobalVariables.GetFoodCodeTextBox);
                MyGlobalVariables.DeleteConfirmed += "تم حذف الصورة";

                Database.RunRequest("delete from foodcategories where itemcode=" + MyGlobalVariables.GetFoodCodeTextBox);

                MyGlobalVariables.DeleteConfirmed += ", " + "تم حذف التصنيفات";

                Database.RunRequest("delete from foodcomponents where itemcode=" + MyGlobalVariables.GetFoodCodeTextBox);
                MyGlobalVariables.DeleteConfirmed += ", " + "تم حذف المقاير";

                Database.RunRequest("delete from food where itemcode=" + MyGlobalVariables.GetFoodCodeTextBox);
                MyGlobalVariables.DeleteConfirmed += ", " + "تم حذف الأكلة";

            }
            catch (Exception ex)
            {

                MyGlobalVariables.GetFoodCodeTextBox += "خطأ: " + ex.Message;

            }
            finally
            {

                CancelButton.PerformClick();

            }

        }
    }

}
