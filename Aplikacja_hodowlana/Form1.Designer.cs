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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.ForestGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(328, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = "Menu";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Snap ITC", 15F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(259, 150);
            button1.Name = "button1";
            button1.Size = new Size(255, 60);
            button1.TabIndex = 2;
            button1.Text = "Moje zwierzęta";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Snap ITC", 15F);
            button2.Location = new Point(259, 216);
            button2.Name = "button2";
            button2.Size = new Size(255, 60);
            button2.TabIndex = 3;
            button2.Text = "Dodaj zwierzę";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Snap ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(259, 282);
            button3.Name = "button3";
            button3.Size = new Size(255, 60);
            button3.TabIndex = 4;
            button3.Text = "Wyjdź z programu";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(660, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 61);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 613);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Breeding Application";
            Load += Form1_Load;
            Click += button4_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        public Button button1;
    }
}
