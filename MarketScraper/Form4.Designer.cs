﻿namespace MarketScraper
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSparCart = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBiedronkaCart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBiedronkaSum = new System.Windows.Forms.TextBox();
            this.textBoxSparSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.textBoxSumSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveListSpar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveListBiedronka = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSparCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiedronkaCart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSparCart
            // 
            this.dataGridViewSparCart.AllowUserToAddRows = false;
            this.dataGridViewSparCart.AllowUserToDeleteRows = false;
            this.dataGridViewSparCart.AllowUserToResizeColumns = false;
            this.dataGridViewSparCart.AllowUserToResizeRows = false;
            this.dataGridViewSparCart.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSparCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSparCart.ColumnHeadersHeight = 28;
            this.dataGridViewSparCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSparCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSparCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSparCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSparCart.Location = new System.Drawing.Point(421, 48);
            this.dataGridViewSparCart.MultiSelect = false;
            this.dataGridViewSparCart.Name = "dataGridViewSparCart";
            this.dataGridViewSparCart.ReadOnly = true;
            this.dataGridViewSparCart.RowHeadersVisible = false;
            this.dataGridViewSparCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSparCart.RowTemplate.ReadOnly = true;
            this.dataGridViewSparCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSparCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSparCart.Size = new System.Drawing.Size(421, 402);
            this.dataGridViewSparCart.TabIndex = 10;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ilość";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Zdjęcie";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Info";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewBiedronkaCart
            // 
            this.dataGridViewBiedronkaCart.AllowUserToAddRows = false;
            this.dataGridViewBiedronkaCart.AllowUserToDeleteRows = false;
            this.dataGridViewBiedronkaCart.AllowUserToResizeColumns = false;
            this.dataGridViewBiedronkaCart.AllowUserToResizeRows = false;
            this.dataGridViewBiedronkaCart.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBiedronkaCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBiedronkaCart.ColumnHeadersHeight = 28;
            this.dataGridViewBiedronkaCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBiedronkaCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewImageColumn1,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBiedronkaCart.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBiedronkaCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBiedronkaCart.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewBiedronkaCart.MultiSelect = false;
            this.dataGridViewBiedronkaCart.Name = "dataGridViewBiedronkaCart";
            this.dataGridViewBiedronkaCart.ReadOnly = true;
            this.dataGridViewBiedronkaCart.RowHeadersVisible = false;
            this.dataGridViewBiedronkaCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBiedronkaCart.RowTemplate.ReadOnly = true;
            this.dataGridViewBiedronkaCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBiedronkaCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBiedronkaCart.Size = new System.Drawing.Size(421, 402);
            this.dataGridViewBiedronkaCart.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ilość";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Zdjęcie";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Info";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // textBoxBiedronkaSum
            // 
            this.textBoxBiedronkaSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBiedronkaSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBiedronkaSum.Location = new System.Drawing.Point(284, 412);
            this.textBoxBiedronkaSum.Name = "textBoxBiedronkaSum";
            this.textBoxBiedronkaSum.ReadOnly = true;
            this.textBoxBiedronkaSum.Size = new System.Drawing.Size(122, 26);
            this.textBoxBiedronkaSum.TabIndex = 11;
            // 
            // textBoxSparSum
            // 
            this.textBoxSparSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSparSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSparSum.Location = new System.Drawing.Point(704, 412);
            this.textBoxSparSum.Name = "textBoxSparSum";
            this.textBoxSparSum.ReadOnly = true;
            this.textBoxSparSum.Size = new System.Drawing.Size(122, 26);
            this.textBoxSparSum.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Łącznie: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(626, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Łącznie: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 48);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(426, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Biedronka";
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearCart.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearCart.Location = new System.Drawing.Point(852, 54);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(107, 49);
            this.buttonClearCart.TabIndex = 17;
            this.buttonClearCart.Text = "Wyczyść koszyk";
            this.buttonClearCart.UseVisualStyleBackColor = false;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // textBoxSumSum
            // 
            this.textBoxSumSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSumSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSumSum.Location = new System.Drawing.Point(850, 159);
            this.textBoxSumSum.Name = "textBoxSumSum";
            this.textBoxSumSum.ReadOnly = true;
            this.textBoxSumSum.Size = new System.Drawing.Size(107, 26);
            this.textBoxSumSum.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(856, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Łącznie za  \r\nwszystko: ";
            // 
            // buttonSaveListSpar
            // 
            this.buttonSaveListSpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveListSpar.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSaveListSpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveListSpar.Location = new System.Drawing.Point(852, 370);
            this.buttonSaveListSpar.Name = "buttonSaveListSpar";
            this.buttonSaveListSpar.Size = new System.Drawing.Size(107, 68);
            this.buttonSaveListSpar.TabIndex = 20;
            this.buttonSaveListSpar.Text = "Zapisz listę zakupow Spar";
            this.buttonSaveListSpar.UseVisualStyleBackColor = false;
            this.buttonSaveListSpar.Click += new System.EventHandler(this.buttonSaveListSpar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.jpeg";
            // 
            // buttonSaveListBiedronka
            // 
            this.buttonSaveListBiedronka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveListBiedronka.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSaveListBiedronka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveListBiedronka.Location = new System.Drawing.Point(852, 296);
            this.buttonSaveListBiedronka.Name = "buttonSaveListBiedronka";
            this.buttonSaveListBiedronka.Size = new System.Drawing.Size(107, 68);
            this.buttonSaveListBiedronka.TabIndex = 21;
            this.buttonSaveListBiedronka.Text = "Zapisz listę zakupow Biedronka";
            this.buttonSaveListBiedronka.UseVisualStyleBackColor = false;
            this.buttonSaveListBiedronka.Click += new System.EventHandler(this.buttonSaveListBiedronka_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrder.Location = new System.Drawing.Point(850, 213);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(107, 52);
            this.buttonOrder.TabIndex = 22;
            this.buttonOrder.Text = "Zamów zakupy";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonSaveListBiedronka);
            this.Controls.Add(this.buttonSaveListSpar);
            this.Controls.Add(this.buttonClearCart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSumSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSparSum);
            this.Controls.Add(this.textBoxBiedronkaSum);
            this.Controls.Add(this.dataGridViewSparCart);
            this.Controls.Add(this.dataGridViewBiedronkaCart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Koszyk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSparCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiedronkaCart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSparCart;
        private System.Windows.Forms.DataGridView dataGridViewBiedronkaCart;
        private System.Windows.Forms.TextBox textBoxBiedronkaSum;
        private System.Windows.Forms.TextBox textBoxSparSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.TextBox textBoxSumSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveListSpar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonSaveListBiedronka;
        private System.Windows.Forms.Button buttonOrder;
    }
}