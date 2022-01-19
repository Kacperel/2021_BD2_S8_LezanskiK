
namespace Stacja_narciarska
{
    partial class blokowanie
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
            this.podaneID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.odblokowany = new System.Windows.Forms.RadioButton();
            this.zablokowany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // podaneID
            // 
            this.podaneID.Location = new System.Drawing.Point(366, 128);
            this.podaneID.Name = "podaneID";
            this.podaneID.Size = new System.Drawing.Size(100, 20);
            this.podaneID.TabIndex = 0;
            this.podaneID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadz ID karnetu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // odblokowany
            // 
            this.odblokowany.AutoSize = true;
            this.odblokowany.Location = new System.Drawing.Point(376, 187);
            this.odblokowany.Name = "odblokowany";
            this.odblokowany.Size = new System.Drawing.Size(90, 17);
            this.odblokowany.TabIndex = 4;
            this.odblokowany.TabStop = true;
            this.odblokowany.Text = "Odblokowany";
            this.odblokowany.UseVisualStyleBackColor = true;
            // 
            // zablokowany
            // 
            this.zablokowany.AutoSize = true;
            this.zablokowany.Location = new System.Drawing.Point(376, 164);
            this.zablokowany.Name = "zablokowany";
            this.zablokowany.Size = new System.Drawing.Size(89, 17);
            this.zablokowany.TabIndex = 5;
            this.zablokowany.TabStop = true;
            this.zablokowany.Text = "Zablokowany";
            this.zablokowany.UseVisualStyleBackColor = true;
            // 
            // blokowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zablokowany);
            this.Controls.Add(this.odblokowany);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podaneID);
            this.Name = "blokowanie";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox podaneID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton odblokowany;
        private System.Windows.Forms.RadioButton zablokowany;
    }
}
