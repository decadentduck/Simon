namespace Simon
{
    partial class GameOverScreen
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
            this.textLabel = new System.Windows.Forms.Label();
            this.instuctionLabel = new System.Windows.Forms.Label();
            this.loserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(21, 95);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(338, 39);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "You got a chain of: ";
            // 
            // instuctionLabel
            // 
            this.instuctionLabel.AutoSize = true;
            this.instuctionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instuctionLabel.Location = new System.Drawing.Point(140, 290);
            this.instuctionLabel.Name = "instuctionLabel";
            this.instuctionLabel.Size = new System.Drawing.Size(195, 22);
            this.instuctionLabel.TabIndex = 1;
            this.instuctionLabel.Text = "Click anywhere to continue";
            // 
            // loserLabel
            // 
            this.loserLabel.AutoSize = true;
            this.loserLabel.Location = new System.Drawing.Point(340, 187);
            this.loserLabel.Name = "loserLabel";
            this.loserLabel.Size = new System.Drawing.Size(101, 13);
            this.loserLabel.TabIndex = 2;
            this.loserLabel.Text = "Nice job... probably.";
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.loserLabel);
            this.Controls.Add(this.instuctionLabel);
            this.Controls.Add(this.textLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(490, 390);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.Click += new System.EventHandler(this.GameOverScreen_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label instuctionLabel;
        private System.Windows.Forms.Label loserLabel;
    }
}
