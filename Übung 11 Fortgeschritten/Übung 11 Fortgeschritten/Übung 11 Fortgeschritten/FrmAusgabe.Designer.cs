namespace Übung_11_Fortgeschritten
{
    partial class FrmAusgabe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAusgabe = new System.Windows.Forms.DataGridView();
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txbKnotenpunkt = new System.Windows.Forms.TextBox();
            this.lblKnotenpunkt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAusgabe
            // 
            this.dgvAusgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAusgabe.Location = new System.Drawing.Point(2, 236);
            this.dgvAusgabe.Name = "dgvAusgabe";
            this.dgvAusgabe.Size = new System.Drawing.Size(795, 202);
            this.dgvAusgabe.TabIndex = 0;
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.Location = new System.Drawing.Point(306, 181);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(122, 33);
            this.btnAusgabe.TabIndex = 1;
            this.btnAusgabe.Text = "Zeig mich an!";
            this.btnAusgabe.UseVisualStyleBackColor = true;
            this.btnAusgabe.Click += new System.EventHandler(this.BtnAusgabe_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(306, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(122, 30);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Datei auswählen...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txbKnotenpunkt
            // 
            this.txbKnotenpunkt.Location = new System.Drawing.Point(306, 111);
            this.txbKnotenpunkt.Name = "txbKnotenpunkt";
            this.txbKnotenpunkt.Size = new System.Drawing.Size(122, 20);
            this.txbKnotenpunkt.TabIndex = 3;
            // 
            // lblKnotenpunkt
            // 
            this.lblKnotenpunkt.AutoSize = true;
            this.lblKnotenpunkt.Location = new System.Drawing.Point(306, 92);
            this.lblKnotenpunkt.Name = "lblKnotenpunkt";
            this.lblKnotenpunkt.Size = new System.Drawing.Size(68, 13);
            this.lblKnotenpunkt.TabIndex = 4;
            this.lblKnotenpunkt.Text = "Knotenpunkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "z.b \"Song\"";
            // 
            // FrmAusgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKnotenpunkt);
            this.Controls.Add(this.txbKnotenpunkt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAusgabe);
            this.Controls.Add(this.dgvAusgabe);
            this.Name = "FrmAusgabe";
            this.Text = "Ausgabe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusgabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAusgabe;
        private System.Windows.Forms.Button btnAusgabe;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txbKnotenpunkt;
        private System.Windows.Forms.Label lblKnotenpunkt;
        private System.Windows.Forms.Label label1;
    }
}

