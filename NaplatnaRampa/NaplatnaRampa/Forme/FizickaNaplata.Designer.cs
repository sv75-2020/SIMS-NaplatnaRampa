
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vremeTBox = new System.Windows.Forms.TextBox();
            this.tipVozilaCBox = new System.Windows.Forms.ComboBox();
            this.eur = new System.Windows.Forms.RadioButton();
            this.rsd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(1017, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 35);
            this.textBox2.TabIndex = 8;
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
            this.button1.Location = new System.Drawing.Point(140, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 84);
            this.button1.TabIndex = 14;
            this.button1.Text = "POTVRDI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FizickaNaplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rsd);
            this.Controls.Add(this.eur);
            this.Controls.Add(this.tipVozilaCBox);
            this.Controls.Add(this.vremeTBox);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox vremeTBox;
        private System.Windows.Forms.ComboBox tipVozilaCBox;
        private System.Windows.Forms.RadioButton eur;
        private System.Windows.Forms.RadioButton rsd;
        private System.Windows.Forms.Button button1;
    }
}