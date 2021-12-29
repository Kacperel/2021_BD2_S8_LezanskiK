
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
            this.lista = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.potwierdz = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.duplikuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(181, 35);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(288, 290);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(41, 211);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 4;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // potwierdz
            // 
            this.potwierdz.Location = new System.Drawing.Point(332, 365);
            this.potwierdz.Name = "potwierdz";
            this.potwierdz.Size = new System.Drawing.Size(137, 23);
            this.potwierdz.TabIndex = 5;
            this.potwierdz.Text = "Potwierdź zakup";
            this.potwierdz.UseVisualStyleBackColor = true;
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(302, 6);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 23);
            this.usun.TabIndex = 6;
            this.usun.Text = "Usun";
            this.usun.UseVisualStyleBackColor = true;
            // 
            // duplikuj
            // 
            this.duplikuj.Location = new System.Drawing.Point(394, 6);
            this.duplikuj.Name = "duplikuj";
            this.duplikuj.Size = new System.Drawing.Size(75, 23);
            this.duplikuj.TabIndex = 7;
            this.duplikuj.Text = "Duplikuj ";
            this.duplikuj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rodzaj wejścia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rodzaj ulgi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ilość";
            // 
            // sprzedaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duplikuj);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.potwierdz);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lista);
            this.Name = "sprzedaz";
            this.Size = new System.Drawing.Size(619, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button potwierdz;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button duplikuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
