
namespace Stacja_narciarska
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param //name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
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
            this.szukanieUser1 = new Stacja_narciarska.szukanieUser();
            this.SuspendLayout();
            // 
            // szukanieUser1
            // 
            this.szukanieUser1.Location = new System.Drawing.Point(-3, 0);
            this.szukanieUser1.Name = "szukanieUser1";
            this.szukanieUser1.Size = new System.Drawing.Size(809, 452);
            this.szukanieUser1.TabIndex = 2;
            this.szukanieUser1.Load += new System.EventHandler(this.szukanieUser1_Load_1);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 454);
            this.Controls.Add(this.szukanieUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Start";
            this.Text = "Stacja_narciarska";
            this.ResumeLayout(false);

        }

        #endregion
        private szukanieUser szukanieUser1;
    }
}

