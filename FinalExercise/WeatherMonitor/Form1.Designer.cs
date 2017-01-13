namespace WeatherMonitor
{
    partial class WeatherMonitor
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
            this.go = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Enabled = false;
            this.go.Location = new System.Drawing.Point(598, 510);
            this.go.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(64, 44);
            this.go.TabIndex = 0;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(84, 515);
            this.city.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(178, 31);
            this.city.TabIndex = 2;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(376, 515);
            this.country.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(206, 31);
            this.country.TabIndex = 3;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(24, 23);
            this.description.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(634, 471);
            this.description.TabIndex = 4;
            this.description.Text = "Weather description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 521);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
            // 
            // WeatherMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(686, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.go);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WeatherMonitor";
            this.Text = "WeatherMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

