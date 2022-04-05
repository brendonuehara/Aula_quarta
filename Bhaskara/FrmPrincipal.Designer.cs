namespace Bhaskara
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lbzero = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbXP = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx2.Location = new System.Drawing.Point(77, 74);
            this.lbx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(34, 20);
            this.lbx2.TabIndex = 0;
            this.lbx2.Text = "x² +";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.Location = new System.Drawing.Point(173, 74);
            this.lbx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(29, 20);
            this.lbx.TabIndex = 1;
            this.lbx.Text = "x +";
            // 
            // lbzero
            // 
            this.lbzero.AutoSize = true;
            this.lbzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbzero.Location = new System.Drawing.Point(264, 75);
            this.lbzero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbzero.Name = "lbzero";
            this.lbzero.Size = new System.Drawing.Size(31, 20);
            this.lbzero.TabIndex = 2;
            this.lbzero.Text = "= 0";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(23, 68);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(46, 26);
            this.txtA.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(210, 71);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(46, 26);
            this.txt3.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(119, 71);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(46, 26);
            this.txtB.TabIndex = 5;
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Location = new System.Drawing.Point(16, 28);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(438, 20);
            this.lbinfo.TabIndex = 6;
            this.lbinfo.Text = "Informe uma equação quadrádica no formato ax² + 2x + c = 0";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCalcular.Location = new System.Drawing.Point(20, 137);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(275, 27);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Location = new System.Drawing.Point(32, 211);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(51, 20);
            this.lbDelta.TabIndex = 8;
            this.lbDelta.Text = "label1";
            // 
            // lbXP
            // 
            this.lbXP.AutoSize = true;
            this.lbXP.Location = new System.Drawing.Point(32, 249);
            this.lbXP.Name = "lbXP";
            this.lbXP.Size = new System.Drawing.Size(51, 20);
            this.lbXP.TabIndex = 9;
            this.lbXP.Text = "label2";
            // 
            // lbXN
            // 
            this.lbXN.AutoSize = true;
            this.lbXN.Location = new System.Drawing.Point(32, 290);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(51, 20);
            this.lbXN.TabIndex = 10;
            this.lbXN.Text = "label3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbXP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbzero);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lbx2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = "Bhaskara";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lbzero;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbXP;
        private System.Windows.Forms.Label lbXN;
    }
}

