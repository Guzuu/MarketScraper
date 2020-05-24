namespace MarketScraper
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBiedronkaPromo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonGetPromos = new System.Windows.Forms.Button();
            this.dataGridViewSparPromo = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewLidlPromo = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiedronkaPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSparPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLidlPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBiedronkaPromo
            // 
            this.dataGridViewBiedronkaPromo.AllowUserToAddRows = false;
            this.dataGridViewBiedronkaPromo.AllowUserToDeleteRows = false;
            this.dataGridViewBiedronkaPromo.AllowUserToResizeColumns = false;
            this.dataGridViewBiedronkaPromo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBiedronkaPromo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBiedronkaPromo.ColumnHeadersHeight = 28;
            this.dataGridViewBiedronkaPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBiedronkaPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewBiedronkaPromo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBiedronkaPromo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBiedronkaPromo.MultiSelect = false;
            this.dataGridViewBiedronkaPromo.Name = "dataGridViewBiedronkaPromo";
            this.dataGridViewBiedronkaPromo.ReadOnly = true;
            this.dataGridViewBiedronkaPromo.RowHeadersVisible = false;
            this.dataGridViewBiedronkaPromo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBiedronkaPromo.RowTemplate.ReadOnly = true;
            this.dataGridViewBiedronkaPromo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBiedronkaPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBiedronkaPromo.Size = new System.Drawing.Size(421, 509);
            this.dataGridViewBiedronkaPromo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Biedronka";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 400;
            // 
            // buttonGetPromos
            // 
            this.buttonGetPromos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetPromos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetPromos.Location = new System.Drawing.Point(1126, 451);
            this.buttonGetPromos.Name = "buttonGetPromos";
            this.buttonGetPromos.Size = new System.Drawing.Size(125, 46);
            this.buttonGetPromos.TabIndex = 1;
            this.buttonGetPromos.Text = "Pobierz Promocje";
            this.buttonGetPromos.UseVisualStyleBackColor = true;
            this.buttonGetPromos.Click += new System.EventHandler(this.buttonGetPromos_Click);
            // 
            // dataGridViewSparPromo
            // 
            this.dataGridViewSparPromo.AllowUserToAddRows = false;
            this.dataGridViewSparPromo.AllowUserToDeleteRows = false;
            this.dataGridViewSparPromo.AllowUserToResizeColumns = false;
            this.dataGridViewSparPromo.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSparPromo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSparPromo.ColumnHeadersHeight = 28;
            this.dataGridViewSparPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSparPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridViewSparPromo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSparPromo.Location = new System.Drawing.Point(421, 0);
            this.dataGridViewSparPromo.MultiSelect = false;
            this.dataGridViewSparPromo.Name = "dataGridViewSparPromo";
            this.dataGridViewSparPromo.ReadOnly = true;
            this.dataGridViewSparPromo.RowHeadersVisible = false;
            this.dataGridViewSparPromo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSparPromo.RowTemplate.ReadOnly = true;
            this.dataGridViewSparPromo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSparPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSparPromo.Size = new System.Drawing.Size(421, 509);
            this.dataGridViewSparPromo.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Spar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // dataGridViewLidlPromo
            // 
            this.dataGridViewLidlPromo.AllowUserToAddRows = false;
            this.dataGridViewLidlPromo.AllowUserToDeleteRows = false;
            this.dataGridViewLidlPromo.AllowUserToResizeColumns = false;
            this.dataGridViewLidlPromo.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLidlPromo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLidlPromo.ColumnHeadersHeight = 28;
            this.dataGridViewLidlPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLidlPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLidlPromo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLidlPromo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewLidlPromo.Location = new System.Drawing.Point(842, 0);
            this.dataGridViewLidlPromo.MultiSelect = false;
            this.dataGridViewLidlPromo.Name = "dataGridViewLidlPromo";
            this.dataGridViewLidlPromo.ReadOnly = true;
            this.dataGridViewLidlPromo.RowHeadersVisible = false;
            this.dataGridViewLidlPromo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLidlPromo.RowTemplate.ReadOnly = true;
            this.dataGridViewLidlPromo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLidlPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLidlPromo.Size = new System.Drawing.Size(421, 509);
            this.dataGridViewLidlPromo.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Lidl";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 509);
            this.Controls.Add(this.buttonGetPromos);
            this.Controls.Add(this.dataGridViewLidlPromo);
            this.Controls.Add(this.dataGridViewSparPromo);
            this.Controls.Add(this.dataGridViewBiedronkaPromo);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiedronkaPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSparPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLidlPromo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBiedronkaPromo;
        private System.Windows.Forms.Button buttonGetPromos;
        private System.Windows.Forms.DataGridView dataGridViewSparPromo;
        private System.Windows.Forms.DataGridView dataGridViewLidlPromo;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}