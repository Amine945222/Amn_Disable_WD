namespace AMN_Defender
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_defender = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Enable = new System.Windows.Forms.Button();
            this.button_Disable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_defender)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_defender
            // 
            this.pictureBox_defender.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_defender.Image")));
            this.pictureBox_defender.Location = new System.Drawing.Point(12, 9);
            this.pictureBox_defender.Name = "pictureBox_defender";
            this.pictureBox_defender.Size = new System.Drawing.Size(125, 91);
            this.pictureBox_defender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_defender.TabIndex = 0;
            this.pictureBox_defender.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Disable);
            this.groupBox1.Controls.Add(this.button_Enable);
            this.groupBox1.Location = new System.Drawing.Point(143, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defender";
            // 
            // button_Enable
            // 
            this.button_Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enable.ForeColor = System.Drawing.Color.Lime;
            this.button_Enable.Location = new System.Drawing.Point(6, 19);
            this.button_Enable.Name = "button_Enable";
            this.button_Enable.Size = new System.Drawing.Size(163, 30);
            this.button_Enable.TabIndex = 0;
            this.button_Enable.Text = "Enable";
            this.button_Enable.UseVisualStyleBackColor = true;
            this.button_Enable.Click += new System.EventHandler(this.button_Enable_Click);
            // 
            // button_Disable
            // 
            this.button_Disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disable.ForeColor = System.Drawing.Color.Red;
            this.button_Disable.Location = new System.Drawing.Point(6, 52);
            this.button_Disable.Name = "button_Disable";
            this.button_Disable.Size = new System.Drawing.Size(163, 30);
            this.button_Disable.TabIndex = 1;
            this.button_Disable.Text = "Disable";
            this.button_Disable.UseVisualStyleBackColor = true;
            this.button_Disable.Click += new System.EventHandler(this.button_Disable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 104);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_defender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMN_Defender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_defender)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_defender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Disable;
        private System.Windows.Forms.Button button_Enable;
    }
}

