﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.narciarz_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wyciag_wybor = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(288, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz wyciag";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wyciag_wybor
            // 
            this.wyciag_wybor.Location = new System.Drawing.Point(249, 256);
            this.wyciag_wybor.Name = "wyciag_wybor";
            this.wyciag_wybor.Size = new System.Drawing.Size(324, 97);
            this.wyciag_wybor.TabIndex = 3;
            // 
            // Skaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skaner.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wyciag_wybor);
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
        private System.Windows.Forms.TreeView wyciag_wybor;
    }
}

