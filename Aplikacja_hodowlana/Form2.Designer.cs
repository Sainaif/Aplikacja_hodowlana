namespace Aplikacja_hodowlana
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Type = new ComboBox();
            button2 = new Button();
            Activity = new ComboBox();
            textBox2 = new TextBox();
            Animal_name = new TextBox();
            Animal_species = new TextBox();
            textBox5 = new TextBox();
            Enviroment_forms = new ComboBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            Climate = new ComboBox();
            textBox1 = new TextBox();
            textBox8 = new TextBox();
            Add_animal = new Button();
            BodyLength = new ComboBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            Suplements = new ComboBox();
            Length = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            Humidity = new ComboBox();
            Weight = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            suborder = new ComboBox();
            textBox3 = new TextBox();
            MonthlyCost = new TextBox();
            sex = new ComboBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // Type
            // 
            Type.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Type.FormattingEnabled = true;
            Type.Location = new Point(15, 73);
            Type.MaxDropDownItems = 4;
            Type.Name = "Type";
            Type.Size = new Size(115, 24);
            Type.Sorted = true;
            Type.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(12, 588);
            button2.Name = "button2";
            button2.Size = new Size(71, 66);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ReturnToMenu;
            // 
            // Activity
            // 
            Activity.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Activity.FormattingEnabled = true;
            Activity.Location = new Point(350, 73);
            Activity.Name = "Activity";
            Activity.Size = new Size(100, 24);
            Activity.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox2.Location = new Point(12, 38);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(118, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "Rodzina";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Animal_name
            // 
            Animal_name.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Animal_name.Location = new Point(136, 38);
            Animal_name.Name = "Animal_name";
            Animal_name.ReadOnly = true;
            Animal_name.Size = new Size(106, 27);
            Animal_name.TabIndex = 8;
            Animal_name.Text = "Imię";
            Animal_name.TextAlign = HorizontalAlignment.Center;
            Animal_name.TextChanged += textBox3_TextChanged;
            // 
            // Animal_species
            // 
            Animal_species.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Animal_species.Location = new Point(248, 38);
            Animal_species.Name = "Animal_species";
            Animal_species.ReadOnly = true;
            Animal_species.Size = new Size(96, 27);
            Animal_species.TabIndex = 9;
            Animal_species.Text = "Gatunek";
            Animal_species.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox5.Location = new Point(350, 38);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 27);
            textBox5.TabIndex = 10;
            textBox5.Text = "Aktywość";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // Enviroment_forms
            // 
            Enviroment_forms.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Enviroment_forms.FormattingEnabled = true;
            Enviroment_forms.Location = new Point(456, 73);
            Enviroment_forms.Name = "Enviroment_forms";
            Enviroment_forms.Size = new Size(100, 24);
            Enviroment_forms.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox6.Location = new Point(456, 38);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 27);
            textBox6.TabIndex = 12;
            textBox6.Text = "Środowisko";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox7.Location = new Point(562, 38);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(100, 27);
            textBox7.TabIndex = 13;
            textBox7.Text = "Klimat";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // Climate
            // 
            Climate.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Climate.FormattingEnabled = true;
            Climate.Location = new Point(562, 73);
            Climate.Name = "Climate";
            Climate.Size = new Size(122, 24);
            Climate.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox1.Location = new Point(136, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox8.Location = new Point(248, 73);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(96, 27);
            textBox8.TabIndex = 16;
            // 
            // Add_animal
            // 
            Add_animal.AutoSize = true;
            Add_animal.Location = new Point(923, 12);
            Add_animal.Name = "Add_animal";
            Add_animal.Size = new Size(169, 80);
            Add_animal.TabIndex = 17;
            Add_animal.Text = "Dodaj";
            Add_animal.UseVisualStyleBackColor = true;
            Add_animal.Click += Add_animal_Click;
            // 
            // BodyLength
            // 
            BodyLength.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            BodyLength.FormattingEnabled = true;
            BodyLength.Location = new Point(371, 143);
            BodyLength.Name = "BodyLength";
            BodyLength.Size = new Size(137, 24);
            BodyLength.TabIndex = 18;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox9.Location = new Point(12, 304);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(115, 27);
            textBox9.TabIndex = 20;
            textBox9.Text = "Data Urodzenia";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox10.Location = new Point(371, 110);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(137, 27);
            textBox10.TabIndex = 23;
            textBox10.Text = "Rozmiar DC (Pająki)";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox11.Location = new Point(12, 110);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(139, 27);
            textBox11.TabIndex = 24;
            textBox11.Text = "Waga(Gady i Płazy)";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox12.Location = new Point(157, 110);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(106, 27);
            textBox12.TabIndex = 27;
            textBox12.Text = "Długość(Gady)";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox13.Location = new Point(269, 110);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(96, 27);
            textBox13.TabIndex = 28;
            textBox13.Text = "Wilgotność";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox14.Location = new Point(12, 241);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(139, 27);
            textBox14.TabIndex = 29;
            textBox14.Text = "Suplementacja";
            textBox14.TextAlign = HorizontalAlignment.Center;
            // 
            // Suplements
            // 
            Suplements.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Suplements.FormattingEnabled = true;
            Suplements.Location = new Point(37, 274);
            Suplements.Name = "Suplements";
            Suplements.Size = new Size(68, 24);
            Suplements.TabIndex = 30;
            // 
            // Length
            // 
            Length.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Length.Location = new Point(157, 142);
            Length.Name = "Length";
            Length.Size = new Size(106, 27);
            Length.TabIndex = 32;
            // 
            // textBox17
            // 
            textBox17.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox17.Location = new Point(12, 175);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(139, 27);
            textBox17.TabIndex = 33;
            textBox17.Text = "Odmiana";
            textBox17.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            textBox18.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox18.Location = new Point(12, 208);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(222, 27);
            textBox18.TabIndex = 34;
            // 
            // textBox19
            // 
            textBox19.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox19.Location = new Point(690, 38);
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(106, 27);
            textBox19.TabIndex = 35;
            textBox19.Text = "Podrząd";
            textBox19.TextAlign = HorizontalAlignment.Center;
            // 
            // Humidity
            // 
            Humidity.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Humidity.FormattingEnabled = true;
            Humidity.Location = new Point(269, 143);
            Humidity.Name = "Humidity";
            Humidity.Size = new Size(96, 24);
            Humidity.TabIndex = 37;
            // 
            // Weight
            // 
            Weight.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            Weight.Location = new Point(12, 142);
            Weight.Name = "Weight";
            Weight.Size = new Size(139, 27);
            Weight.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 337);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // suborder
            // 
            suborder.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            suborder.FormattingEnabled = true;
            suborder.Location = new Point(690, 73);
            suborder.Name = "suborder";
            suborder.Size = new Size(106, 24);
            suborder.TabIndex = 42;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox3.Location = new Point(12, 366);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 43;
            textBox3.Text = "Miesięczny koszt utrzymania\r\n";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // MonthlyCost
            // 
            MonthlyCost.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            MonthlyCost.Location = new Point(12, 399);
            MonthlyCost.Name = "MonthlyCost";
            MonthlyCost.Size = new Size(115, 27);
            MonthlyCost.TabIndex = 44;
            // 
            // sex
            // 
            sex.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            sex.FormattingEnabled = true;
            sex.Location = new Point(37, 465);
            sex.Name = "sex";
            sex.Size = new Size(68, 24);
            sex.TabIndex = 45;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            textBox4.Location = new Point(9, 432);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(118, 27);
            textBox4.TabIndex = 46;
            textBox4.Text = "Płec";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1104, 666);
            Controls.Add(textBox4);
            Controls.Add(sex);
            Controls.Add(MonthlyCost);
            Controls.Add(textBox3);
            Controls.Add(suborder);
            Controls.Add(dateTimePicker1);
            Controls.Add(Weight);
            Controls.Add(Humidity);
            Controls.Add(textBox19);
            Controls.Add(textBox18);
            Controls.Add(textBox17);
            Controls.Add(Length);
            Controls.Add(Suplements);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(BodyLength);
            Controls.Add(Add_animal);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(Climate);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(Enviroment_forms);
            Controls.Add(textBox5);
            Controls.Add(Animal_species);
            Controls.Add(Animal_name);
            Controls.Add(textBox2);
            Controls.Add(Activity);
            Controls.Add(button2);
            Controls.Add(Type);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox Type;
        private Button button2;
        private ComboBox Activity;
        private TextBox textBox2;
        private TextBox Animal_name;
        private TextBox Animal_species;
        private TextBox textBox5;
        private ComboBox Enviroment_forms;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox Climate;
        private TextBox textBox1;
        private TextBox textBox8;
        private Button Add_animal;
        private ComboBox BodyLength;
        private TextBox textBox9;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private ComboBox Suplements;
        private TextBox Length;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private ComboBox Humidity;
        private TextBox Weight;
        private DateTimePicker dateTimePicker1;
        private ComboBox suborder;
        private TextBox textBox3;
        private TextBox MonthlyCost;
        private ComboBox sex;
        private TextBox textBox4;
    }
}