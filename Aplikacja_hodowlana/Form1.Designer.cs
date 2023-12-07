namespace Aplikacja_hodowlana
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnAnimals;
        private Button btnBreedingProjects;
        private Button btnGeneticsCalculator;
        private Button btnSchedule;
        private Button btnFoodSupply;
        private Panel navigationBar;

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
            button1 = new Button();
            lblTitle = new Label();
            txtSearch = new TextBox();
            navigationBar = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(633, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 61);
            button1.TabIndex = 0;
            button1.Text = "Click me";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(221, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 109);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Reptile Buddy";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(403, 156);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(116, 39);
            txtSearch.TabIndex = 2;
            // 
            // navigationBar
            // 
            navigationBar.Dock = DockStyle.Bottom;
            navigationBar.Location = new Point(0, 550);
            navigationBar.Name = "navigationBar";
            navigationBar.Size = new Size(800, 50);
            navigationBar.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(navigationBar);
            Name = "Form1";
            Text = "Breeding Application";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
