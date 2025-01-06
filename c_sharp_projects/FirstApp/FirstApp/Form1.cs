namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericUpDown1.Value;
            pictureBox1.BackColor = Color.FromArgb(redValue, 0, 0);
        }
    }
}