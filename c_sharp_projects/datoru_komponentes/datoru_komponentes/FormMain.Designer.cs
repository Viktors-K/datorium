namespace datoru_komponentes
{
    partial class FormMain
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
            tabControlMain = new TabControl();
            tabPageView = new TabPage();
            labelViewPrice = new Label();
            labelViewType = new Label();
            labelViewName = new Label();
            textBoxViewPrice = new TextBox();
            comboBoxViewType = new ComboBox();
            textBoxViewName = new TextBox();
            buttonViewFileSave = new Button();
            buttonViewEdit = new Button();
            buttonViewSelect = new Button();
            comboBoxViewName = new ComboBox();
            tabPageAdd = new TabPage();
            labelCompPrice = new Label();
            labelCompType = new Label();
            labelCompName = new Label();
            textBoxCompPrice = new TextBox();
            comboBoxCompType = new ComboBox();
            textBoxCompName = new TextBox();
            buttonCompAdd = new Button();
            tabControlMain.SuspendLayout();
            tabPageView.SuspendLayout();
            tabPageAdd.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageView);
            tabControlMain.Controls.Add(tabPageAdd);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(476, 321);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageView
            // 
            tabPageView.Controls.Add(labelViewPrice);
            tabPageView.Controls.Add(labelViewType);
            tabPageView.Controls.Add(labelViewName);
            tabPageView.Controls.Add(textBoxViewPrice);
            tabPageView.Controls.Add(comboBoxViewType);
            tabPageView.Controls.Add(textBoxViewName);
            tabPageView.Controls.Add(buttonViewFileSave);
            tabPageView.Controls.Add(buttonViewEdit);
            tabPageView.Controls.Add(buttonViewSelect);
            tabPageView.Controls.Add(comboBoxViewName);
            tabPageView.Location = new Point(4, 24);
            tabPageView.Name = "tabPageView";
            tabPageView.Padding = new Padding(3);
            tabPageView.Size = new Size(468, 293);
            tabPageView.TabIndex = 0;
            tabPageView.Text = "Skatīt komponentes";
            tabPageView.UseVisualStyleBackColor = true;
            tabPageView.Click += tabPageView_Click;
            // 
            // labelViewPrice
            // 
            labelViewPrice.AutoSize = true;
            labelViewPrice.Location = new Point(18, 168);
            labelViewPrice.Name = "labelViewPrice";
            labelViewPrice.Size = new Size(34, 15);
            labelViewPrice.TabIndex = 9;
            labelViewPrice.Text = "Cena";
            // 
            // labelViewType
            // 
            labelViewType.AutoSize = true;
            labelViewType.Location = new Point(18, 80);
            labelViewType.Name = "labelViewType";
            labelViewType.Size = new Size(34, 15);
            labelViewType.TabIndex = 10;
            labelViewType.Text = "Veids";
            // 
            // labelViewName
            // 
            labelViewName.AutoSize = true;
            labelViewName.Location = new Point(18, 124);
            labelViewName.Name = "labelViewName";
            labelViewName.Size = new Size(70, 15);
            labelViewName.TabIndex = 11;
            labelViewName.Text = "Nosaukums";
            // 
            // textBoxViewPrice
            // 
            textBoxViewPrice.Location = new Point(18, 186);
            textBoxViewPrice.Name = "textBoxViewPrice";
            textBoxViewPrice.Size = new Size(179, 23);
            textBoxViewPrice.TabIndex = 8;
            // 
            // comboBoxViewType
            // 
            comboBoxViewType.FormattingEnabled = true;
            comboBoxViewType.Location = new Point(18, 98);
            comboBoxViewType.Name = "comboBoxViewType";
            comboBoxViewType.Size = new Size(179, 23);
            comboBoxViewType.TabIndex = 7;
            // 
            // textBoxViewName
            // 
            textBoxViewName.Location = new Point(18, 142);
            textBoxViewName.Name = "textBoxViewName";
            textBoxViewName.Size = new Size(179, 23);
            textBoxViewName.TabIndex = 6;
            // 
            // buttonViewFileSave
            // 
            buttonViewFileSave.Location = new Point(297, 142);
            buttonViewFileSave.Name = "buttonViewFileSave";
            buttonViewFileSave.Size = new Size(139, 23);
            buttonViewFileSave.TabIndex = 5;
            buttonViewFileSave.Text = "Saglabāt datus datnē";
            buttonViewFileSave.UseVisualStyleBackColor = true;
            buttonViewFileSave.Click += buttonViewEdit_Click;
            // 
            // buttonViewEdit
            // 
            buttonViewEdit.Location = new Point(36, 215);
            buttonViewEdit.Name = "buttonViewEdit";
            buttonViewEdit.Size = new Size(139, 26);
            buttonViewEdit.TabIndex = 5;
            buttonViewEdit.Text = "Pievienot komponenti";
            buttonViewEdit.UseVisualStyleBackColor = true;
            buttonViewEdit.Click += buttonViewEdit_Click;
            // 
            // buttonViewSelect
            // 
            buttonViewSelect.Location = new Point(297, 23);
            buttonViewSelect.Name = "buttonViewSelect";
            buttonViewSelect.Size = new Size(75, 23);
            buttonViewSelect.TabIndex = 1;
            buttonViewSelect.Text = "Apskatīt";
            buttonViewSelect.UseVisualStyleBackColor = true;
            buttonViewSelect.Click += buttonViewSelect_Click;
            // 
            // comboBoxViewName
            // 
            comboBoxViewName.FormattingEnabled = true;
            comboBoxViewName.Location = new Point(62, 23);
            comboBoxViewName.Name = "comboBoxViewName";
            comboBoxViewName.Size = new Size(199, 23);
            comboBoxViewName.TabIndex = 0;
            comboBoxViewName.DropDownClosed += comboBoxViewName_DropDownClosed;
            // 
            // tabPageAdd
            // 
            tabPageAdd.Controls.Add(labelCompPrice);
            tabPageAdd.Controls.Add(labelCompType);
            tabPageAdd.Controls.Add(labelCompName);
            tabPageAdd.Controls.Add(textBoxCompPrice);
            tabPageAdd.Controls.Add(comboBoxCompType);
            tabPageAdd.Controls.Add(textBoxCompName);
            tabPageAdd.Controls.Add(buttonCompAdd);
            tabPageAdd.Location = new Point(4, 24);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(468, 293);
            tabPageAdd.TabIndex = 1;
            tabPageAdd.Text = "Pievienot komponentes";
            tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // labelCompPrice
            // 
            labelCompPrice.AutoSize = true;
            labelCompPrice.Location = new Point(34, 151);
            labelCompPrice.Name = "labelCompPrice";
            labelCompPrice.Size = new Size(34, 15);
            labelCompPrice.TabIndex = 4;
            labelCompPrice.Text = "Cena";
            labelCompPrice.Click += label1_Click;
            // 
            // labelCompType
            // 
            labelCompType.AutoSize = true;
            labelCompType.Location = new Point(34, 63);
            labelCompType.Name = "labelCompType";
            labelCompType.Size = new Size(34, 15);
            labelCompType.TabIndex = 4;
            labelCompType.Text = "Veids";
            labelCompType.Click += label1_Click;
            // 
            // labelCompName
            // 
            labelCompName.AutoSize = true;
            labelCompName.Location = new Point(34, 107);
            labelCompName.Name = "labelCompName";
            labelCompName.Size = new Size(70, 15);
            labelCompName.TabIndex = 4;
            labelCompName.Text = "Nosaukums";
            labelCompName.Click += label1_Click;
            // 
            // textBoxCompPrice
            // 
            textBoxCompPrice.Location = new Point(34, 169);
            textBoxCompPrice.Name = "textBoxCompPrice";
            textBoxCompPrice.Size = new Size(179, 23);
            textBoxCompPrice.TabIndex = 3;
            // 
            // comboBoxCompType
            // 
            comboBoxCompType.FormattingEnabled = true;
            comboBoxCompType.Location = new Point(34, 81);
            comboBoxCompType.Name = "comboBoxCompType";
            comboBoxCompType.Size = new Size(179, 23);
            comboBoxCompType.TabIndex = 2;
            comboBoxCompType.SelectedIndexChanged += comboBoxCompType_SelectedIndexChanged;
            // 
            // textBoxCompName
            // 
            textBoxCompName.Location = new Point(34, 125);
            textBoxCompName.Name = "textBoxCompName";
            textBoxCompName.Size = new Size(179, 23);
            textBoxCompName.TabIndex = 1;
            textBoxCompName.TextChanged += textBoxCompName_TextChanged;
            // 
            // buttonCompAdd
            // 
            buttonCompAdd.Location = new Point(52, 198);
            buttonCompAdd.Name = "buttonCompAdd";
            buttonCompAdd.Size = new Size(139, 26);
            buttonCompAdd.TabIndex = 0;
            buttonCompAdd.Text = "Pievienot komponenti";
            buttonCompAdd.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 345);
            Controls.Add(tabControlMain);
            Name = "FormMain";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPageView.ResumeLayout(false);
            tabPageView.PerformLayout();
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageView;
        private TabPage tabPageAdd;
        private TextBox textBoxCompName;
        private Button buttonCompAdd;
        private Label labelCompName;
        private TextBox textBoxCompPrice;
        private ComboBox comboBoxCompType;
        private Label labelCompType;
        private Label labelCompPrice;
        private ComboBox comboBoxViewName;
        private Button buttonViewSelect;
        private Label labelViewPrice;
        private Label labelViewType;
        private Label labelViewName;
        private TextBox textBoxViewPrice;
        private ComboBox comboBoxViewType;
        private TextBox textBoxViewName;
        private Button buttonViewEdit;
        private Button buttonViewFileSave;
    }
}
