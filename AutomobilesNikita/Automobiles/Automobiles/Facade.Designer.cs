namespace Automobiles
{
    partial class Facade
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
            this.createButton = new System.Windows.Forms.Button();
            this.rideButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(55, 46);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(85, 22);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create car";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // rideButton
            // 
            this.rideButton.Location = new System.Drawing.Point(55, 74);
            this.rideButton.Name = "rideButton";
            this.rideButton.Size = new System.Drawing.Size(85, 23);
            this.rideButton.TabIndex = 1;
            this.rideButton.Text = "Ride a car";
            this.rideButton.UseVisualStyleBackColor = true;
            this.rideButton.Click += new System.EventHandler(this.rideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(55, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 25);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Facade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 162);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rideButton);
            this.Controls.Add(this.createButton);
            this.Name = "Facade";
            this.Text = "Automobiles";
            this.Load += new System.EventHandler(this.Facade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button rideButton;
        private System.Windows.Forms.Button exitButton;

    }
}

