namespace FirstApp
{
    public partial class Form1 : Form
    {
        private int redValue = 0;
        private int greenValue = 0;
        private int blueValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            redValue = (int)numericUpDownRed.Value;
            pictureBoxRed.BackColor = Color.FromArgb(redValue, 0,0);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }
        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            blueValue = (int)numericUpDownBlue.Value;
            pictureBoxBlue.BackColor = Color.FromArgb(0, 0, blueValue);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }
        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            greenValue = (int)numericUpDownGreen.Value;
            pictureBoxGreen.BackColor = Color.FromArgb(0, greenValue, 0);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }
    }
}