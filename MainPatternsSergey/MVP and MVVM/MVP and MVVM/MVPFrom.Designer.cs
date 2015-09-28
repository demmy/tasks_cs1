namespace MVP
{
    partial class MvpForm
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
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.CommandComboBoxLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ExecutionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.DisplayMember = "z";
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CommandComboBox.Location = new System.Drawing.Point(12, 156);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(185, 21);
            this.CommandComboBox.TabIndex = 0;
            this.CommandComboBox.SelectedIndexChanged += new System.EventHandler(this.CommandComboBox_SelectedIndexChanged);
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(12, 75);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.FirstNumberTextBox.TabIndex = 1;
            this.FirstNumberTextBox.TextChanged += new System.EventHandler(this.FirstNumberTextBox_TextChanged);
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(12, 118);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.SecondNumberTextBox.TabIndex = 2;
            this.SecondNumberTextBox.TextChanged += new System.EventHandler(this.SecondNumberTextBox_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 193);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(185, 20);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Location = new System.Drawing.Point(12, 59);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.FirstNumberLabel.TabIndex = 4;
            this.FirstNumberLabel.Text = "First Number";
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Location = new System.Drawing.Point(12, 102);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.SecondNumberLabel.TabIndex = 5;
            this.SecondNumberLabel.Text = "Second Number";
            // 
            // CommandComboBoxLabel
            // 
            this.CommandComboBoxLabel.AutoSize = true;
            this.CommandComboBoxLabel.Location = new System.Drawing.Point(12, 140);
            this.CommandComboBoxLabel.Name = "CommandComboBoxLabel";
            this.CommandComboBoxLabel.Size = new System.Drawing.Size(108, 13);
            this.CommandComboBoxLabel.TabIndex = 6;
            this.CommandComboBoxLabel.Text = "Choose the operation";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 180);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result";
            // 
            // ExecutionButton
            // 
            this.ExecutionButton.Location = new System.Drawing.Point(66, 235);
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.Size = new System.Drawing.Size(75, 23);
            this.ExecutionButton.TabIndex = 8;
            this.ExecutionButton.Text = "Execute";
            this.ExecutionButton.UseVisualStyleBackColor = true;
            this.ExecutionButton.Click += new System.EventHandler(this.Execute_Click);
            // 
            // MvpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 292);
            this.Controls.Add(this.ExecutionButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CommandComboBoxLabel);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Controls.Add(this.CommandComboBox);
            this.Name = "MvpForm";
            this.Text = "MVP Example Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.Label CommandComboBoxLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ExecutionButton;
    }
}

