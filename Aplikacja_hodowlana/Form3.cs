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
        private Reptiles reptiles;
        private DataBase dataBase;
        private static string jsonFilePath = @"C:\Users\kosso\OneDrive\Pulpit\Reptiles.json";

        public Form3()
        {
            InitializeComponent();

            try
            {

                dataBase = LoadFromJsonFile(jsonFilePath);
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
            
           
            dataGridView1.DataSource = dataBase.Reptiles;
            dataGridView1.Columns["ID"].Visible = false;
            if (!dataGridView1.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "btnDelete";
                deleteButton.HeaderText = "Akcje";
                deleteButton.Text = "Usuń";
                deleteButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(deleteButton);
            }


           if (!dataGridView1.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "btnEdit";
                editButton.HeaderText = "Akcje";
                editButton.Text = "Edytuj";
                editButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(editButton);
            }

            dataGridView1.Columns["ID"].DisplayIndex = 1;
            dataGridView1.Columns["Name"].DisplayIndex = 2;
            dataGridView1.Columns["Species"].DisplayIndex = 3;
            dataGridView1.Columns["Age"].DisplayIndex = 4;
            dataGridView1.Columns["Sex"].DisplayIndex = 5;
            dataGridView1.Columns["Lenght"].DisplayIndex = 6;
            dataGridView1.Columns["Weight"].DisplayIndex = 7;
            dataGridView1.Columns["Climate"].DisplayIndex = 8;
            dataGridView1.Columns["Humidity"].DisplayIndex = 9;
            dataGridView1.Columns["ActivityTime"].DisplayIndex = 10;
            dataGridView1.Columns["Environment"].DisplayIndex = 11;
            dataGridView1.Columns["Suplements"].DisplayIndex = 12;
            dataGridView1.Columns["DateOfLastFeeding"].DisplayIndex = 13;
            dataGridView1.Columns["DateOfBirth"].DisplayIndex = 14;
            dataGridView1.Columns["Group"].DisplayIndex = 15;
            dataGridView1.Columns["Added"].DisplayIndex = 16;
            dataGridView1.Columns["MonthlyCost"].DisplayIndex = 17;
            dataGridView1.Columns["TotalCost"].DisplayIndex = 18;
            dataGridView1.Columns["btnEdit"].DisplayIndex = 0;
            dataGridView1.Columns["btnDelete"].DisplayIndex = 1;







        }

        private void RefreshData()
        {
            DataBase dataBase = LoadFromJsonFile(jsonFilePath);
            DisplayData(dataBase);
        }
          private void DeleteReptile(Reptiles reptile)
        {
            
            dataBase.Reptiles.Remove(reptile);

            
            SaveToJsonFile(dataBase);
        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                   
                    var selectedReptile = (Reptiles)senderGrid.Rows[e.RowIndex].DataBoundItem;
                    
                   
                    Form4 editForm = new Form4(selectedReptile);
                    editForm.ShowDialog();

                    
                    RefreshData();
                }
            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "btnDelete")
           {
                   
                    var selectedReptile = (Reptiles)senderGrid.Rows[e.RowIndex].DataBoundItem;
                MessageBox.Show("Przycisk Usuń został kliknięty");
                
                DeleteReptile(selectedReptile);

                    
                    RefreshData();
           }
            


        }
        private void SaveToJsonFile(DataBase dataBase)
        {
            string json = JsonConvert.SerializeObject(dataBase);
            File.WriteAllText(jsonFilePath, json);
        }
      
        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
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
