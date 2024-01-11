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
    public partial class Form2 : Form
    {
        private DataBase dataBase = new DataBase();
        public Form2()
        {
            InitializeComponent();



        }

        private void AnimalDetails(object sender, EventArgs e)
        {
            Animals newAnimal = new Animals()
            {
                Id = 1,

                ActivityTime = 0,
                Age = 1,
                Group = "Gady",
                Name = "Lusia",
                Species = "Wąż",
            };
            string details = $"Name: {newAnimal.Name} \n Group: {newAnimal.Group} \n Species: {newAnimal.Species} \n Activity time: {newAnimal.ActivityTime} \n Age: {newAnimal.Age} \n Id: {newAnimal.Id}";
         //   textBox1.Text = details;



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
    }
}
