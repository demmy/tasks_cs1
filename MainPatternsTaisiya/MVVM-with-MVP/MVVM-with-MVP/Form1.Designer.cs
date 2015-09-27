namespace MVVM_with_MVP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.secondOperandText = new System.Windows.Forms.TextBox();
            this.firstOperandText = new System.Windows.Forms.TextBox();
            this.operationsComboBox = new System.Windows.Forms.ComboBox();
            this.CalculatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Action:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Second number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First number:";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(121, 234);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(161, 20);
            this.ResultText.TabIndex = 13;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(36, 169);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(246, 23);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // secondOperandText
            // 
            this.secondOperandText.Location = new System.Drawing.Point(121, 60);
            this.secondOperandText.Name = "secondOperandText";
            this.secondOperandText.Size = new System.Drawing.Size(161, 20);
            this.secondOperandText.TabIndex = 11;
            // 
            // firstOperandText
            // 
            this.firstOperandText.Location = new System.Drawing.Point(121, 26);
            this.firstOperandText.Name = "firstOperandText";
            this.firstOperandText.Size = new System.Drawing.Size(161, 20);
            this.firstOperandText.TabIndex = 10;
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.FormattingEnabled = true;
            this.operationsComboBox.Location = new System.Drawing.Point(121, 113);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(161, 21);
            this.operationsComboBox.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(40, 198);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(121, 143);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            //this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.secondOperandText);
            this.Controls.Add(this.firstOperandText);
            this.Controls.Add(this.operationsComboBox);
            this.Name = "Form1";
            this.Text = "MVVM Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox secondOperandText;
        private System.Windows.Forms.TextBox firstOperandText;
        private System.Windows.Forms.ComboBox operationsComboBox;
        private System.Windows.Forms.BindingSource CalculatorBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        //private DevExpress.XtraEditors.SimpleButton simpleButton1;
        //private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}

