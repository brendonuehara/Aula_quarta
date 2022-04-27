namespace Projeto_Viagem
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
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbKm = new System.Windows.Forms.Label();
            this.lbKmL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDistancia.Location = new System.Drawing.Point(43, 48);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(158, 20);
            this.lbDistancia.TabIndex = 0;
            this.lbDistancia.Text = "Distância percorrida: ";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsumo.Location = new System.Drawing.Point(43, 94);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(202, 20);
            this.lbConsumo.TabIndex = 1;
            this.lbConsumo.Text = "Consumo média do veículo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCombustivel.Location = new System.Drawing.Point(43, 140);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(235, 20);
            this.lbCombustivel.TabIndex = 2;
            this.lbCombustivel.Text = "Valor do Combustível:             R$";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(283, 48);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(50, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(283, 94);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(50, 20);
            this.txtConsumo.TabIndex = 4;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(283, 140);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(50, 20);
            this.txtCombustivel.TabIndex = 5;
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.BackColor = System.Drawing.Color.Transparent;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPedagio.Location = new System.Drawing.Point(43, 236);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(234, 20);
            this.lbPedagio.TabIndex = 6;
            this.lbPedagio.Text = "Valor gastos com pedágios:  R$";
            this.lbPedagio.Visible = false;
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.BackColor = System.Drawing.Color.Transparent;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckGastoPedagio.Location = new System.Drawing.Point(47, 186);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(221, 24);
            this.ckGastoPedagio.TabIndex = 7;
            this.ckGastoPedagio.Text = "Houve gastos com pedágio";
            this.ckGastoPedagio.UseVisualStyleBackColor = false;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPedagio
            // 
            this.txtPedagio.Location = new System.Drawing.Point(283, 236);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(50, 20);
            this.txtPedagio.TabIndex = 8;
            this.txtPedagio.Visible = false;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Silver;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(47, 301);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(286, 46);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular Gastos";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.BackColor = System.Drawing.Color.Transparent;
            this.lbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbKm.Location = new System.Drawing.Point(339, 53);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(32, 20);
            this.lbKm.TabIndex = 10;
            this.lbKm.Text = "Km";
            // 
            // lbKmL
            // 
            this.lbKmL.AutoSize = true;
            this.lbKmL.BackColor = System.Drawing.Color.Transparent;
            this.lbKmL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKmL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbKmL.Location = new System.Drawing.Point(339, 99);
            this.lbKmL.Name = "lbKmL";
            this.lbKmL.Size = new System.Drawing.Size(45, 20);
            this.lbKmL.TabIndex = 11;
            this.lbKmL.Text = "Km/L";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(402, 418);
            this.Controls.Add(this.lbKmL);
            this.Controls.Add(this.lbKm);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gasto da viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.Label lbKmL;
    }
}

