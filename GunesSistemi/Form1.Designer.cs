namespace GunesSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGokCisimleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGokCisimleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGokCisimleri
            // 
            this.dgvGokCisimleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGokCisimleri.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGokCisimleri.Location = new System.Drawing.Point(48, 12);
            this.dgvGokCisimleri.MultiSelect = false;
            this.dgvGokCisimleri.Name = "dgvGokCisimleri";
            this.dgvGokCisimleri.RowTemplate.Height = 25;
            this.dgvGokCisimleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGokCisimleri.Size = new System.Drawing.Size(668, 201);
            this.dgvGokCisimleri.TabIndex = 0;
            this.dgvGokCisimleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGokCisimleri_CellClick);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGokCisimleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGokCisimleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvGokCisimleri;
    }
}