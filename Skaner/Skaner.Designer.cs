
namespace Skaner
{
    partial class Skaner
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skaner));
            this.label1 = new System.Windows.Forms.Label();
            this.narciarz_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.test = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(305, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadz ID";
            // 
            // narciarz_ID
            // 
            this.narciarz_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.narciarz_ID.Location = new System.Drawing.Point(243, 128);
            this.narciarz_ID.Name = "narciarz_ID";
            this.narciarz_ID.Size = new System.Drawing.Size(330, 45);
            this.narciarz_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(288, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz wyciag";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.test.Location = new System.Drawing.Point(272, 356);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(270, 41);
            this.test.TabIndex = 5;
            this.test.Text = "Wejdz na wyciag";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lewy stok",
            "Prawy stok"});
            this.comboBox1.Location = new System.Drawing.Point(243, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 46);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Skaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skaner.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.narciarz_ID);
            this.Controls.Add(this.label1);
            this.Name = "Skaner";
            this.Text = "Skaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox narciarz_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

