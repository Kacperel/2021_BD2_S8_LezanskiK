
namespace Stacja_narciarska
{
    partial class zmianaCen
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
            this.lista_bilety = new System.Windows.Forms.ComboBox();
            this.cena_bilet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bilet_update = new System.Windows.Forms.Button();
            this.karnet_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cena_karnet = new System.Windows.Forms.TextBox();
            this.lista_karnety = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lista_bilety
            // 
            this.lista_bilety.FormattingEnabled = true;
            this.lista_bilety.Location = new System.Drawing.Point(327, 102);
            this.lista_bilety.Name = "lista_bilety";
            this.lista_bilety.Size = new System.Drawing.Size(121, 21);
            this.lista_bilety.TabIndex = 0;
            // 
            // cena_bilet
            // 
            this.cena_bilet.Location = new System.Drawing.Point(327, 166);
            this.cena_bilet.Name = "cena_bilet";
            this.cena_bilet.Size = new System.Drawing.Size(100, 20);
            this.cena_bilet.TabIndex = 1;
            this.cena_bilet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz bilet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadz nowa cene";
            // 
            // bilet_update
            // 
            this.bilet_update.Location = new System.Drawing.Point(337, 202);
            this.bilet_update.Name = "bilet_update";
            this.bilet_update.Size = new System.Drawing.Size(75, 23);
            this.bilet_update.TabIndex = 4;
            this.bilet_update.Text = "Aktualizuj";
            this.bilet_update.UseVisualStyleBackColor = true;
            this.bilet_update.Click += new System.EventHandler(this.bilet_update_Click);
            // 
            // karnet_update
            // 
            this.karnet_update.Location = new System.Drawing.Point(133, 202);
            this.karnet_update.Name = "karnet_update";
            this.karnet_update.Size = new System.Drawing.Size(75, 23);
            this.karnet_update.TabIndex = 9;
            this.karnet_update.Text = "Aktualizuj";
            this.karnet_update.UseVisualStyleBackColor = true;
            this.karnet_update.Click += new System.EventHandler(this.karnet_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wprowadz nowa cene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wybierz karnet";
            // 
            // cena_karnet
            // 
            this.cena_karnet.Location = new System.Drawing.Point(123, 166);
            this.cena_karnet.Name = "cena_karnet";
            this.cena_karnet.Size = new System.Drawing.Size(100, 20);
            this.cena_karnet.TabIndex = 6;
            this.cena_karnet.TextChanged += new System.EventHandler(this.cena_karnet_TextChanged);
            // 
            // lista_karnety
            // 
            this.lista_karnety.FormattingEnabled = true;
            this.lista_karnety.Location = new System.Drawing.Point(123, 102);
            this.lista_karnety.Name = "lista_karnety";
            this.lista_karnety.Size = new System.Drawing.Size(121, 21);
            this.lista_karnety.TabIndex = 5;
            this.lista_karnety.SelectedIndexChanged += new System.EventHandler(this.lista_karnety_SelectedIndexChanged);
            // 
            // zmianaCen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.karnet_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cena_karnet);
            this.Controls.Add(this.lista_karnety);
            this.Controls.Add(this.bilet_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cena_bilet);
            this.Controls.Add(this.lista_bilety);
            this.Name = "zmianaCen";
            this.Size = new System.Drawing.Size(619, 446);
            this.Load += new System.EventHandler(this.zmianaCen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lista_bilety;
        private System.Windows.Forms.TextBox cena_bilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bilet_update;
        private System.Windows.Forms.Button karnet_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cena_karnet;
        private System.Windows.Forms.ComboBox lista_karnety;
    }
}
