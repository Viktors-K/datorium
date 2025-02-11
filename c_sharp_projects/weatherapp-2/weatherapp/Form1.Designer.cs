namespace weatherapp
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
            maxTemp = new TextBox();
            minTemp = new TextBox();
            humidity = new TextBox();
            windSpeed = new TextBox();
            atmPressure = new TextBox();
            city = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            showBtn = new Button();
            moonPhase = new TextBox();
            label7 = new Label();
            conditionPic = new PictureBox();
            weatherTabs = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            forecastBtn = new Button();
            label8 = new Label();
            forecastCity = new TextBox();
            forecast = new DataGridView();
            buttonSaveCity = new Button();
            ((System.ComponentModel.ISupportInitialize)conditionPic).BeginInit();
            weatherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)forecast).BeginInit();
            SuspendLayout();
            // 
            // maxTemp
            // 
            maxTemp.Location = new Point(144, 16);
            maxTemp.Name = "maxTemp";
            maxTemp.Size = new Size(100, 23);
            maxTemp.TabIndex = 0;
            // 
            // minTemp
            // 
            minTemp.Location = new Point(144, 44);
            minTemp.Name = "minTemp";
            minTemp.Size = new Size(100, 23);
            minTemp.TabIndex = 1;
            // 
            // humidity
            // 
            humidity.Location = new Point(144, 73);
            humidity.Name = "humidity";
            humidity.Size = new Size(100, 23);
            humidity.TabIndex = 2;
            // 
            // windSpeed
            // 
            windSpeed.Location = new Point(144, 102);
            windSpeed.Name = "windSpeed";
            windSpeed.Size = new Size(100, 23);
            windSpeed.TabIndex = 3;
            // 
            // atmPressure
            // 
            atmPressure.Location = new Point(144, 131);
            atmPressure.Name = "atmPressure";
            atmPressure.Size = new Size(100, 23);
            atmPressure.TabIndex = 4;
            // 
            // city
            // 
            city.Location = new Point(321, 131);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 6;
            label1.Text = "Maksimāla temperatūra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 7;
            label2.Text = "Minimāla temperatūra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Mitrums";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 110);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Vēja ātrums";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 10;
            label5.Text = "Atmosfēras spiedens";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 139);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Pilsēta";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(274, 160);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(147, 23);
            showBtn.TabIndex = 12;
            showBtn.Text = "Parādīt prognozi";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // moonPhase
            // 
            moonPhase.Location = new Point(144, 160);
            moonPhase.Name = "moonPhase";
            moonPhase.Size = new Size(100, 23);
            moonPhase.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 168);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 14;
            label7.Text = "Mēness fāze";
            // 
            // conditionPic
            // 
            conditionPic.Location = new Point(274, 15);
            conditionPic.Name = "conditionPic";
            conditionPic.Size = new Size(147, 110);
            conditionPic.TabIndex = 15;
            conditionPic.TabStop = false;
            // 
            // weatherTabs
            // 
            weatherTabs.Controls.Add(tabPage1);
            weatherTabs.Controls.Add(tabPage2);
            weatherTabs.Location = new Point(12, 12);
            weatherTabs.Name = "weatherTabs";
            weatherTabs.SelectedIndex = 0;
            weatherTabs.Size = new Size(833, 311);
            weatherTabs.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(conditionPic);
            tabPage1.Controls.Add(showBtn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(city);
            tabPage1.Controls.Add(maxTemp);
            tabPage1.Controls.Add(moonPhase);
            tabPage1.Controls.Add(minTemp);
            tabPage1.Controls.Add(humidity);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(windSpeed);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(atmPressure);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(825, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonSaveCity);
            tabPage2.Controls.Add(forecastBtn);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(forecastCity);
            tabPage2.Controls.Add(forecast);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(825, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // forecastBtn
            // 
            forecastBtn.Location = new Point(683, 21);
            forecastBtn.Name = "forecastBtn";
            forecastBtn.Size = new Size(136, 23);
            forecastBtn.TabIndex = 3;
            forecastBtn.Text = "Parādīt prognozi";
            forecastBtn.UseVisualStyleBackColor = true;
            forecastBtn.Click += forecastBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(530, 29);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 2;
            label8.Text = "Pilsēta";
            // 
            // forecastCity
            // 
            forecastCity.Location = new Point(577, 21);
            forecastCity.Name = "forecastCity";
            forecastCity.Size = new Size(100, 23);
            forecastCity.TabIndex = 1;
            // 
            // forecast
            // 
            forecast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            forecast.Location = new Point(9, 53);
            forecast.Name = "forecast";
            forecast.Size = new Size(810, 224);
            forecast.TabIndex = 0;
            // 
            // buttonSaveCity
            // 
            buttonSaveCity.Location = new Point(9, 25);
            buttonSaveCity.Name = "buttonSaveCity";
            buttonSaveCity.Size = new Size(115, 23);
            buttonSaveCity.TabIndex = 4;
            buttonSaveCity.Text = "Saglabāt pilsētu";
            buttonSaveCity.UseVisualStyleBackColor = true;
            buttonSaveCity.Click += saveCity_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 343);
            Controls.Add(weatherTabs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)conditionPic).EndInit();
            weatherTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)forecast).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox maxTemp;
        private TextBox minTemp;
        private TextBox humidity;
        private TextBox windSpeed;
        private TextBox atmPressure;
        private TextBox city;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button showBtn;
        private TextBox moonPhase;
        private Label label7;
        private PictureBox conditionPic;
        private TabControl weatherTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView forecast;
        private Button forecastBtn;
        private Label label8;
        private TextBox forecastCity;
        private Button buttonSaveCity;
    }
}
