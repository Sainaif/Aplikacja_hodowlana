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
                DisplayData(dataBase);
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
        private void DisplayData(DataBase dataBase)
        {
            foreach (var item2 in dataBase.Amphibians)
            {
                dataGridView1.DataSource = dataBase.Amphibians;
            }
            foreach (var item3 in dataBase.Arthropods)
            {
                dataGridView1.DataSource = dataBase.Arthropods;
            }
            foreach (var item in dataBase.Reptiles)
            {
                dataGridView1.DataSource = dataBase.Reptiles;
            }
           
        }



        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }



}
