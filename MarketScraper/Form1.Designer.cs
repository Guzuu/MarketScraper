namespace MarketScraper
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
            this.buttonPromo = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPromo
            // 
            this.buttonPromo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPromo.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPromo.Location = new System.Drawing.Point(277, 120);
            this.buttonPromo.Name = "buttonPromo";
            this.buttonPromo.Size = new System.Drawing.Size(182, 66);
            this.buttonPromo.TabIndex = 0;
            this.buttonPromo.Text = "Promocje";
            this.buttonPromo.UseVisualStyleBackColor = false;
            this.buttonPromo.Click += new System.EventHandler(this.buttonPromo_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuery.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuery.Location = new System.Drawing.Point(277, 192);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(182, 71);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "Wyszukiwarka";
            this.buttonQuery.UseVisualStyleBackColor = false;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarketScraper.Properties.Resources.MSmainBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonPromo);
            this.Name = "Form1";
            this.Text = "Market Scraper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPromo;
        private System.Windows.Forms.Button buttonQuery;
    }
}

