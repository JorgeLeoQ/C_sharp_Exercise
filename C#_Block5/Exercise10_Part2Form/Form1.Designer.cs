namespace Exercise10_Part2Form
{
    partial class HideAndSeek
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
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 160);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // goHereButton
            // 
            this.goHereButton.Location = new System.Drawing.Point(12, 178);
            this.goHereButton.Name = "goHereButton";
            this.goHereButton.Size = new System.Drawing.Size(75, 23);
            this.goHereButton.TabIndex = 1;
            this.goHereButton.Text = "Go here";
            this.goHereButton.UseVisualStyleBackColor = true;
            this.goHereButton.Click += new System.EventHandler(this.goHereButton_Click);
            // 
            // goThroughTheDoorButton
            // 
            this.goThroughTheDoorButton.Location = new System.Drawing.Point(13, 208);
            this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
            this.goThroughTheDoorButton.Size = new System.Drawing.Size(259, 23);
            this.goThroughTheDoorButton.TabIndex = 2;
            this.goThroughTheDoorButton.Text = "Go through the door";
            this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.goThroughTheDoorButton.Click += new System.EventHandler(this.goThroughTheDoorButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(13, 238);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(259, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(12, 267);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(260, 23);
            this.hideButton.TabIndex = 4;
            this.hideButton.Text = "Hide!";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(93, 180);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(179, 21);
            this.exitsComboBox.TabIndex = 5;
            // 
            // HideAndSeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.goThroughTheDoorButton);
            this.Controls.Add(this.goHereButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "HideAndSeek";
            this.Text = "Hide and Seek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button goHereButton;
        private System.Windows.Forms.Button goThroughTheDoorButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.ComboBox exitsComboBox;
    }
}

