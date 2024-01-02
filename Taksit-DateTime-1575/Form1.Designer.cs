namespace Taksit_DateTime_1575
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
            this.lbTaksit = new System.Windows.Forms.ListBox();
            this.lbTarih = new System.Windows.Forms.ListBox();
            this.txtÜcret = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTaksit
            // 
            this.lbTaksit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaksit.FormattingEnabled = true;
            this.lbTaksit.ItemHeight = 14;
            this.lbTaksit.Location = new System.Drawing.Point(191, 22);
            this.lbTaksit.Name = "lbTaksit";
            this.lbTaksit.Size = new System.Drawing.Size(120, 200);
            this.lbTaksit.TabIndex = 0;
            // 
            // lbTarih
            // 
            this.lbTarih.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarih.FormattingEnabled = true;
            this.lbTarih.ItemHeight = 14;
            this.lbTarih.Location = new System.Drawing.Point(354, 22);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(120, 200);
            this.lbTarih.TabIndex = 1;
            // 
            // txtÜcret
            // 
            this.txtÜcret.Location = new System.Drawing.Point(13, 22);
            this.txtÜcret.Name = "txtÜcret";
            this.txtÜcret.Size = new System.Drawing.Size(151, 20);
            this.txtÜcret.TabIndex = 2;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(13, 68);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(151, 20);
            this.num.TabIndex = 3;
            this.num.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHesapla.Location = new System.Drawing.Point(12, 116);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(151, 37);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(517, 256);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.num);
            this.Controls.Add(this.txtÜcret);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbTaksit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTaksit;
        private System.Windows.Forms.ListBox lbTarih;
        private System.Windows.Forms.TextBox txtÜcret;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button btnHesapla;
    }
}

