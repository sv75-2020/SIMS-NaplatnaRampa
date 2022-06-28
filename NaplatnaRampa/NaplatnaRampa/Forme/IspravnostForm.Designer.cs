
namespace NaplatnaRampa.Forme
{
    partial class IspravnostForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.popravi_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(425, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // popravi_btn
            // 
            this.popravi_btn.Location = new System.Drawing.Point(183, 336);
            this.popravi_btn.Name = "popravi_btn";
            this.popravi_btn.Size = new System.Drawing.Size(126, 40);
            this.popravi_btn.TabIndex = 1;
            this.popravi_btn.Text = "Popravi";
            this.popravi_btn.UseVisualStyleBackColor = true;
            this.popravi_btn.Click += new System.EventHandler(this.popravi_btn_Click);
            // 
            // IspravnostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.popravi_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IspravnostForm";
            this.Text = "IspravnostForm";
            this.Load += new System.EventHandler(this.IspravnostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button popravi_btn;
    }
}