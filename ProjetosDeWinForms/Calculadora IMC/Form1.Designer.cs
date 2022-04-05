namespace Calculadora_IMC
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
            this.Peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbCalcularIMC = new System.Windows.Forms.Button();
            this.lbResultadoIMC = new System.Windows.Forms.Label();
            this.lbClassificacaoIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(33, 25);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(127, 18);
            this.Peso.TabIndex = 0;
            this.Peso.Text = "Informe seu peso:";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(30, 52);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(130, 18);
            this.altura.TabIndex = 1;
            this.altura.Text = "Informe sua altura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbCalcularIMC
            // 
            this.lbCalcularIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalcularIMC.Location = new System.Drawing.Point(172, 131);
            this.lbCalcularIMC.Name = "lbCalcularIMC";
            this.lbCalcularIMC.Size = new System.Drawing.Size(100, 31);
            this.lbCalcularIMC.TabIndex = 4;
            this.lbCalcularIMC.Text = "Calcular";
            this.lbCalcularIMC.UseVisualStyleBackColor = true;
            this.lbCalcularIMC.Click += new System.EventHandler(this.lbCalcularIMC_Click);
            // 
            // lbResultadoIMC
            // 
            this.lbResultadoIMC.AutoSize = true;
            this.lbResultadoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoIMC.Location = new System.Drawing.Point(33, 214);
            this.lbResultadoIMC.Name = "lbResultadoIMC";
            this.lbResultadoIMC.Size = new System.Drawing.Size(38, 18);
            this.lbResultadoIMC.TabIndex = 5;
            this.lbResultadoIMC.Text = "------";
            this.lbResultadoIMC.Visible = false;
            // 
            // lbClassificacaoIMC
            // 
            this.lbClassificacaoIMC.AutoSize = true;
            this.lbClassificacaoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacaoIMC.Location = new System.Drawing.Point(180, 218);
            this.lbClassificacaoIMC.Name = "lbClassificacaoIMC";
            this.lbClassificacaoIMC.Size = new System.Drawing.Size(38, 18);
            this.lbClassificacaoIMC.TabIndex = 6;
            this.lbClassificacaoIMC.Text = "------";
            this.lbClassificacaoIMC.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbClassificacaoIMC);
            this.Controls.Add(this.lbResultadoIMC);
            this.Controls.Add(this.lbCalcularIMC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.Peso);
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Button Imc;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button lbCalcularIMC;
        private System.Windows.Forms.Label lbResultadoIMC;
        private System.Windows.Forms.Label lbClassificacaoIMC;
    }
}

