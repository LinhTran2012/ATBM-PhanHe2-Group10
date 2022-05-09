
namespace ATBM191_10
{
    partial class f_HSBA_DV
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
            this.dgv_hsbadv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbadv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hsbadv
            // 
            this.dgv_hsbadv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hsbadv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsbadv.Location = new System.Drawing.Point(2, -1);
            this.dgv_hsbadv.Name = "dgv_hsbadv";
            this.dgv_hsbadv.RowHeadersWidth = 51;
            this.dgv_hsbadv.RowTemplate.Height = 24;
            this.dgv_hsbadv.Size = new System.Drawing.Size(719, 309);
            this.dgv_hsbadv.TabIndex = 1;
            // 
            // f_HSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 308);
            this.Controls.Add(this.dgv_hsbadv);
            this.Name = "f_HSBA_DV";
            this.Text = "Dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbadv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hsbadv;
    }
}