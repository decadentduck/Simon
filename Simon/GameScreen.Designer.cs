﻿namespace Simon
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redButton.Location = new System.Drawing.Point(84, 80);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(148, 88);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blueButton.Location = new System.Drawing.Point(238, 80);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(148, 88);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.greenButton.Location = new System.Drawing.Point(238, 174);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(148, 88);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yellowButton.Location = new System.Drawing.Point(84, 174);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(148, 88);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(490, 390);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
    }
}