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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(325, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Study";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnsettings.Location = new System.Drawing.Point(28, 28);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(108, 44);
            this.btnsettings.TabIndex = 2;
            this.btnsettings.Text = "Settings";
            this.btnsettings.UseVisualStyleBackColor = false;
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShop.BackgroundImage")));
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Location = new System.Drawing.Point(28, 100);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(108, 100);
            this.btnShop.TabIndex = 3;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // petName
            // 
            this.petName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
            this.petName.Location = new System.Drawing.Point(290, 208);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(250, 32);
            this.petName.TabIndex = 5;
            this.petName.Text = "Enter pet name";
            this.petName.TextChanged += new System.EventHandler(this.petName_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(270, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 47);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Study Tracker";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPetName.ForeColor = System.Drawing.Color.White;
            this.lblPetName.Location = new System.Drawing.Point(287, 181);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(78, 20);
            this.lblPetName.TabIndex = 7;
            this.lblPetName.Text = "Pet Name";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(838, 575);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.petName);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnStart);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.TextBox petName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPetName;
    }
}
