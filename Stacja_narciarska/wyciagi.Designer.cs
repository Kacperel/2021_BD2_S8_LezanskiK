
namespace Stacja_narciarska
{
    partial class wyciagi
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
            this.wybor_wyciagu = new System.Windows.Forms.ComboBox();
            this.aktualizuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zablokowany = new System.Windows.Forms.RadioButton();
            this.odblokowany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // wybor_wyciagu
            // 
            this.wybor_wyciagu.FormattingEnabled = true;
            this.wybor_wyciagu.Location = new System.Drawing.Point(285, 32);
            this.wybor_wyciagu.Name = "wybor_wyciagu";
            this.wybor_wyciagu.Size = new System.Drawing.Size(121, 21);
            this.wybor_wyciagu.TabIndex = 1;
            this.wybor_wyciagu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aktualizuj
            // 
            this.aktualizuj.Location = new System.Drawing.Point(306, 120);
            this.aktualizuj.Name = "aktualizuj";
            this.aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.aktualizuj.TabIndex = 2;
            this.aktualizuj.Text = "Aktualizuj";
            this.aktualizuj.UseVisualStyleBackColor = true;
            this.aktualizuj.Click += new System.EventHandler(this.aktualizuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz wyciag";
            // 
            // zablokowany
            // 
            this.zablokowany.AutoSize = true;
            this.zablokowany.Location = new System.Drawing.Point(296, 74);
            this.zablokowany.Name = "zablokowany";
            this.zablokowany.Size = new System.Drawing.Size(89, 17);
            this.zablokowany.TabIndex = 4;
            this.zablokowany.TabStop = true;
            this.zablokowany.Text = "Zablokowany";
            this.zablokowany.UseVisualStyleBackColor = true;
            this.zablokowany.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // odblokowany
            // 
            this.odblokowany.AutoSize = true;
            this.odblokowany.Location = new System.Drawing.Point(296, 97);
            this.odblokowany.Name = "odblokowany";
            this.odblokowany.Size = new System.Drawing.Size(90, 17);
            this.odblokowany.TabIndex = 5;
            this.odblokowany.TabStop = true;
            this.odblokowany.Text = "Odblokowany";
            this.odblokowany.UseVisualStyleBackColor = true;
            // 
            // wyciagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.odblokowany);
            this.Controls.Add(this.zablokowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aktualizuj);
            this.Controls.Add(this.wybor_wyciagu);
            this.Name = "wyciagi";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox wybor_wyciagu;
        private System.Windows.Forms.Button aktualizuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton zablokowany;
        private System.Windows.Forms.RadioButton odblokowany;
    }
}
