namespace StudyTracker
{
    partial class shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryOpen = new System.Windows.Forms.Button();
            this.lblTagline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOP";
            // 
            // inventoryOpen
            // 
            this.inventoryOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inventoryOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.inventoryOpen.Location = new System.Drawing.Point(519, 180);
            this.inventoryOpen.Name = "inventoryOpen";
            this.inventoryOpen.Size = new System.Drawing.Size(171, 52);
            this.inventoryOpen.TabIndex = 1;
            this.inventoryOpen.Text = "Inventory";
            this.inventoryOpen.UseVisualStyleBackColor = false;
            this.inventoryOpen.Click += new System.EventHandler(this.inventoryOpen_Click);
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblTagline.Location = new System.Drawing.Point(282, 103);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(226, 21);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Spend your rewards wisely!";
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.inventoryOpen);
            this.Controls.Add(this.label1);
            this.Name = "shop";
            this.Text = "shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inventoryOpen;
        private System.Windows.Forms.Label lblTagline;
    }
}
