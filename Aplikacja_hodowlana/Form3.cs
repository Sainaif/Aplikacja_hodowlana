using Microsoft.VisualBasic.ApplicationServices;
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

namespace Aplikacja_hodowlana
{
    public partial class Form3 : Form
    {
       
        private static string jsonFilePath = @"C:\Users\kosso\OneDrive\Pulpit\Reptiles.json";

        public Form3()
        {
            InitializeComponent(); 

            try
            {
                DataBase dataBase = LoadFromJsonFile(jsonFilePath);
                string jsonContent = JsonConvert.SerializeObject(dataBase, Formatting.Indented);
                richTextBox.Text = jsonContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania danych: " + ex.Message);
            }
        }

        public static DataBase LoadFromJsonFile(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = jsonFilePath;
            }

            if (!File.Exists(filePath))
            {
                return new DataBase();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<DataBase>(json);
        }
    }



}
