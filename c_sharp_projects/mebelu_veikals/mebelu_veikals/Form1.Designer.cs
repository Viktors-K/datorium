namespace mebelu_veikals
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
            labelProductSelect = new Label();
            comboBoxProductSelect = new ComboBox();
            textBoxProductName = new TextBox();
            labelProductName = new Label();
            labelProductPrice = new Label();
            textBoxProductPrice = new TextBox();
            labelProductDesc = new Label();
            textBoxProductDesc = new TextBox();
            labelProductLength = new Label();
            textBoxProductLength = new TextBox();
            labelProductWidth = new Label();
            textBoxProductWidth = new TextBox();
            labelProductHeight = new Label();
            textBoxProductHeight = new TextBox();
            buttonProductAdd = new Button();
            buttonProductRead = new Button();
            buttonProductEdit = new Button();
            buttonProductDelete = new Button();
            SuspendLayout();
            // 
            // labelProductSelect
            // 
            labelProductSelect.AutoSize = true;
            labelProductSelect.Location = new Point(12, 9);
            labelProductSelect.Name = "labelProductSelect";
            labelProductSelect.Size = new Size(73, 15);
            labelProductSelect.TabIndex = 0;
            labelProductSelect.Text = "Izvēlies preci";
            // 
            // comboBoxProductSelect
            // 
            comboBoxProductSelect.FormattingEnabled = true;
            comboBoxProductSelect.Location = new Point(12, 27);
            comboBoxProductSelect.Name = "comboBoxProductSelect";
            comboBoxProductSelect.Size = new Size(306, 23);
            comboBoxProductSelect.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(12, 97);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(150, 23);
            textBoxProductName.TabIndex = 2;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(12, 79);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(70, 15);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Nosaukums";
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new Point(168, 79);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(34, 15);
            labelProductPrice.TabIndex = 0;
            labelProductPrice.Text = "Cena";
            // 
            // textBoxProductPrice
            // 
            textBoxProductPrice.Location = new Point(168, 97);
            textBoxProductPrice.Name = "textBoxProductPrice";
            textBoxProductPrice.Size = new Size(150, 23);
            textBoxProductPrice.TabIndex = 2;
            // 
            // labelProductDesc
            // 
            labelProductDesc.AutoSize = true;
            labelProductDesc.Location = new Point(324, 79);
            labelProductDesc.Name = "labelProductDesc";
            labelProductDesc.Size = new Size(52, 15);
            labelProductDesc.TabIndex = 0;
            labelProductDesc.Text = "Apraksts";
            // 
            // textBoxProductDesc
            // 
            textBoxProductDesc.Location = new Point(324, 97);
            textBoxProductDesc.Name = "textBoxProductDesc";
            textBoxProductDesc.Size = new Size(150, 23);
            textBoxProductDesc.TabIndex = 2;
            // 
            // labelProductLength
            // 
            labelProductLength.AutoSize = true;
            labelProductLength.Location = new Point(12, 123);
            labelProductLength.Name = "labelProductLength";
            labelProductLength.Size = new Size(48, 15);
            labelProductLength.TabIndex = 0;
            labelProductLength.Text = "Garums";
            // 
            // textBoxProductLength
            // 
            textBoxProductLength.Location = new Point(12, 141);
            textBoxProductLength.Name = "textBoxProductLength";
            textBoxProductLength.Size = new Size(150, 23);
            textBoxProductLength.TabIndex = 2;
            // 
            // labelProductWidth
            // 
            labelProductWidth.AutoSize = true;
            labelProductWidth.Location = new Point(168, 123);
            labelProductWidth.Name = "labelProductWidth";
            labelProductWidth.Size = new Size(50, 15);
            labelProductWidth.TabIndex = 0;
            labelProductWidth.Text = "Platums";
            // 
            // textBoxProductWidth
            // 
            textBoxProductWidth.Location = new Point(168, 141);
            textBoxProductWidth.Name = "textBoxProductWidth";
            textBoxProductWidth.Size = new Size(150, 23);
            textBoxProductWidth.TabIndex = 2;
            // 
            // labelProductHeight
            // 
            labelProductHeight.AutoSize = true;
            labelProductHeight.Location = new Point(324, 123);
            labelProductHeight.Name = "labelProductHeight";
            labelProductHeight.Size = new Size(61, 15);
            labelProductHeight.TabIndex = 0;
            labelProductHeight.Text = "Augstums";
            // 
            // textBoxProductHeight
            // 
            textBoxProductHeight.Location = new Point(324, 141);
            textBoxProductHeight.Name = "textBoxProductHeight";
            textBoxProductHeight.Size = new Size(150, 23);
            textBoxProductHeight.TabIndex = 2;
            // 
            // buttonProductAdd
            // 
            buttonProductAdd.Location = new Point(12, 200);
            buttonProductAdd.Name = "buttonProductAdd";
            buttonProductAdd.Size = new Size(150, 23);
            buttonProductAdd.TabIndex = 3;
            buttonProductAdd.Text = "Pievienot";
            buttonProductAdd.UseVisualStyleBackColor = true;
            buttonProductAdd.Click += buttonProductAdd_Click;
            // 
            // buttonProductRead
            // 
            buttonProductRead.Location = new Point(324, 27);
            buttonProductRead.Name = "buttonProductRead";
            buttonProductRead.Size = new Size(150, 23);
            buttonProductRead.TabIndex = 4;
            buttonProductRead.Text = "Atlasīt";
            buttonProductRead.UseVisualStyleBackColor = true;
            buttonProductRead.Click += buttonProductRead_Click;
            // 
            // buttonProductEdit
            // 
            buttonProductEdit.Location = new Point(168, 200);
            buttonProductEdit.Name = "buttonProductEdit";
            buttonProductEdit.Size = new Size(150, 23);
            buttonProductEdit.TabIndex = 3;
            buttonProductEdit.Text = "Rediģēt";
            buttonProductEdit.UseVisualStyleBackColor = true;
            buttonProductEdit.Click += buttonProductEdit_Click;
            // 
            // buttonProductDelete
            // 
            buttonProductDelete.Location = new Point(324, 200);
            buttonProductDelete.Name = "buttonProductDelete";
            buttonProductDelete.Size = new Size(150, 23);
            buttonProductDelete.TabIndex = 4;
            buttonProductDelete.Text = "Dzēst";
            buttonProductDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 239);
            Controls.Add(buttonProductDelete);
            Controls.Add(buttonProductRead);
            Controls.Add(buttonProductEdit);
            Controls.Add(buttonProductAdd);
            Controls.Add(textBoxProductHeight);
            Controls.Add(textBoxProductWidth);
            Controls.Add(textBoxProductLength);
            Controls.Add(textBoxProductDesc);
            Controls.Add(textBoxProductPrice);
            Controls.Add(textBoxProductName);
            Controls.Add(comboBoxProductSelect);
            Controls.Add(labelProductHeight);
            Controls.Add(labelProductWidth);
            Controls.Add(labelProductLength);
            Controls.Add(labelProductDesc);
            Controls.Add(labelProductPrice);
            Controls.Add(labelProductName);
            Controls.Add(labelProductSelect);
            Name = "Form1";
            Text = "Mēbeļu veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProductSelect;
        private ComboBox comboBoxProductSelect;
        private TextBox textBoxProductName;
        private Label labelProductName;
        private Label labelProductPrice;
        private TextBox textBoxProductPrice;
        private Label labelProductDesc;
        private TextBox textBoxProductDesc;
        private Label labelProductLength;
        private TextBox textBoxProductLength;
        private Label labelProductWidth;
        private TextBox textBoxProductWidth;
        private Label labelProductHeight;
        private TextBox textBoxProductHeight;
        private Button buttonProductAdd;
        private Button buttonProductRead;
        private Button buttonProductEdit;
        private Button buttonProductDelete;
    }
}
