
namespace Stacja_narciarska
{
    partial class panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel));
            this.sellButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.wyciagButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.blockButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.sprzedaz1 = new Stacja_narciarska.sprzedaz();
            this.blokowanie1 = new Stacja_narciarska.blokowanie();
            this.zmianaCen1 = new Stacja_narciarska.zmianaCen();
            this.wyciagi1 = new Stacja_narciarska.wyciagi();
            this.historia1 = new Stacja_narciarska.historia();
            this.mapa1 = new Stacja_narciarska.mapa();
            this.profil1 = new Stacja_narciarska.mapa();
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
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(0, 92);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(193, 65);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "Historia biletu/karnetu";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // wyciagButton
            // 
            this.wyciagButton.Location = new System.Drawing.Point(0, 173);
            this.wyciagButton.Name = "wyciagButton";
            this.wyciagButton.Size = new System.Drawing.Size(193, 65);
            this.wyciagButton.TabIndex = 2;
            this.wyciagButton.Text = "Wyciągi";
            this.wyciagButton.UseVisualStyleBackColor = true;
            this.wyciagButton.Click += new System.EventHandler(this.wyciagButton_Click);
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
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(0, 428);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(95, 33);
            this.mapButton.TabIndex = 5;
            this.mapButton.Text = "Mapa";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(0, 335);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(193, 65);
            this.blockButton.TabIndex = 8;
            this.blockButton.Text = "Blokowanie karnetów";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(0, 253);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(193, 65);
            this.modButton.TabIndex = 7;
            this.modButton.Text = "Zmiana cen biletów/karnetów";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // sprzedaz1
            // 
            this.sprzedaz1.Location = new System.Drawing.Point(199, 12);
            this.sprzedaz1.Name = "sprzedaz1";
            this.sprzedaz1.Size = new System.Drawing.Size(619, 446);
            this.sprzedaz1.TabIndex = 9;
            this.sprzedaz1.Load += new System.EventHandler(this.sprzedaz1_Load);
            // 
            // blokowanie1
            // 
            this.blokowanie1.Location = new System.Drawing.Point(199, 12);
            this.blokowanie1.Name = "blokowanie1";
            this.blokowanie1.Size = new System.Drawing.Size(619, 446);
            this.blokowanie1.TabIndex = 13;
            // 
            // zmianaCen1
            // 
            this.zmianaCen1.Location = new System.Drawing.Point(199, 12);
            this.zmianaCen1.Name = "zmianaCen1";
            this.zmianaCen1.Size = new System.Drawing.Size(619, 446);
            this.zmianaCen1.TabIndex = 12;
            // 
            // wyciagi1
            // 
            this.wyciagi1.Location = new System.Drawing.Point(199, 12);
            this.wyciagi1.Name = "wyciagi1";
            this.wyciagi1.Size = new System.Drawing.Size(619, 446);
            this.wyciagi1.TabIndex = 11;
            // 
            // historia1
            // 
            this.historia1.Location = new System.Drawing.Point(199, 12);
            this.historia1.Name = "historia1";
            this.historia1.Size = new System.Drawing.Size(619, 446);
            this.historia1.TabIndex = 10;
            // 
            // mapa1
            // 
            this.mapa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapa1.BackgroundImage")));
            this.mapa1.Location = new System.Drawing.Point(199, 12);
            this.mapa1.Name = "mapa1";
            this.mapa1.Size = new System.Drawing.Size(619, 446);
            this.mapa1.TabIndex = 14;
            // 
            // profil1
            // 
            this.profil1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profil1.BackgroundImage")));
            this.profil1.Location = new System.Drawing.Point(207, 12);
            this.profil1.Name = "profil1";
            this.profil1.Size = new System.Drawing.Size(619, 446);
            this.profil1.TabIndex = 14;
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.sprzedaz1);
            this.Controls.Add(this.blokowanie1);
            this.Controls.Add(this.zmianaCen1);
            this.Controls.Add(this.wyciagi1);
            this.Controls.Add(this.historia1);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.wyciagButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.mapa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "panel";
            this.Load += new System.EventHandler(this.panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button wyciagButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.Button modButton;
        private sprzedaz sprzedaz1;
        private historia historia1;
        private wyciagi wyciagi1;
        private zmianaCen zmianaCen1;
        private blokowanie blokowanie1;
        private mapa profil1;
        private mapa mapa1;
    }
}