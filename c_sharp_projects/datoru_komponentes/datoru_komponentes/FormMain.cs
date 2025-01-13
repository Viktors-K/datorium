namespace datoru_komponentes
{
    public partial class FormMain : Form
    {
        private Komponente komponente;
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Datoru komponentes";
            var types = new List<string>() { "RAM", "CPU", "GPU" };
            comboBoxViewType.DataSource = types;
            comboBoxCompType.DataSource = types;
        }

        private void tabPageView_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCompType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxViewName_DropDownClosed(object sender, EventArgs e)
        {

        }
        private void textBoxCompName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonViewEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewSelect_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxViewType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCompAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(comboBoxCompType.Text))
                {
                    MessageBox.Show("Veids nav izv�l�ts!");
                }
                else if (String.IsNullOrEmpty(textBoxCompName.Text))
                {
                    MessageBox.Show("Nosaukums nav ievad�ts!");
                }
                else if (String.IsNullOrEmpty(textBoxCompPrice.Text))
                {
                    MessageBox.Show("Cena nav ievad�ta!");
                }
                else
                {
                    komponente = new Komponente(
                        veids: comboBoxCompType.SelectedItem.ToString(),
                        modelis: textBoxCompName.Text,
                        cena: Convert.ToDouble(textBoxCompPrice.Text)
                    );
                    MessageBox.Show("Komponente pievienota!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Notikusi k��da!");
            }

        }
    }
    public class Komponente
    {
        public string Veids { get; set; }
        public string Modelis { get; set; }
        public double Cena { get; set; }

        public Komponente(string veids, string modelis, double cena)
        {
            Veids = veids;
            Modelis = modelis;
            Cena = cena;
        }
    }
}
