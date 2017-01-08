namespace compito_quimi_weather_con_client_simulato
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxWeatherInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Countries";
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(98, 36);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountries.TabIndex = 1;
            this.comboBoxCountries.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountries_SelectedIndexChanged);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(98, 63);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 2;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cities";
            // 
            // richTextBoxWeatherInformation
            // 
            this.richTextBoxWeatherInformation.Location = new System.Drawing.Point(12, 90);
            this.richTextBoxWeatherInformation.Name = "richTextBoxWeatherInformation";
            this.richTextBoxWeatherInformation.Size = new System.Drawing.Size(260, 159);
            this.richTextBoxWeatherInformation.TabIndex = 4;
            this.richTextBoxWeatherInformation.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBoxWeatherInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxWeatherInformation;
    }
}

