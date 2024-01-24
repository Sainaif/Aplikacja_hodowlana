using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_hodowlana
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            
            InitializeComponent();
            suborder.Items.Clear();
            Weight.Enabled = false;
            Length.Enabled = false;
            BodyLength.Enabled = false;
            Food_weight.Enabled = false;
            Suplements.Enabled = false;
            Type.Items.Clear();
            Type.Items.AddRange(new string[] { "Gady", "Pajęczaki", "Płazy", "Owady", "Inne" });


            Activity.Items.Clear();
            Activity.Items.AddRange(new string[] { "Dzień", "Noc" });

            Enviroment_forms.Items.Clear();
            Enviroment_forms.Items.AddRange(new string[] { "Pustynia", "Stepy", "Las", "Tropikalny las" });

            Climate.Items.Clear();
            Climate.Items.AddRange(new string[] { "Zimny(<20°C)", "Umiarkowany(20-25)°C", "Ciepły(25-35°C)", "Gorący(35+°C)" });

            
          //  suborder.Items.AddRange(new string[] { "Węże", "Jaszczurki", "Owady", "Pająki" ,"Skorpiony", "Żaby" });
           
            Humidity.Items.Clear();
            Humidity.Items.AddRange(new string[] { "Niska(<40%)", "Średnia(40-60%)", "Wysoka(60-80%)", "Bardzo wysoka(80+%)", "Zmienna" });

            BodyLength.Items.Clear();
            BodyLength.Items.AddRange(new string[] { "0.5DC", "1", "1.5", "2","2.5","3","3.5","4","4.5","5","5.5", "6","6.5","7","7.5","8","8.5","9","9.5","10"  });
         
            Suplements.Items.Clear();
            Suplements.Items.AddRange(new string[] { "Tak", "Nie" });

            Food_weight.Items.Clear();
            Food_weight.Items.AddRange(new string[] { "Tak", "Nie" });
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
        }
        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Type.SelectedItem != null && Type.SelectedItem.ToString() == "Gady")
            {
                suborder3.Items.Clear();
                suborder3.Items.AddRange(new string[] { "Węże", "Jaszczurki" });
                suborder3.Enabled = true;
                Weight.Enabled = true;
                Length.Enabled = true;
                BodyLength.Enabled = false;
                
                if (suborder3.SelectedItem != null && suborder3.SelectedItem.ToString() == "Węże")
                {
                    Food_weight.Enabled = true;
                    Suplements.Enabled = false;
                }
                else
                {
                    Food_weight.Enabled = false;
                    Suplements.Enabled = true;
                }
                
            }
            else if (Type.SelectedItem.ToString() == "Płazy")
            {
                suborder3.Items.Clear();
                suborder3.Items.AddRange(new string[] { "Żaby" });
                suborder3.Enabled = true;
                Weight.Enabled = true;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = true;
                Food_weight.Enabled = false;
            }
            else if (Type.SelectedItem.ToString() == "Pajęczaki")
            {
                suborder3.Items.Clear();
                suborder3.Items.AddRange(new string[] { "Pająki", "Skorpiony" });
                suborder3.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = false;
                Food_weight.Enabled = false;
            }
            else if (Type.SelectedItem.ToString() == "Owady")
            {
                suborder3.Items.Clear();
                suborder3.Items.AddRange(new string[] { "Modliszki", "Straszyki", "Patyczaki" });
                suborder3.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = false;
                Food_weight.Enabled = false;
            }
            else if (Type.SelectedItem.ToString() == "Inne")
            {
                suborder3.Items.Clear();
                suborder3.Items.AddRange(new string[] { "Inne" });
                suborder3.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = false;
                Suplements.Enabled = false;
                Food_weight.Enabled = false;
            }
            
        }

       
        private void Add_animal_Click(object sender, EventArgs e)
        {

            //DataBase dataBase = new DataBase();
            

            if (Type.SelectedItem.ToString() == "Gady")
            {
                
                var reptile = new Reptiles()
                {
                    
                    Group = Type.SelectedItem.ToString(),
                    Name = textBox1.Text,
                    Species = textBox2.Text,
                    Environment = Enviroment_forms.SelectedItem.ToString(),
                    ActivityTime = Activity.SelectedItem.ToString(),
                    
                    DateOfBirth = dateTimePicker1.Value, 
                    Morph = textBox18.Text,
                    Lenght = Convert.ToDouble(Length.Text),
                    Weight = Convert.ToDouble(Weight.Text),
                    Suplements = Suplements.SelectedItem.ToString() == "Tak" ? true : false,
                    Humidity = Humidity.SelectedItem.ToString(),
                    Climate = Climate.SelectedItem.ToString(),
                    Added = DateTime.Now,

                };
                
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Reptiles.json");
                DataBase dataBase = File.Exists(filePath) ? DataBase.LoadFromJsonFile(filePath) : new DataBase();

                dataBase.AddReptile(reptile);
                dataBase.SaveToJsonFile(filePath);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReturnToMenu(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
