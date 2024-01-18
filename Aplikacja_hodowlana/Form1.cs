namespace Aplikacja_hodowlana
{

    public partial class Menu : Form
    {
        
        
        public Menu()
        {
            InitializeComponent();
            
        }
        private void exit_Click(object sender, EventArgs e) //Exit button
        {
            Application.Exit();
        }

        private void my_animals_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void add_animal_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           
            this.Hide();
            form2.Show();
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {               
           
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


       
    }
}
