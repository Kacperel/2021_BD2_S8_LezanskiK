
namespace Stacja_narciarska
{
    partial class historia
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
            this.podaneID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.szukaj = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // podaneID
            // 
            this.podaneID.Location = new System.Drawing.Point(36, 39);
            this.podaneID.Name = "podaneID";
            this.podaneID.Size = new System.Drawing.Size(293, 20);
            this.podaneID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wprowadz ID";
            // 
            // szukaj
            // 
            this.szukaj.Location = new System.Drawing.Point(359, 39);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(75, 23);
            this.szukaj.TabIndex = 3;
            this.szukaj.Text = "Szukaj";
            this.szukaj.UseVisualStyleBackColor = true;
            this.szukaj.Click += new System.EventHandler(this.szukaj_Click);
            // 
            // lista
            // 
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(25, 88);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(408, 306);
            this.lista.TabIndex = 4;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lista);
            this.Controls.Add(this.szukaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podaneID);
            this.Name = "historia";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox podaneID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button szukaj;
        private System.Windows.Forms.ListView lista;
    }
}
