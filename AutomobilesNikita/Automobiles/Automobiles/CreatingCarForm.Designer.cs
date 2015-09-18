namespace Automobiles
{
    partial class CreatingCarForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Car name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Location = new System.Drawing.Point(12, 58);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.carTypeComboBox.TabIndex = 2;
            this.carTypeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carTypeComboBox_KeyDown);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(48, 85);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(64, 22);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create car";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreatingCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(130, 118);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "CreatingCarForm";
            this.Text = "CreatingCarForm";
            this.Load += new System.EventHandler(this.CreatingCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Button createButton;
    }
}