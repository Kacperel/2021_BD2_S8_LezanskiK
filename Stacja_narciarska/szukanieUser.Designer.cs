
namespace Stacja_narciarska
{
    partial class szukanieUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findIdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(288, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadz ID";
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(675, 22);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(109, 34);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Zaloguj się";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(227, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 53);
            this.textBox1.TabIndex = 2;
            // 
            // findIdButton
            // 
            this.findIdButton.Location = new System.Drawing.Point(295, 278);
            this.findIdButton.Name = "findIdButton";
            this.findIdButton.Size = new System.Drawing.Size(215, 42);
            this.findIdButton.TabIndex = 3;
            this.findIdButton.Text = "Szukaj";
            this.findIdButton.UseVisualStyleBackColor = true;
            // 
            // szukanieUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findIdButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label1);
            this.Name = "szukanieUser";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findIdButton;
    }
}

