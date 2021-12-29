
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
            this.zablokuj = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aktualizuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zablokuj
            // 
            this.zablokuj.AutoSize = true;
            this.zablokuj.Location = new System.Drawing.Point(310, 75);
            this.zablokuj.Name = "zablokuj";
            this.zablokuj.Size = new System.Drawing.Size(67, 17);
            this.zablokuj.TabIndex = 0;
            this.zablokuj.Text = "Zablokuj";
            this.zablokuj.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // aktualizuj
            // 
            this.aktualizuj.Location = new System.Drawing.Point(310, 118);
            this.aktualizuj.Name = "aktualizuj";
            this.aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.aktualizuj.TabIndex = 2;
            this.aktualizuj.Text = "Aktualizuj";
            this.aktualizuj.UseVisualStyleBackColor = true;
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
            // wyciagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aktualizuj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zablokuj);
            this.Name = "wyciagi";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zablokuj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button aktualizuj;
        private System.Windows.Forms.Label label1;
    }
}
