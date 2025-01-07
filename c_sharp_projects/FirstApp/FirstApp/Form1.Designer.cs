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
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            buttonRandomRed = new Button();
            buttonRandomGreen = new Button();
            buttonRandomBlue = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(25, 29);
            numericUpDownRed.Margin = new Padding(3, 2, 3, 2);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(131, 23);
            numericUpDownRed.TabIndex = 0;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // pictureBoxRed
            // 
            pictureBoxRed.Location = new Point(25, 93);
            pictureBoxRed.Margin = new Padding(3, 2, 3, 2);
            pictureBoxRed.Name = "pictureBoxRed";
            pictureBoxRed.Size = new Size(131, 106);
            pictureBoxRed.TabIndex = 1;
            pictureBoxRed.TabStop = false;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(246, 29);
            numericUpDownGreen.Margin = new Padding(3, 2, 3, 2);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(131, 23);
            numericUpDownGreen.TabIndex = 0;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(480, 29);
            numericUpDownBlue.Margin = new Padding(3, 2, 3, 2);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(131, 23);
            numericUpDownBlue.TabIndex = 0;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // pictureBoxGreen
            // 
            pictureBoxGreen.Location = new Point(246, 93);
            pictureBoxGreen.Margin = new Padding(3, 2, 3, 2);
            pictureBoxGreen.Name = "pictureBoxGreen";
            pictureBoxGreen.Size = new Size(131, 106);
            pictureBoxGreen.TabIndex = 1;
            pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            pictureBoxBlue.Location = new Point(480, 93);
            pictureBoxBlue.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBlue.Name = "pictureBoxBlue";
            pictureBoxBlue.Size = new Size(131, 106);
            pictureBoxBlue.TabIndex = 1;
            pictureBoxBlue.TabStop = false;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(39, 204);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 2;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(260, 204);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(104, 45);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(494, 204);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 2;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // buttonRandomRed
            // 
            buttonRandomRed.BackColor = Color.Red;
            buttonRandomRed.FlatAppearance.BorderColor = Color.Red;
            buttonRandomRed.FlatAppearance.BorderSize = 0;
            buttonRandomRed.ForeColor = SystemColors.ControlText;
            buttonRandomRed.Location = new Point(52, 242);
            buttonRandomRed.Name = "buttonRandomRed";
            buttonRandomRed.Size = new Size(75, 23);
            buttonRandomRed.TabIndex = 3;
            buttonRandomRed.Text = "Randomize";
            buttonRandomRed.UseVisualStyleBackColor = false;
            buttonRandomRed.Click += buttonRandomRed_Click;
            // 
            // buttonRandomGreen
            // 
            buttonRandomGreen.BackColor = Color.Lime;
            buttonRandomGreen.Location = new Point(273, 242);
            buttonRandomGreen.Name = "buttonRandomGreen";
            buttonRandomGreen.Size = new Size(75, 23);
            buttonRandomGreen.TabIndex = 3;
            buttonRandomGreen.Text = "Randomize";
            buttonRandomGreen.UseVisualStyleBackColor = false;
            buttonRandomGreen.Click += buttonRandomGreen_Click;
            // 
            // buttonRandomBlue
            // 
            buttonRandomBlue.BackColor = Color.Blue;
            buttonRandomBlue.ForeColor = SystemColors.AppWorkspace;
            buttonRandomBlue.Location = new Point(508, 242);
            buttonRandomBlue.Name = "buttonRandomBlue";
            buttonRandomBlue.Size = new Size(75, 23);
            buttonRandomBlue.TabIndex = 3;
            buttonRandomBlue.Text = "Randomize";
            buttonRandomBlue.UseVisualStyleBackColor = false;
            buttonRandomBlue.Click += buttonRandomBlue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonRandomBlue);
            Controls.Add(buttonRandomGreen);
            Controls.Add(buttonRandomRed);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(pictureBoxBlue);
            Controls.Add(pictureBoxGreen);
            Controls.Add(pictureBoxRed);
            Controls.Add(numericUpDownBlue);
            Controls.Add(numericUpDownGreen);
            Controls.Add(numericUpDownRed);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownRed;
        private PictureBox pictureBoxRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private PictureBox pictureBoxGreen;
        private PictureBox pictureBoxBlue;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Button buttonRandomRed;
        private Button buttonRandomGreen;
        private Button buttonRandomBlue;
    }
}