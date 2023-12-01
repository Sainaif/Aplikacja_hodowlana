namespace Aplikacja_hodowlana
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.ComboBox comboBoxAnimalType;
        private System.Windows.Forms.Button buttonAddAnimal;

        // ... Other designer code

        private void InitializeComponent()
        {
            // Initialize textBoxAnimalName
            // Initialize comboBoxAnimalType
            // Initialize buttonAddAnimal

            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
        }
        //Everything below this line was generated automatically by Visual Studio
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 721);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
    }
}
