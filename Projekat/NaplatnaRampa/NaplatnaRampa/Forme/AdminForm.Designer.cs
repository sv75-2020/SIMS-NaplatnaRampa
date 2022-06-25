
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
            this.ADMIN = new System.Windows.Forms.Label();
            this.napraviStanicu_btn = new System.Windows.Forms.Button();
            this.obrisiStanicu_btn = new System.Windows.Forms.Button();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(2, 9);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(179, 55);
            this.ADMIN.TabIndex = 0;
            this.ADMIN.Text = "ADMIN";
            // 
            // napraviStanicu_btn
            // 
            this.napraviStanicu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.napraviStanicu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napraviStanicu_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.napraviStanicu_btn.Location = new System.Drawing.Point(21, 148);
            this.napraviStanicu_btn.Name = "napraviStanicu_btn";
            this.napraviStanicu_btn.Size = new System.Drawing.Size(204, 65);
            this.napraviStanicu_btn.TabIndex = 1;
            this.napraviStanicu_btn.Text = "Napravi naplatnu stanicu";
            this.napraviStanicu_btn.UseVisualStyleBackColor = false;
            this.napraviStanicu_btn.Click += new System.EventHandler(this.napraviStanicu_btn_Click);
            // 
            // obrisiStanicu_btn
            // 
            this.obrisiStanicu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.obrisiStanicu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiStanicu_btn.Location = new System.Drawing.Point(21, 267);
            this.obrisiStanicu_btn.Name = "obrisiStanicu_btn";
            this.obrisiStanicu_btn.Size = new System.Drawing.Size(204, 65);
            this.obrisiStanicu_btn.TabIndex = 2;
            this.obrisiStanicu_btn.Text = "Obrisi naplatnu stanicu";
            this.obrisiStanicu_btn.UseVisualStyleBackColor = false;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(21, 556);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(204, 65);
            this.logOut_btn.TabIndex = 3;
            this.logOut_btn.Text = "Izloguj se";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1313, 633);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.obrisiStanicu_btn);
            this.Controls.Add(this.napraviStanicu_btn);
            this.Controls.Add(this.ADMIN);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ADMIN;
        private System.Windows.Forms.Button napraviStanicu_btn;
        private System.Windows.Forms.Button obrisiStanicu_btn;
        private System.Windows.Forms.Button logOut_btn;
    }
}