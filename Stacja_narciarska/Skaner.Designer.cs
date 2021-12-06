
namespace Stacja_narciarska
{
    partial class Skaner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_wyciagu = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_narciarza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_wyciagu
            // 
            this.ID_wyciagu.Location = new System.Drawing.Point(194, 261);
            this.ID_wyciagu.Name = "ID_wyciagu";
            this.ID_wyciagu.Size = new System.Drawing.Size(442, 80);
            this.ID_wyciagu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(199, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj swoje ID";
            // 
            // ID_narciarza
            // 
            this.ID_narciarza.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ID_narciarza.Location = new System.Drawing.Point(194, 148);
            this.ID_narciarza.Name = "ID_narciarza";
            this.ID_narciarza.Size = new System.Drawing.Size(307, 45);
            this.ID_narciarza.TabIndex = 2;
            this.ID_narciarza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(199, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz wyciag";
            // 
            // Skaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_narciarza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_wyciagu);
            this.Name = "Skaner";
            this.Text = "Skaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ID_wyciagu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_narciarza;
        private System.Windows.Forms.Label label2;
    }
}