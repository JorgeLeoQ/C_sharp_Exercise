namespace NetProcessorMonitor_step10_
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
            this.weatherConditionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.plotChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weatherConditionsTextBox
            // 
            this.weatherConditionsTextBox.Location = new System.Drawing.Point(26, 31);
            this.weatherConditionsTextBox.Multiline = true;
            this.weatherConditionsTextBox.Name = "weatherConditionsTextBox";
            this.weatherConditionsTextBox.ReadOnly = true;
            this.weatherConditionsTextBox.Size = new System.Drawing.Size(651, 365);
            this.weatherConditionsTextBox.TabIndex = 0;
            this.weatherConditionsTextBox.TextChanged += new System.EventHandler(this.weatherConditionsTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(531, 417);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(83, 422);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(149, 31);
            this.cityTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(349, 422);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(161, 31);
            this.countryTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(26, 473);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(651, 51);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(26, 530);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(322, 46);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(349, 530);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(328, 46);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // plotChartButton
            // 
            this.plotChartButton.Location = new System.Drawing.Point(27, 582);
            this.plotChartButton.Name = "plotChartButton";
            this.plotChartButton.Size = new System.Drawing.Size(650, 51);
            this.plotChartButton.TabIndex = 10;
            this.plotChartButton.Text = "Plot Chart";
            this.plotChartButton.UseVisualStyleBackColor = true;
            this.plotChartButton.Click += new System.EventHandler(this.plotChartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 645);
            this.Controls.Add(this.plotChartButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherConditionsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weatherConditionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button plotChartButton;
    }
}

