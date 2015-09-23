namespace Automobiles
{
    partial class RidingCarForm
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
            this.carStateGroupBox = new System.Windows.Forms.GroupBox();
            this.lightsLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectCarButton = new System.Windows.Forms.Button();
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.accleratorPowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.acceleratorLabel = new System.Windows.Forms.Label();
            this.brakesLabel = new System.Windows.Forms.Label();
            this.brakesPowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.brakesButton = new System.Windows.Forms.Button();
            this.rotateWheelToRIghtLabel = new System.Windows.Forms.Label();
            this.rotationToRightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.wheelToRightButton = new System.Windows.Forms.Button();
            this.rotateWheelToLeftLabel = new System.Windows.Forms.Label();
            this.rotationToLeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.wheelToLeftButton = new System.Windows.Forms.Button();
            this.lightsButton = new System.Windows.Forms.Button();
            this.rideButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.carStateGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accleratorPowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakesPowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationToRightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationToLeftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // carStateGroupBox
            // 
            this.carStateGroupBox.Controls.Add(this.lightsLabel);
            this.carStateGroupBox.Controls.Add(this.directionLabel);
            this.carStateGroupBox.Controls.Add(this.fuelLabel);
            this.carStateGroupBox.Controls.Add(this.speedLabel);
            this.carStateGroupBox.Controls.Add(this.nameLabel);
            this.carStateGroupBox.Location = new System.Drawing.Point(186, 12);
            this.carStateGroupBox.Name = "carStateGroupBox";
            this.carStateGroupBox.Size = new System.Drawing.Size(213, 90);
            this.carStateGroupBox.TabIndex = 0;
            this.carStateGroupBox.TabStop = false;
            this.carStateGroupBox.Text = "Car state";
            // 
            // lightsLabel
            // 
            this.lightsLabel.AutoSize = true;
            this.lightsLabel.Location = new System.Drawing.Point(6, 68);
            this.lightsLabel.Name = "lightsLabel";
            this.lightsLabel.Size = new System.Drawing.Size(38, 13);
            this.lightsLabel.TabIndex = 4;
            this.lightsLabel.Text = "Lights:";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(6, 55);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(52, 13);
            this.directionLabel.TabIndex = 3;
            this.directionLabel.Text = "Direction:";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new System.Drawing.Point(6, 42);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(30, 13);
            this.fuelLabel.TabIndex = 2;
            this.fuelLabel.Text = "Fuel:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 29);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Speed:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectCarButton);
            this.groupBox1.Controls.Add(this.carsListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // selectCarButton
            // 
            this.selectCarButton.Location = new System.Drawing.Point(7, 172);
            this.selectCarButton.Name = "selectCarButton";
            this.selectCarButton.Size = new System.Drawing.Size(139, 23);
            this.selectCarButton.TabIndex = 1;
            this.selectCarButton.Text = "Select the car";
            this.selectCarButton.UseVisualStyleBackColor = true;
            this.selectCarButton.Click += new System.EventHandler(this.selectCarButton_Click);
            // 
            // carsListBox
            // 
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.Location = new System.Drawing.Point(6, 16);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.Size = new System.Drawing.Size(140, 147);
            this.carsListBox.TabIndex = 0;
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(186, 152);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(104, 23);
            this.accelerateButton.TabIndex = 2;
            this.accelerateButton.Text = "Press accelerator";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // accleratorPowerNumericUpDown
            // 
            this.accleratorPowerNumericUpDown.Location = new System.Drawing.Point(186, 126);
            this.accleratorPowerNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.accleratorPowerNumericUpDown.Name = "accleratorPowerNumericUpDown";
            this.accleratorPowerNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.accleratorPowerNumericUpDown.TabIndex = 3;
            // 
            // acceleratorLabel
            // 
            this.acceleratorLabel.AutoSize = true;
            this.acceleratorLabel.Location = new System.Drawing.Point(183, 110);
            this.acceleratorLabel.Name = "acceleratorLabel";
            this.acceleratorLabel.Size = new System.Drawing.Size(93, 13);
            this.acceleratorLabel.TabIndex = 4;
            this.acceleratorLabel.Text = "Accelerator power";
            // 
            // brakesLabel
            // 
            this.brakesLabel.AutoSize = true;
            this.brakesLabel.Location = new System.Drawing.Point(293, 110);
            this.brakesLabel.Name = "brakesLabel";
            this.brakesLabel.Size = new System.Drawing.Size(72, 13);
            this.brakesLabel.TabIndex = 7;
            this.brakesLabel.Text = "Brakes power";
            // 
            // brakesPowerNumericUpDown
            // 
            this.brakesPowerNumericUpDown.Location = new System.Drawing.Point(296, 126);
            this.brakesPowerNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.brakesPowerNumericUpDown.Name = "brakesPowerNumericUpDown";
            this.brakesPowerNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.brakesPowerNumericUpDown.TabIndex = 6;
            // 
            // brakesButton
            // 
            this.brakesButton.Location = new System.Drawing.Point(296, 152);
            this.brakesButton.Name = "brakesButton";
            this.brakesButton.Size = new System.Drawing.Size(104, 23);
            this.brakesButton.TabIndex = 5;
            this.brakesButton.Text = "Press brakes";
            this.brakesButton.UseVisualStyleBackColor = true;
            this.brakesButton.Click += new System.EventHandler(this.brakesButton_Click);
            // 
            // rotateWheelToRIghtLabel
            // 
            this.rotateWheelToRIghtLabel.AutoSize = true;
            this.rotateWheelToRIghtLabel.Location = new System.Drawing.Point(293, 181);
            this.rotateWheelToRIghtLabel.Name = "rotateWheelToRIghtLabel";
            this.rotateWheelToRIghtLabel.Size = new System.Drawing.Size(108, 13);
            this.rotateWheelToRIghtLabel.TabIndex = 13;
            this.rotateWheelToRIghtLabel.Text = "Rotate angles to right";
            // 
            // rotationToRightNumericUpDown
            // 
            this.rotationToRightNumericUpDown.Location = new System.Drawing.Point(296, 197);
            this.rotationToRightNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.rotationToRightNumericUpDown.Name = "rotationToRightNumericUpDown";
            this.rotationToRightNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.rotationToRightNumericUpDown.TabIndex = 12;
            // 
            // wheelToRightButton
            // 
            this.wheelToRightButton.Location = new System.Drawing.Point(296, 223);
            this.wheelToRightButton.Name = "wheelToRightButton";
            this.wheelToRightButton.Size = new System.Drawing.Size(104, 23);
            this.wheelToRightButton.TabIndex = 11;
            this.wheelToRightButton.Text = "Rotate wheel";
            this.wheelToRightButton.UseVisualStyleBackColor = true;
            this.wheelToRightButton.Click += new System.EventHandler(this.wheelToRightButton_Click);
            // 
            // rotateWheelToLeftLabel
            // 
            this.rotateWheelToLeftLabel.AutoSize = true;
            this.rotateWheelToLeftLabel.Location = new System.Drawing.Point(183, 181);
            this.rotateWheelToLeftLabel.Name = "rotateWheelToLeftLabel";
            this.rotateWheelToLeftLabel.Size = new System.Drawing.Size(102, 13);
            this.rotateWheelToLeftLabel.TabIndex = 10;
            this.rotateWheelToLeftLabel.Text = "Rotate angles to left";
            // 
            // rotationToLeftNumericUpDown
            // 
            this.rotationToLeftNumericUpDown.Location = new System.Drawing.Point(186, 197);
            this.rotationToLeftNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.rotationToLeftNumericUpDown.Name = "rotationToLeftNumericUpDown";
            this.rotationToLeftNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.rotationToLeftNumericUpDown.TabIndex = 9;
            // 
            // wheelToLeftButton
            // 
            this.wheelToLeftButton.Location = new System.Drawing.Point(186, 223);
            this.wheelToLeftButton.Name = "wheelToLeftButton";
            this.wheelToLeftButton.Size = new System.Drawing.Size(104, 23);
            this.wheelToLeftButton.TabIndex = 8;
            this.wheelToLeftButton.Text = "Rotate wheel";
            this.wheelToLeftButton.UseVisualStyleBackColor = true;
            this.wheelToLeftButton.Click += new System.EventHandler(this.wheelToLeftButton_Click);
            // 
            // lightsButton
            // 
            this.lightsButton.Location = new System.Drawing.Point(186, 252);
            this.lightsButton.Name = "lightsButton";
            this.lightsButton.Size = new System.Drawing.Size(104, 23);
            this.lightsButton.TabIndex = 14;
            this.lightsButton.Text = "Change lights";
            this.lightsButton.UseVisualStyleBackColor = true;
            this.lightsButton.Click += new System.EventHandler(this.lightsButton_Click);
            // 
            // rideButton
            // 
            this.rideButton.Location = new System.Drawing.Point(296, 252);
            this.rideButton.Name = "rideButton";
            this.rideButton.Size = new System.Drawing.Size(103, 23);
            this.rideButton.TabIndex = 15;
            this.rideButton.Text = "Start RIDE!";
            this.rideButton.UseVisualStyleBackColor = true;
            this.rideButton.Click += new System.EventHandler(this.rideButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(12, 238);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 37);
            this.leaveButton.TabIndex = 16;
            this.leaveButton.Text = "Stop car and leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // RidingCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 287);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.rideButton);
            this.Controls.Add(this.lightsButton);
            this.Controls.Add(this.rotateWheelToRIghtLabel);
            this.Controls.Add(this.rotationToRightNumericUpDown);
            this.Controls.Add(this.wheelToRightButton);
            this.Controls.Add(this.rotateWheelToLeftLabel);
            this.Controls.Add(this.rotationToLeftNumericUpDown);
            this.Controls.Add(this.wheelToLeftButton);
            this.Controls.Add(this.brakesLabel);
            this.Controls.Add(this.brakesPowerNumericUpDown);
            this.Controls.Add(this.brakesButton);
            this.Controls.Add(this.acceleratorLabel);
            this.Controls.Add(this.accleratorPowerNumericUpDown);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carStateGroupBox);
            this.Name = "RidingCarForm";
            this.Text = "RidingCarForm";
            this.Load += new System.EventHandler(this.RidingCarForm_Load);
            this.carStateGroupBox.ResumeLayout(false);
            this.carStateGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accleratorPowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakesPowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationToRightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationToLeftNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox carStateGroupBox;
        private System.Windows.Forms.Label lightsLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectCarButton;
        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.NumericUpDown accleratorPowerNumericUpDown;
        private System.Windows.Forms.Label acceleratorLabel;
        private System.Windows.Forms.Label brakesLabel;
        private System.Windows.Forms.NumericUpDown brakesPowerNumericUpDown;
        private System.Windows.Forms.Button brakesButton;
        private System.Windows.Forms.Label rotateWheelToRIghtLabel;
        private System.Windows.Forms.NumericUpDown rotationToRightNumericUpDown;
        private System.Windows.Forms.Button wheelToRightButton;
        private System.Windows.Forms.Label rotateWheelToLeftLabel;
        private System.Windows.Forms.NumericUpDown rotationToLeftNumericUpDown;
        private System.Windows.Forms.Button wheelToLeftButton;
        private System.Windows.Forms.Button lightsButton;
        private System.Windows.Forms.Button rideButton;
        private System.Windows.Forms.Button leaveButton;
    }
}