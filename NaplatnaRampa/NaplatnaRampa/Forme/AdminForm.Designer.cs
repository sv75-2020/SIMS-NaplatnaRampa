
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
            this.SuspendLayout();
            // 
            // napraviStanicu_btn
            // 
            this.napraviStanicu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.napraviStanicu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napraviStanicu_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.napraviStanicu_btn.Location = new System.Drawing.Point(13, 131);
            this.napraviStanicu_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.napraviStanicu_btn.Name = "napraviStanicu_btn";
            this.napraviStanicu_btn.Size = new System.Drawing.Size(306, 100);
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
            this.ADMIN.Location = new System.Drawing.Point(-1, 21);
            this.ADMIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(267, 82);
            this.ADMIN.TabIndex = 2;
            this.ADMIN.Text = "ADMIN";
            this.ADMIN.UseWaitCursor = true;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(23, 496);
            this.logOut_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(306, 100);
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
            this.obrisiStanicu_btn.Location = new System.Drawing.Point(13, 263);
            this.obrisiStanicu_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.obrisiStanicu_btn.Name = "obrisiStanicu_btn";
            this.obrisiStanicu_btn.Size = new System.Drawing.Size(306, 100);
            this.obrisiStanicu_btn.TabIndex = 4;
            this.obrisiStanicu_btn.Text = "Obrisi naplatnu stanicu";
            this.obrisiStanicu_btn.UseVisualStyleBackColor = false;
            this.obrisiStanicu_btn.UseWaitCursor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 663);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.obrisiStanicu_btn);
            this.Controls.Add(this.napraviStanicu_btn);
            this.Controls.Add(this.ADMIN);
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
    }
}