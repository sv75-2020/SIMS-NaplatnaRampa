
namespace NaplatnaRampa.Forme
{
    partial class ManageMestaForm
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
            this.napraviMesto_btn = new System.Windows.Forms.Button();
            this.izmeniMesto_btn = new System.Windows.Forms.Button();
            this.obrisiMesto_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.stanica_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPRAVLJANJE NAPLATNIM MESTIMA";
            // 
            // napraviMesto_btn
            // 
            this.napraviMesto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.napraviMesto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napraviMesto_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.napraviMesto_btn.Location = new System.Drawing.Point(568, 101);
            this.napraviMesto_btn.Name = "napraviMesto_btn";
            this.napraviMesto_btn.Size = new System.Drawing.Size(165, 65);
            this.napraviMesto_btn.TabIndex = 4;
            this.napraviMesto_btn.Text = "Napravi naplatno mesto";
            this.napraviMesto_btn.UseVisualStyleBackColor = false;
            this.napraviMesto_btn.UseWaitCursor = true;
            this.napraviMesto_btn.Click += new System.EventHandler(this.napraviMesto_btn_Click);
            // 
            // izmeniMesto_btn
            // 
            this.izmeniMesto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.izmeniMesto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeniMesto_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.izmeniMesto_btn.Location = new System.Drawing.Point(568, 207);
            this.izmeniMesto_btn.Name = "izmeniMesto_btn";
            this.izmeniMesto_btn.Size = new System.Drawing.Size(165, 65);
            this.izmeniMesto_btn.TabIndex = 5;
            this.izmeniMesto_btn.Text = "Izmeni naplatno mesto";
            this.izmeniMesto_btn.UseVisualStyleBackColor = false;
            this.izmeniMesto_btn.UseWaitCursor = true;
            this.izmeniMesto_btn.Click += new System.EventHandler(this.izmeniMesto_btn_Click);
            // 
            // obrisiMesto_btn
            // 
            this.obrisiMesto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.obrisiMesto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiMesto_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obrisiMesto_btn.Location = new System.Drawing.Point(568, 311);
            this.obrisiMesto_btn.Name = "obrisiMesto_btn";
            this.obrisiMesto_btn.Size = new System.Drawing.Size(165, 65);
            this.obrisiMesto_btn.TabIndex = 6;
            this.obrisiMesto_btn.Text = "Obrisi naplatno mesto";
            this.obrisiMesto_btn.UseVisualStyleBackColor = false;
            this.obrisiMesto_btn.UseWaitCursor = true;
            this.obrisiMesto_btn.Click += new System.EventHandler(this.obrisiMesto_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(8, 350);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(181, 69);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Odustani";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // stanica_cb
            // 
            this.stanica_cb.FormattingEnabled = true;
            this.stanica_cb.Location = new System.Drawing.Point(12, 151);
            this.stanica_cb.Name = "stanica_cb";
            this.stanica_cb.Size = new System.Drawing.Size(321, 33);
            this.stanica_cb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Izaberite stanicu:";
            // 
            // ManageMestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stanica_cb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.obrisiMesto_btn);
            this.Controls.Add(this.izmeniMesto_btn);
            this.Controls.Add(this.napraviMesto_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageMestaForm";
            this.Text = "ManageMestaForm";
            this.Load += new System.EventHandler(this.ManageMestaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button napraviMesto_btn;
        private System.Windows.Forms.Button izmeniMesto_btn;
        private System.Windows.Forms.Button obrisiMesto_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox stanica_cb;
        private System.Windows.Forms.Label label2;
    }
}