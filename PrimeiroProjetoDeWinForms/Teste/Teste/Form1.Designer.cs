namespace Teste
{
    partial class MeuPrimeiroForm
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
            this.nome = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(44, 63);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(97, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Informe seu nome: ";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btConfirm.Location = new System.Drawing.Point(47, 98);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(371, 41);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtClear.Location = new System.Drawing.Point(47, 243);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(371, 28);
            this.BtClear.TabIndex = 3;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(147, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(271, 20);
            this.textName.TabIndex = 4;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(44, 193);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(25, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "------";
            // 
            // MeuPrimeiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.nome);
            this.Name = "MeuPrimeiroForm";
            this.Text = "Meu Primeiro Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lbResultado;
    }
}

