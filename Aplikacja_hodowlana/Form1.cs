using Aplikacja_hodowlana;

public partial class Form1 : Form
{
    private DataBase database;

    public Form1()
    {
        InitializeComponent();
        database = DataBase.LoadFromJsonFile();
    }

    // Replace animal with reptile, amphibian, arthropod, food, etc.
    // Same for the other buttons
    // idk what the fuck is that, chatgpt generated this
    private void buttonAddAnimal_Click(object sender, EventArgs e)
    {
        string animalName = textBoxReptilesName.Text;
        string animalType = comboBoxAnimalType.SelectedItem.ToString();

        // Example for adding an Animal. Adjust based on your actual data model.
        Animal newAnimal = new Animal
        {
            Name = animalName,
            Type = animalType,
            CustomAttributes = new Dictionary<string, object>() // Populate as needed
        };

        database.Animals.Add(newAnimal);

        // Optionally clear the input fields after adding
        textBoxAnimalName.Clear();
        comboBoxAnimalType.SelectedIndex = -1;

        // Save changes to the JSON file
        database.SaveToJsonFile();
    }
}
