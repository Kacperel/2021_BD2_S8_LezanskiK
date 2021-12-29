
namespace Stacja_narciarska
{
    partial class panelAdmina
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
            this.sellButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.wyciagButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(0, 12);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(193, 65);
            this.sellButton.TabIndex = 0;
            this.sellButton.Text = "Sprzedaż biletów/karnetów";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(0, 92);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(193, 65);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "Historia biletu/karnetu";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // wyciagButton
            // 
            this.wyciagButton.Location = new System.Drawing.Point(0, 173);
            this.wyciagButton.Name = "wyciagButton";
            this.wyciagButton.Size = new System.Drawing.Size(193, 65);
            this.wyciagButton.TabIndex = 2;
            this.wyciagButton.Text = "Wyciągi";
            this.wyciagButton.UseVisualStyleBackColor = true;
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(0, 254);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(193, 65);
            this.modButton.TabIndex = 3;
            this.modButton.Text = "Zmiana cen biletów/karnetów";
            this.modButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(98, 428);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(95, 33);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(0, 428);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(95, 33);
            this.profileButton.TabIndex = 5;
            this.profileButton.Text = "Profil";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // panelAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.wyciagButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.sellButton);
            this.Name = "panelAdmina";
            this.Size = new System.Drawing.Size(835, 473);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button wyciagButton;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button profileButton;
    }
}