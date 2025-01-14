using System.ComponentModel;

namespace mebelu_veikals
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;
        public Form1()
        {
            InitializeComponent();
            furnitureManager = new FurnitureManager("Data Source=furniture.db");
            UpdateCombobox();
        }
        public void UpdateCombobox()
        {
            comboBoxProductSelect.SuspendLayout();
            if (furnitureManager.GetAllItemsFromTable().Count < 1)
            {
                comboBoxProductSelect.Items.Add("Nav mēbeļu pievienotu.");
            }
            else
            {
                comboBoxProductSelect.Items.Clear();
                foreach (var item in furnitureManager.GetAllItemsFromTable())
                {
                    comboBoxProductSelect.Items.Add(item.Name);
                }
            }
            comboBoxProductSelect.SelectedIndex = 0;
            comboBoxProductSelect.ResumeLayout();
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text))
            {
                MessageBox.Show("Nav ievadīts nosaukums!");
            }
            else if (string.IsNullOrEmpty(textBoxProductPrice.Text))
            {
                MessageBox.Show("Nav ievadīta cena!");
            }
            else if (string.IsNullOrEmpty(textBoxProductDesc.Text))
            {
                MessageBox.Show("Nav ievadīts apraksts!");
            }
            else if (string.IsNullOrEmpty(textBoxProductLength.Text))
            {
                MessageBox.Show("Nav ievadīts garums!");
            }
            else if (string.IsNullOrEmpty(textBoxProductWidth.Text))
            {
                MessageBox.Show("Nav ievadīts platums!");
            }
            else if (string.IsNullOrEmpty(textBoxProductHeight.Text))
            {
                MessageBox.Show("Nav ievadīts augstums!");
            }
            else
            {
                Furniture item = new Furniture(
                    name: textBoxProductName.Text,
                    price: Convert.ToDouble(textBoxProductPrice.Text),
                    description: textBoxProductDesc.Text,
                    length: Convert.ToInt32(textBoxProductLength.Text),
                    width: Convert.ToInt32(textBoxProductWidth.Text),
                    height: Convert.ToInt32(textBoxProductHeight.Text)
                );
                try
                {
                    furnitureManager.AddItemToTable(item);
                    UpdateCombobox();
                    MessageBox.Show("Ieraksts pievienots datubāzei.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Notikusi kļūda!");
                }
            }
        }
    }
    public class Furniture
    {
        public string Name;
        public string Description;
        public double Price;
        public int Length;
        public int Width;
        public int Height;
        public Furniture(string name, string description, double price, int length, int width, int height)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
    }
}
