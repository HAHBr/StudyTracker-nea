namespace StudyTracker
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.petName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(348, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 63);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.Location = new System.Drawing.Point(26, 35);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(90, 76);
            this.btnsettings.TabIndex = 2;
            this.btnsettings.Text = "settings";
            this.btnsettings.UseVisualStyleBackColor = true;
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShop.BackgroundImage")));
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShop.Location = new System.Drawing.Point(26, 156);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(90, 82);
            this.btnShop.TabIndex = 3;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // petName
            // 
            this.petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petName.Location = new System.Drawing.Point(326, 29);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(179, 31);
            this.petName.TabIndex = 5;
            this.petName.Text = "Enter pet name";
            this.petName.TextChanged += new System.EventHandler(this.petName_TextChanged);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(838, 575);
            this.Controls.Add(this.petName);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnStart);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.TextBox petName;
    }
}

