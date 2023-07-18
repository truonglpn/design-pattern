
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        OpenFileDialog openFileDialog;
        private static string AddSquareBrackets(string json)
        {
            return $"[{json}]";
        }
   

        private static DataTable ConvertJsonToDataTable(string jsonData)
        {
            try
            {
                return JsonConvert.DeserializeObject<DataTable>(jsonData);
            }
            catch
            {
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //csvMinder.DataMine("file_test.csv");
            // FileTemplate excelMiner = new Excel();
            //   var json = @"
            //{
            // 'access_token': 'b9fbb7994e50899e2d5eaf012eee9fb0.d3e8a8d4ba960e9aca4cc156',
            // 'api_domain': 'http://www.codeproject.com',
            // 'token_type': 'Bearer',
            // 'expires_in': 12312                
            //}";

            //   json = AddSquareBrackets(json);

            //   var dt = ConvertJsonToDataTable(json);

        }
    }
}
