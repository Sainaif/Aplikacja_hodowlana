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
    public partial class Form4 : Form
    {
        private Reptiles _reptiles;
        public Form4(Reptiles reptiles)
        {
            InitializeComponent();
            _reptiles = reptiles;
            Type.Text = _reptiles.Group;
            textBox1.Text = _reptiles.Name;
            textBox8.Text = _reptiles.Species;
            Activity.Text = _reptiles.ActivityTime;
            Enviroment_forms.Text = _reptiles.Environment;
            Climate.Text = _reptiles.Climate;
            Humidity.Text = _reptiles.Humidity;
            textBox18.Text = _reptiles.Morph;
            Length.Text = _reptiles.Lenght.ToString();
            Weight.Text = _reptiles.Weight.ToString();
            Suplements.Text = _reptiles.Suplements ? "Tak" : "Nie";
            dateTimePicker1.Value = _reptiles.DateOfBirth;
            MonthlyCost.Text = _reptiles.MonthlyCost.ToString();
            sex.Text = _reptiles.Sex;

            Type.Items.Clear();
            Type.Items.AddRange(new string[] { "Gady", "Pajęczaki", "Płazy", "Owady", "Inne" });

            sex.Items.Clear();
            sex.Items.AddRange(new string[] { "Samiec", "Samica", "Brak" });

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
            BodyLength.Items.AddRange(new string[] { "0.5DC", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10" });

            Suplements.Items.Clear();
            Suplements.Items.AddRange(new string[] { "Tak", "Nie" });


            Weight.Enabled = false;
            Length.Enabled = false;
            BodyLength.Enabled = false;

            Suplements.Enabled = false;
            suborder.Enabled = false;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            Refresh();
        }
        public void UpdateReptile(DataBase dataBase, Reptiles updatedReptile)
        {
            
            var reptile = dataBase.Reptiles.FirstOrDefault(r => r.Id == updatedReptile.Id);
            if (reptile != null)
            {
               
                reptile.Name = updatedReptile.Name;
                reptile.Species = updatedReptile.Species;
                reptile.Environment = updatedReptile.Environment;
                reptile.ActivityTime = updatedReptile.ActivityTime;
                reptile.DateOfBirth = updatedReptile.DateOfBirth;
                reptile.Morph = updatedReptile.Morph;
                reptile.Lenght = updatedReptile.Lenght;
                reptile.Weight = updatedReptile.Weight;
                reptile.Suplements = updatedReptile.Suplements;
                reptile.Humidity = updatedReptile.Humidity;
                reptile.Climate = updatedReptile.Climate;
                reptile.MonthlyCost = updatedReptile.MonthlyCost;
                reptile.Sex = updatedReptile.Sex;
                reptile.Group = updatedReptile.Group;

                    


               
                
            }
        }
        private void Add_animal_Click(object sender, EventArgs e)
        {
            

                _reptiles.Group = Type.SelectedItem.ToString();
                _reptiles.Name = textBox1.Text;
                _reptiles.Species = textBox2.Text;
                _reptiles.Environment = Enviroment_forms.SelectedItem.ToString();
                _reptiles.ActivityTime = Activity.SelectedItem.ToString();
                _reptiles.DateOfBirth = dateTimePicker1.Value;
                _reptiles.Morph = textBox18.Text;
                _reptiles.Lenght = Convert.ToDouble(Length.Text);
                _reptiles.Weight = Convert.ToDouble(Weight.Text);
                _reptiles.Suplements = Suplements.SelectedItem.ToString() == "Tak" ? true : false;
                _reptiles.Humidity = Humidity.SelectedItem.ToString();
                _reptiles.Climate = Climate.SelectedItem.ToString();
                _reptiles.Added = DateTime.Now;
                _reptiles.MonthlyCost = Convert.ToDouble(MonthlyCost.Text);
                _reptiles.Sex = sex.SelectedItem.ToString();
               

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Reptiles.json");
                DataBase dataBase = File.Exists(filePath) ? DataBase.LoadFromJsonFile(filePath) : new DataBase();

                UpdateReptile(dataBase, _reptiles);
                dataBase.SaveToJsonFile(filePath);
                this.Close();
            
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type.SelectedItem != null && Type.SelectedItem.ToString() == "Gady")
            {
                suborder.Items.Clear();
                suborder.Items.AddRange(new string[] { "Węże", "Jaszczurki" });
                suborder.Enabled = true;
                Weight.Enabled = true;
                Length.Enabled = true;
                BodyLength.Enabled = false;
                Suplements.Enabled = true;

            }
            else if (Type.SelectedItem.ToString() == "Płazy")
            {
                suborder.Items.Clear();
                suborder.Items.AddRange(new string[] { "Żaby" });
                suborder.Enabled = true;
                Weight.Enabled = true;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = true;

            }
            else if (Type.SelectedItem.ToString() == "Pajęczaki")
            {
                suborder.Items.Clear();
                suborder.Items.AddRange(new string[] { "Pająki", "Skorpiony" });
                suborder.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = false;

            }
            else if (Type.SelectedItem.ToString() == "Owady")
            {
                suborder.Items.Clear();
                suborder.Items.AddRange(new string[] { "Modliszki", "Straszyki", "Patyczaki" });
                suborder.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = true;
                Suplements.Enabled = false;

            }
            else if (Type.SelectedItem.ToString() == "Inne")
            {
                suborder.Items.Clear();
                suborder.Items.AddRange(new string[] { "Inne" });
                suborder.Enabled = true;
                Weight.Enabled = false;
                Length.Enabled = false;
                BodyLength.Enabled = false;
                Suplements.Enabled = false;

            }
        }
    }
}
