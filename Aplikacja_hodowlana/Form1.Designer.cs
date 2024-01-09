namespace Aplikacja_hodowlana
{
    partial class Menu : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAnimals;
        private Button btnBreedingProjects;
        private Button btnGeneticsCalculator;
        private Button btnSchedule;
        private Button btnFoodSupply;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            my_animals = new Button();
            add_animal = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // my_animals
            // 
            my_animals.BackColor = Color.Transparent;
            my_animals.FlatAppearance.BorderColor = Color.Black;
            my_animals.FlatAppearance.BorderSize = 4;
            my_animals.FlatStyle = FlatStyle.Popup;
            my_animals.Font = new Font("Snap ITC", 15F);
            my_animals.ForeColor = SystemColors.ControlText;
            my_animals.Location = new Point(259, 150);
            my_animals.Name = "my_animals";
            my_animals.Size = new Size(255, 60);
            my_animals.TabIndex = 2;
            my_animals.Text = "Moje zwierzęta";
            my_animals.UseCompatibleTextRendering = true;
            my_animals.UseVisualStyleBackColor = false;
            my_animals.Click += my_animals_Click;
            // 
            // add_animal
            // 
            add_animal.BackColor = Color.Transparent;
            add_animal.FlatAppearance.BorderSize = 4;
            add_animal.FlatStyle = FlatStyle.Popup;
            add_animal.Font = new Font("Snap ITC", 15F);
            add_animal.Location = new Point(259, 216);
            add_animal.Name = "add_animal";
            add_animal.Size = new Size(255, 60);
            add_animal.TabIndex = 3;
            add_animal.Text = "Dodaj zwierzę";
            add_animal.UseVisualStyleBackColor = false;
            add_animal.Click += add_animal_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatAppearance.BorderColor = Color.Black;
            exit.FlatAppearance.BorderSize = 4;
            exit.FlatStyle = FlatStyle.Popup;
            exit.Font = new Font("Snap ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(259, 282);
            exit.Name = "exit";
            exit.Size = new Size(255, 60);
            exit.TabIndex = 4;
            exit.Text = "Wyjdź z programu";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PaleGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 613);
            Controls.Add(exit);
            Controls.Add(add_animal);
            Controls.Add(my_animals);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Breeding Application";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private Button add_animal;
        private Button exit;
        public Button my_animals;
    }
}
