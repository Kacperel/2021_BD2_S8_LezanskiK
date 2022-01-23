
namespace Stacja_narciarska
{
    partial class sprzedaz
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.rodzajWejscia = new System.Windows.Forms.ComboBox();
            this.potwierdz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bilet_karnet = new System.Windows.Forms.ComboBox();
            this.ilosc = new System.Windows.Forms.ComboBox();
            this.aktualizuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rodzajWejscia
            // 
            this.rodzajWejscia.FormattingEnabled = true;
            this.rodzajWejscia.Location = new System.Drawing.Point(261, 153);
            this.rodzajWejscia.Name = "rodzajWejscia";
            this.rodzajWejscia.Size = new System.Drawing.Size(121, 21);
            this.rodzajWejscia.TabIndex = 1;
            // 
            // potwierdz
            // 
            this.potwierdz.Location = new System.Drawing.Point(261, 220);
            this.potwierdz.Name = "potwierdz";
            this.potwierdz.Size = new System.Drawing.Size(137, 23);
            this.potwierdz.TabIndex = 5;
            this.potwierdz.Text = "Potwierdź zakup";
            this.potwierdz.UseVisualStyleBackColor = true;
            this.potwierdz.Click += new System.EventHandler(this.potwierdz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rodzaj wejscia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bilet/karnet";
            // 
            // bilet_karnet
            // 
            this.bilet_karnet.FormattingEnabled = true;
            this.bilet_karnet.Items.AddRange(new object[] {
            "bilet",
            "karnet"});
            this.bilet_karnet.Location = new System.Drawing.Point(261, 84);
            this.bilet_karnet.Name = "bilet_karnet";
            this.bilet_karnet.Size = new System.Drawing.Size(121, 21);
            this.bilet_karnet.TabIndex = 16;
            // 
            // ilosc
            // 
            this.ilosc.FormattingEnabled = true;
            this.ilosc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ilosc.Location = new System.Drawing.Point(261, 193);
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(121, 21);
            this.ilosc.TabIndex = 18;
            // 
            // aktualizuj
            // 
            this.aktualizuj.Location = new System.Drawing.Point(261, 111);
            this.aktualizuj.Name = "aktualizuj";
            this.aktualizuj.Size = new System.Drawing.Size(137, 23);
            this.aktualizuj.TabIndex = 19;
            this.aktualizuj.Text = "Wybierz";
            this.aktualizuj.UseVisualStyleBackColor = true;
            this.aktualizuj.Click += new System.EventHandler(this.aktualizuj_Click_1);
            // 
            // sprzedaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aktualizuj);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bilet_karnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.potwierdz);
            this.Controls.Add(this.rodzajWejscia);
            this.Name = "sprzedaz";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox rodzajWejscia;
        private System.Windows.Forms.Button potwierdz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bilet_karnet;
        private System.Windows.Forms.ComboBox ilosc;
        private System.Windows.Forms.Button aktualizuj;
    }
}
