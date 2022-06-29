
namespace NaplatnaRampa.Forme
{
    partial class FizickaNaplata
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
            this.label1 = new System.Windows.Forms.Label();
            this.Vreme = new System.Windows.Forms.Label();
            this.tabliceTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vremeTBox = new System.Windows.Forms.TextBox();
            this.tipVozilaCBox = new System.Windows.Forms.ComboBox();
            this.eur = new System.Windows.Forms.RadioButton();
            this.rsd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ucitajBtn = new System.Windows.Forms.Button();
            this.mestoUlaskaCBox = new System.Windows.Forms.ComboBox();
            this.iznosLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uplacenoTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kusurLabel = new System.Windows.Forms.Label();
            this.policijaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablica vozila:";
            // 
            // Vreme
            // 
            this.Vreme.AutoSize = true;
            this.Vreme.Location = new System.Drawing.Point(52, 158);
            this.Vreme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Vreme.Name = "Vreme";
            this.Vreme.Size = new System.Drawing.Size(165, 29);
            this.Vreme.TabIndex = 1;
            this.Vreme.Text = "Vreme ulaska:";
            // 
            // tabliceTBox
            // 
            this.tabliceTBox.Location = new System.Drawing.Point(278, 101);
            this.tabliceTBox.Name = "tabliceTBox";
            this.tabliceTBox.Size = new System.Drawing.Size(169, 35);
            this.tabliceTBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupan iznos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valuta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mesto ulaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tip vozila:";
            // 
            // vremeTBox
            // 
            this.vremeTBox.Location = new System.Drawing.Point(278, 152);
            this.vremeTBox.Name = "vremeTBox";
            this.vremeTBox.Size = new System.Drawing.Size(169, 35);
            this.vremeTBox.TabIndex = 9;
            // 
            // tipVozilaCBox
            // 
            this.tipVozilaCBox.FormattingEnabled = true;
            this.tipVozilaCBox.Items.AddRange(new object[] {
            "automobil",
            "kamion",
            "autobus"});
            this.tipVozilaCBox.Location = new System.Drawing.Point(278, 268);
            this.tipVozilaCBox.Name = "tipVozilaCBox";
            this.tipVozilaCBox.Size = new System.Drawing.Size(169, 37);
            this.tipVozilaCBox.TabIndex = 10;
            // 
            // eur
            // 
            this.eur.AutoSize = true;
            this.eur.Location = new System.Drawing.Point(228, 354);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(88, 33);
            this.eur.TabIndex = 12;
            this.eur.TabStop = true;
            this.eur.Text = "EUR";
            this.eur.UseVisualStyleBackColor = true;
            // 
            // rsd
            // 
            this.rsd.AutoSize = true;
            this.rsd.Location = new System.Drawing.Point(359, 352);
            this.rsd.Name = "rsd";
            this.rsd.Size = new System.Drawing.Size(88, 33);
            this.rsd.TabIndex = 13;
            this.rsd.TabStop = true;
            this.rsd.Text = "RSD";
            this.rsd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(278, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 84);
            this.button1.TabIndex = 14;
            this.button1.Text = "POTVRDI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucitajBtn
            // 
            this.ucitajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucitajBtn.Location = new System.Drawing.Point(12, 425);
            this.ucitajBtn.Name = "ucitajBtn";
            this.ucitajBtn.Size = new System.Drawing.Size(225, 84);
            this.ucitajBtn.TabIndex = 15;
            this.ucitajBtn.Text = "Učitaj podatke";
            this.ucitajBtn.UseVisualStyleBackColor = false;
            this.ucitajBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // mestoUlaskaCBox
            // 
            this.mestoUlaskaCBox.FormattingEnabled = true;
            this.mestoUlaskaCBox.Items.AddRange(new object[] {
            "BG",
            "ZR",
            "LE",
            "NS",
            "SU"});
            this.mestoUlaskaCBox.Location = new System.Drawing.Point(278, 211);
            this.mestoUlaskaCBox.Name = "mestoUlaskaCBox";
            this.mestoUlaskaCBox.Size = new System.Drawing.Size(169, 37);
            this.mestoUlaskaCBox.TabIndex = 16;
            // 
            // iznosLabel
            // 
            this.iznosLabel.AutoSize = true;
            this.iznosLabel.Location = new System.Drawing.Point(863, 101);
            this.iznosLabel.Name = "iznosLabel";
            this.iznosLabel.Size = new System.Drawing.Size(0, 29);
            this.iznosLabel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Uplaćeno:";
            // 
            // uplacenoTBox
            // 
            this.uplacenoTBox.Location = new System.Drawing.Point(837, 149);
            this.uplacenoTBox.Name = "uplacenoTBox";
            this.uplacenoTBox.Size = new System.Drawing.Size(163, 35);
            this.uplacenoTBox.TabIndex = 19;
            this.uplacenoTBox.TextChanged += new System.EventHandler(this.uplacenoTBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kusur:";
            // 
            // kusurLabel
            // 
            this.kusurLabel.AutoSize = true;
            this.kusurLabel.Location = new System.Drawing.Point(832, 214);
            this.kusurLabel.Name = "kusurLabel";
            this.kusurLabel.Size = new System.Drawing.Size(0, 29);
            this.kusurLabel.TabIndex = 21;
            // 
            // policijaLabel
            // 
            this.policijaLabel.AutoSize = true;
            this.policijaLabel.BackColor = System.Drawing.Color.Transparent;
            this.policijaLabel.ForeColor = System.Drawing.Color.Red;
            this.policijaLabel.Location = new System.Drawing.Point(52, 567);
            this.policijaLabel.Name = "policijaLabel";
            this.policijaLabel.Size = new System.Drawing.Size(309, 29);
            this.policijaLabel.TabIndex = 23;
            this.policijaLabel.Text = "Vozilo je prekoračilo brzinu!";
            // 
            // FizickaNaplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 663);
            this.Controls.Add(this.policijaLabel);
            this.Controls.Add(this.kusurLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uplacenoTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iznosLabel);
            this.Controls.Add(this.mestoUlaskaCBox);
            this.Controls.Add(this.ucitajBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rsd);
            this.Controls.Add(this.eur);
            this.Controls.Add(this.tipVozilaCBox);
            this.Controls.Add(this.vremeTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabliceTBox);
            this.Controls.Add(this.Vreme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FizickaNaplata";
            this.Text = "FizickaNaplata";
            this.Load += new System.EventHandler(this.FizickaNaplata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vreme;
        private System.Windows.Forms.TextBox tabliceTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vremeTBox;
        private System.Windows.Forms.ComboBox tipVozilaCBox;
        private System.Windows.Forms.RadioButton eur;
        private System.Windows.Forms.RadioButton rsd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ucitajBtn;
        private System.Windows.Forms.ComboBox mestoUlaskaCBox;
        private System.Windows.Forms.Label iznosLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uplacenoTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label kusurLabel;
        private System.Windows.Forms.Label policijaLabel;
    }
}