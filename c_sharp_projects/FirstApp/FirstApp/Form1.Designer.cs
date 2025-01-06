namespace FirstApp
{
    partial class Form1
    {
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
            numericUpDownRed = new NumericUpDown();
            pictureBoxRed = new PictureBox();
            numericUpDownGreen = new NumericUpDown();
            numericUpDownBlue = new NumericUpDown();
            pictureBoxGreen = new PictureBox();
            pictureBoxBlue = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(29, 39);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(150, 27);
            numericUpDownRed.TabIndex = 0;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // pictureBoxRed
            // 
            pictureBoxRed.Location = new Point(29, 124);
            pictureBoxRed.Name = "pictureBoxRed";
            pictureBoxRed.Size = new Size(150, 141);
            pictureBoxRed.TabIndex = 1;
            pictureBoxRed.TabStop = false;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(281, 39);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(150, 27);
            numericUpDownGreen.TabIndex = 0;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(549, 39);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(150, 27);
            numericUpDownBlue.TabIndex = 0;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // pictureBoxGreen
            // 
            pictureBoxGreen.Location = new Point(281, 124);
            pictureBoxGreen.Name = "pictureBoxGreen";
            pictureBoxGreen.Size = new Size(150, 141);
            pictureBoxGreen.TabIndex = 1;
            pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            pictureBoxBlue.Location = new Point(549, 124);
            pictureBoxBlue.Name = "pictureBoxBlue";
            pictureBoxBlue.Size = new Size(150, 141);
            pictureBoxBlue.TabIndex = 1;
            pictureBoxBlue.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxBlue);
            Controls.Add(pictureBoxGreen);
            Controls.Add(pictureBoxRed);
            Controls.Add(numericUpDownBlue);
            Controls.Add(numericUpDownGreen);
            Controls.Add(numericUpDownRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownRed;
        private PictureBox pictureBoxRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private PictureBox pictureBoxGreen;
        private PictureBox pictureBoxBlue;
    }
}