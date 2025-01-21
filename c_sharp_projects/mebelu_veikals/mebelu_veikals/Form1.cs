using System.ComponentModel;
using System.Security;
using System.Windows.Forms;

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

        private void buttonProductRead_Click(object sender, EventArgs e)
        {
            Furniture current_furniture = furnitureManager.GetItemFromTable(comboBoxProductSelect.Text);
            textBoxProductName.Text = current_furniture.Name;
            textBoxProductPrice.Text = Convert.ToString(current_furniture.Price);
            textBoxProductDesc.Text = current_furniture.Description;
            textBoxProductLength.Text = Convert.ToString(current_furniture.Length);
            textBoxProductWidth.Text = Convert.ToString(current_furniture.Width);
            textBoxProductHeight.Text = Convert.ToString(current_furniture.Height);
        }

        private void buttonProductEdit_Click(object sender, EventArgs e)
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
                    furnitureManager.UpdateItemFromTable(comboBoxProductSelect.Text, item);
                    UpdateCombobox();
                    MessageBox.Show("Ieraksts atjaunots.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Notikusi kļūda!");
                }
            }

        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                furnitureManager.RemoveItemFromTable(textBoxProductName.Text);
                UpdateCombobox();
                MessageBox.Show("Ieraksts dzēsts.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda!");
            }
        }

        private void buttonCsvImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialogCsv.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void buttonCsvExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void openFileDialogCsv_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
