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
                comboBoxProductSelect.SelectedIndex = 0;
            }
            else
            {
                comboBoxProductSelect.Items.Clear();
                foreach (var item in furnitureManager.GetAllItemsFromTable())
                {
                    comboBoxProductSelect.Items.Add(item.Name);
                }
            }
            comboBoxProductSelect.ResumeLayout();
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            Furniture item = new Furniture(
                name: textBoxProductName.Text,
                price: Convert.ToDouble(textBoxProductPrice.Text),
                description: textBoxProductDesc.Text,
                length: Convert.ToInt32(textBoxProductLength.Text),
                width: Convert.ToInt32(textBoxProductWidth.Text),
                height: Convert.ToInt32(textBoxProductHeight.Text)
            );
            furnitureManager.AddItemToTable(item);
            UpdateCombobox();
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
