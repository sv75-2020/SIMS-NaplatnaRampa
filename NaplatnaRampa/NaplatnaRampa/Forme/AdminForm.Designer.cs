
namespace NaplatnaRampa.Forme
{
    partial class AdminForm
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
            this.napraviStanicu_btn = new System.Windows.Forms.Button();
            this.ADMIN = new System.Windows.Forms.Label();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.obrisiStanicu_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.zarada_stanica_btn = new System.Windows.Forms.Button();
            this.cenovnik = new System.Windows.Forms.Button();
            this.izvestaj = new System.Windows.Forms.Label();
            this.manageMesta_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // napraviStanicu_btn
            // 
            this.napraviStanicu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.napraviStanicu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napraviStanicu_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.napraviStanicu_btn.Location = new System.Drawing.Point(15, 99);
            this.napraviStanicu_btn.Name = "napraviStanicu_btn";
            this.napraviStanicu_btn.Size = new System.Drawing.Size(165, 65);
            this.napraviStanicu_btn.TabIndex = 3;
            this.napraviStanicu_btn.Text = "Napravi naplatnu stanicu";
            this.napraviStanicu_btn.UseVisualStyleBackColor = false;
            this.napraviStanicu_btn.UseWaitCursor = true;
            this.napraviStanicu_btn.Click += new System.EventHandler(this.napraviStanicu_btn_Click);
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(-1, 14);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(179, 55);
            this.ADMIN.TabIndex = 2;
            this.ADMIN.Text = "ADMIN";
            this.ADMIN.UseWaitCursor = true;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(15, 354);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(165, 65);
            this.logOut_btn.TabIndex = 5;
            this.logOut_btn.Text = "Izloguj se";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.UseWaitCursor = true;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // obrisiStanicu_btn
            // 
            this.obrisiStanicu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.obrisiStanicu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiStanicu_btn.Location = new System.Drawing.Point(15, 171);
            this.obrisiStanicu_btn.Name = "obrisiStanicu_btn";
            this.obrisiStanicu_btn.Size = new System.Drawing.Size(165, 65);
            this.obrisiStanicu_btn.TabIndex = 4;
            this.obrisiStanicu_btn.Text = "Obrisi naplatnu stanicu";
            this.obrisiStanicu_btn.UseVisualStyleBackColor = false;
            this.obrisiStanicu_btn.UseWaitCursor = true;
            this.obrisiStanicu_btn.Click += new System.EventHandler(this.obrisiStanicu_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Do:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Od:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(596, 112);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(165, 24);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 112);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 24);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // zarada_stanica_btn
            // 
            this.zarada_stanica_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zarada_stanica_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zarada_stanica_btn.Location = new System.Drawing.Point(403, 171);
            this.zarada_stanica_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zarada_stanica_btn.Name = "zarada_stanica_btn";
            this.zarada_stanica_btn.Size = new System.Drawing.Size(165, 65);
            this.zarada_stanica_btn.TabIndex = 6;
            this.zarada_stanica_btn.Text = "Zarada na stanici";
            this.zarada_stanica_btn.UseVisualStyleBackColor = false;
            this.zarada_stanica_btn.Click += new System.EventHandler(this.zarada_stanica_btn_Click);
            // 
            // cenovnik
            // 
            this.cenovnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cenovnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cenovnik.Location = new System.Drawing.Point(596, 171);
            this.cenovnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cenovnik.Name = "cenovnik";
            this.cenovnik.Size = new System.Drawing.Size(165, 65);
            this.cenovnik.TabIndex = 12;
            this.cenovnik.Text = "Cenovnik";
            this.cenovnik.UseVisualStyleBackColor = false;
            this.cenovnik.Click += new System.EventHandler(this.cenovnik_Click);
            // 
            // izvestaj
            // 
            this.izvestaj.AutoSize = true;
            this.izvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izvestaj.Location = new System.Drawing.Point(466, 280);
            this.izvestaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.izvestaj.Name = "izvestaj";
            this.izvestaj.Size = new System.Drawing.Size(0, 25);
            this.izvestaj.TabIndex = 11;
            this.izvestaj.Click += new System.EventHandler(this.izvestaj_Click);
            // 
            // manageMesta_btn
            // 
            this.manageMesta_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.manageMesta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMesta_btn.Location = new System.Drawing.Point(15, 242);
            this.manageMesta_btn.Name = "manageMesta_btn";
            this.manageMesta_btn.Size = new System.Drawing.Size(165, 65);
            this.manageMesta_btn.TabIndex = 13;
            this.manageMesta_btn.Text = "Upravljanje naplatnim mestima";
            this.manageMesta_btn.UseVisualStyleBackColor = false;
            this.manageMesta_btn.UseWaitCursor = true;
            this.manageMesta_btn.Click += new System.EventHandler(this.manageMesta_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 431);
            this.Controls.Add(this.manageMesta_btn);
            this.Controls.Add(this.cenovnik);
            this.Controls.Add(this.izvestaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.zarada_stanica_btn);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.obrisiStanicu_btn);
            this.Controls.Add(this.napraviStanicu_btn);
            this.Controls.Add(this.ADMIN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button napraviStanicu_btn;
        private System.Windows.Forms.Label ADMIN;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Button obrisiStanicu_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button zarada_stanica_btn;
        private System.Windows.Forms.Button cenovnik;
        private System.Windows.Forms.Label izvestaj;
        private System.Windows.Forms.Button manageMesta_btn;
    }
}