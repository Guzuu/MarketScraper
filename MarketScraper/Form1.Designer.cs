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
            this.buttonOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // buttonOrders
            // 
            this.buttonOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrders.Location = new System.Drawing.Point(277, 269);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(182, 71);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Zamówienia";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(623, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "By Guzuu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarketScraper.Properties.Resources.MSmainBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonPromo);
            this.Name = "Form1";
            this.Text = "Market Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPromo;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Label label1;
    }
}

