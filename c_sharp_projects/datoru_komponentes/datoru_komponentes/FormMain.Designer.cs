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
            tabControlMain.Location = new Point(14, 16);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(544, 428);
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
            tabPageView.Location = new Point(4, 29);
            tabPageView.Margin = new Padding(3, 4, 3, 4);
            tabPageView.Name = "tabPageView";
            tabPageView.Padding = new Padding(3, 4, 3, 4);
            tabPageView.Size = new Size(536, 395);
            tabPageView.TabIndex = 0;
            tabPageView.Text = "Skatīt komponentes";
            tabPageView.UseVisualStyleBackColor = true;
            tabPageView.Click += tabPageView_Click;
            // 
            // labelViewPrice
            // 
            labelViewPrice.AutoSize = true;
            labelViewPrice.Location = new Point(21, 224);
            labelViewPrice.Name = "labelViewPrice";
            labelViewPrice.Size = new Size(42, 20);
            labelViewPrice.TabIndex = 9;
            labelViewPrice.Text = "Cena";
            // 
            // labelViewType
            // 
            labelViewType.AutoSize = true;
            labelViewType.Location = new Point(21, 107);
            labelViewType.Name = "labelViewType";
            labelViewType.Size = new Size(44, 20);
            labelViewType.TabIndex = 10;
            labelViewType.Text = "Veids";
            // 
            // labelViewName
            // 
            labelViewName.AutoSize = true;
            labelViewName.Location = new Point(21, 165);
            labelViewName.Name = "labelViewName";
            labelViewName.Size = new Size(85, 20);
            labelViewName.TabIndex = 11;
            labelViewName.Text = "Nosaukums";
            // 
            // textBoxViewPrice
            // 
            textBoxViewPrice.Location = new Point(21, 248);
            textBoxViewPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxViewPrice.Name = "textBoxViewPrice";
            textBoxViewPrice.Size = new Size(204, 27);
            textBoxViewPrice.TabIndex = 8;
            // 
            // comboBoxViewType
            // 
            comboBoxViewType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxViewType.FormattingEnabled = true;
            comboBoxViewType.Location = new Point(21, 131);
            comboBoxViewType.Margin = new Padding(3, 4, 3, 4);
            comboBoxViewType.Name = "comboBoxViewType";
            comboBoxViewType.Size = new Size(204, 28);
            comboBoxViewType.TabIndex = 7;
            comboBoxViewType.SelectedIndexChanged += comboBoxViewType_SelectedIndexChanged;
            // 
            // textBoxViewName
            // 
            textBoxViewName.Location = new Point(21, 189);
            textBoxViewName.Margin = new Padding(3, 4, 3, 4);
            textBoxViewName.Name = "textBoxViewName";
            textBoxViewName.Size = new Size(204, 27);
            textBoxViewName.TabIndex = 6;
            // 
            // buttonViewFileSave
            // 
            buttonViewFileSave.Location = new Point(339, 189);
            buttonViewFileSave.Margin = new Padding(3, 4, 3, 4);
            buttonViewFileSave.Name = "buttonViewFileSave";
            buttonViewFileSave.Size = new Size(159, 31);
            buttonViewFileSave.TabIndex = 5;
            buttonViewFileSave.Text = "Saglabāt datus datnē";
            buttonViewFileSave.UseVisualStyleBackColor = true;
            buttonViewFileSave.Click += buttonViewEdit_Click;
            // 
            // buttonViewEdit
            // 
            buttonViewEdit.Location = new Point(41, 287);
            buttonViewEdit.Margin = new Padding(3, 4, 3, 4);
            buttonViewEdit.Name = "buttonViewEdit";
            buttonViewEdit.Size = new Size(159, 35);
            buttonViewEdit.TabIndex = 5;
            buttonViewEdit.Text = "Rediģēt";
            buttonViewEdit.UseVisualStyleBackColor = true;
            buttonViewEdit.Click += buttonViewEdit_Click;
            // 
            // buttonViewSelect
            // 
            buttonViewSelect.Location = new Point(339, 31);
            buttonViewSelect.Margin = new Padding(3, 4, 3, 4);
            buttonViewSelect.Name = "buttonViewSelect";
            buttonViewSelect.Size = new Size(86, 31);
            buttonViewSelect.TabIndex = 1;
            buttonViewSelect.Text = "Apskatīt";
            buttonViewSelect.UseVisualStyleBackColor = true;
            buttonViewSelect.Click += buttonViewSelect_Click;
            // 
            // comboBoxViewName
            // 
            comboBoxViewName.FormattingEnabled = true;
            comboBoxViewName.Location = new Point(71, 31);
            comboBoxViewName.Margin = new Padding(3, 4, 3, 4);
            comboBoxViewName.Name = "comboBoxViewName";
            comboBoxViewName.Size = new Size(227, 28);
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
            tabPageAdd.Location = new Point(4, 29);
            tabPageAdd.Margin = new Padding(3, 4, 3, 4);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3, 4, 3, 4);
            tabPageAdd.Size = new Size(536, 395);
            tabPageAdd.TabIndex = 1;
            tabPageAdd.Text = "Pievienot komponentes";
            tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // labelCompPrice
            // 
            labelCompPrice.AutoSize = true;
            labelCompPrice.Location = new Point(39, 201);
            labelCompPrice.Name = "labelCompPrice";
            labelCompPrice.Size = new Size(42, 20);
            labelCompPrice.TabIndex = 4;
            labelCompPrice.Text = "Cena";
            labelCompPrice.Click += label1_Click;
            // 
            // labelCompType
            // 
            labelCompType.AutoSize = true;
            labelCompType.Location = new Point(39, 84);
            labelCompType.Name = "labelCompType";
            labelCompType.Size = new Size(44, 20);
            labelCompType.TabIndex = 4;
            labelCompType.Text = "Veids";
            labelCompType.Click += label1_Click;
            // 
            // labelCompName
            // 
            labelCompName.AutoSize = true;
            labelCompName.Location = new Point(39, 143);
            labelCompName.Name = "labelCompName";
            labelCompName.Size = new Size(85, 20);
            labelCompName.TabIndex = 4;
            labelCompName.Text = "Nosaukums";
            labelCompName.Click += label1_Click;
            // 
            // textBoxCompPrice
            // 
            textBoxCompPrice.Location = new Point(39, 225);
            textBoxCompPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxCompPrice.Name = "textBoxCompPrice";
            textBoxCompPrice.Size = new Size(204, 27);
            textBoxCompPrice.TabIndex = 3;
            // 
            // comboBoxCompType
            // 
            comboBoxCompType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCompType.FormattingEnabled = true;
            comboBoxCompType.Location = new Point(39, 108);
            comboBoxCompType.Margin = new Padding(3, 4, 3, 4);
            comboBoxCompType.Name = "comboBoxCompType";
            comboBoxCompType.Size = new Size(204, 28);
            comboBoxCompType.TabIndex = 2;
            comboBoxCompType.SelectedIndexChanged += comboBoxCompType_SelectedIndexChanged;
            // 
            // textBoxCompName
            // 
            textBoxCompName.Location = new Point(39, 167);
            textBoxCompName.Margin = new Padding(3, 4, 3, 4);
            textBoxCompName.Name = "textBoxCompName";
            textBoxCompName.Size = new Size(204, 27);
            textBoxCompName.TabIndex = 1;
            textBoxCompName.TextChanged += textBoxCompName_TextChanged;
            // 
            // buttonCompAdd
            // 
            buttonCompAdd.Location = new Point(59, 264);
            buttonCompAdd.Margin = new Padding(3, 4, 3, 4);
            buttonCompAdd.Name = "buttonCompAdd";
            buttonCompAdd.Size = new Size(159, 35);
            buttonCompAdd.TabIndex = 0;
            buttonCompAdd.Text = "Pievienot komponenti";
            buttonCompAdd.UseVisualStyleBackColor = true;
            buttonCompAdd.Click += buttonCompAdd_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 460);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 4, 3, 4);
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
