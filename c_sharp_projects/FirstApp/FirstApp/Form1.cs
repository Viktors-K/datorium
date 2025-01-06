namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericUpDownRed.Value;
            pictureBoxRed.BackColor = Color.FromArgb(redValue, 0, 0);
        }
        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            int blueValue = (int)numericUpDownBlue.Value;
            pictureBoxBlue.BackColor = Color.FromArgb(0, 0, blueValue);
        }
        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            int greenValue = (int)numericUpDownGreen.Value;
            pictureBoxGreen.BackColor = Color.FromArgb(0, greenValue, 0);
        }
    }
}