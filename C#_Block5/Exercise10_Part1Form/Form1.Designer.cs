namespace Exercise10_Part1Form
{
    partial class ExploreTheHouseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.goHereButton = new System.Windows.Forms.Button();
            this.goThroughTheDoorButton = new System.Windows.Forms.Button();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 185);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // goHereButton
            // 
            this.goHereButton.Location = new System.Drawing.Point(12, 204);
            this.goHereButton.Name = "goHereButton";
            this.goHereButton.Size = new System.Drawing.Size(75, 23);
            this.goHereButton.TabIndex = 1;
            this.goHereButton.Text = "Go here";
            this.goHereButton.UseVisualStyleBackColor = true;
            this.goHereButton.Click += new System.EventHandler(this.goHereButton_Click);
            // 
            // goThroughTheDoorButton
            // 
            this.goThroughTheDoorButton.Location = new System.Drawing.Point(12, 233);
            this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
            this.goThroughTheDoorButton.Size = new System.Drawing.Size(260, 23);
            this.goThroughTheDoorButton.TabIndex = 2;
            this.goThroughTheDoorButton.Text = "Go through the door";
            this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.goThroughTheDoorButton.Click += new System.EventHandler(this.goThroughTheDoorButton_Click);
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(93, 206);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(179, 21);
            this.exitsComboBox.TabIndex = 3;
            // 
            // ExploreTheHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.goThroughTheDoorButton);
            this.Controls.Add(this.goHereButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "ExploreTheHouseForm";
            this.Text = "Explore the House";
            this.Load += new System.EventHandler(this.ExploreTheHouseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button goHereButton;
        private System.Windows.Forms.Button goThroughTheDoorButton;
        private System.Windows.Forms.ComboBox exitsComboBox;
    }
}

