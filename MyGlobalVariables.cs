using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foods
{
    class MyGlobalVariables
    {

        public static List<Tuple<int, string>> Categories = new List<Tuple<int, string>>();

        public static string GetFoodCodeTextBox = "0";

        public static string DeleteConfirmed = "";

        public static DataTable dtblAll = new DataTable();



    }
}
