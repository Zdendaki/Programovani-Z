namespace Euro
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CZK = new System.Windows.Forms.NumericUpDown();
            this.EUR = new System.Windows.Forms.NumericUpDown();
            this.Count = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CZK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EUR)).BeginInit();
            this.SuspendLayout();
            // 
            // CZK
            // 
            this.CZK.DecimalPlaces = 2;
            this.CZK.Location = new System.Drawing.Point(12, 24);
            this.CZK.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CZK.Name = "CZK";
            this.CZK.Size = new System.Drawing.Size(120, 20);
            this.CZK.TabIndex = 0;
            // 
            // EUR
            // 
            this.EUR.DecimalPlaces = 2;
            this.EUR.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EUR.InterceptArrowKeys = false;
            this.EUR.Location = new System.Drawing.Point(12, 60);
            this.EUR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EUR.Name = "EUR";
            this.EUR.ReadOnly = true;
            this.EUR.Size = new System.Drawing.Size(120, 20);
            this.EUR.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(96, 95);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 2;
            this.Count.Text = "Přepočítat";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CZK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EUR";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.EUR);
            this.Controls.Add(this.CZK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Euro";
            ((System.ComponentModel.ISupportInitialize)(this.CZK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EUR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CZK;
        private System.Windows.Forms.NumericUpDown EUR;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

