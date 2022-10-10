
namespace CrudPessoa
{
    partial class Form1
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
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.Label();
            this.txtboxIdade = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxMae = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(226, 92);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(218, 20);
            this.txtBoxNome.TabIndex = 1;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtBoxNome_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(185, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(35, 13);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            this.txtNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.AutoSize = true;
            this.txtIdade.Location = new System.Drawing.Point(186, 121);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(34, 13);
            this.txtIdade.TabIndex = 5;
            this.txtIdade.Text = "Idade";
            // 
            // txtboxIdade
            // 
            this.txtboxIdade.Location = new System.Drawing.Point(226, 118);
            this.txtboxIdade.Name = "txtboxIdade";
            this.txtboxIdade.Size = new System.Drawing.Size(218, 20);
            this.txtboxIdade.TabIndex = 4;
            this.txtboxIdade.TextChanged += new System.EventHandler(this.txtboxIdade_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(297, 170);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "pesquisa ";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.Location = new System.Drawing.Point(378, 170);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(66, 23);
            this.btnDeleta.TabIndex = 6;
            this.btnDeleta.Text = "deleta";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome da mae";
            // 
            // txtboxMae
            // 
            this.txtboxMae.Location = new System.Drawing.Point(226, 144);
            this.txtboxMae.Name = "txtboxMae";
            this.txtboxMae.Size = new System.Drawing.Size(218, 20);
            this.txtboxMae.TabIndex = 7;
            this.txtboxMae.TextChanged += new System.EventHandler(this.txtboxMae_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(226, 170);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "salva";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxMae);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtboxIdade);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtIdade;
        private System.Windows.Forms.TextBox txtboxIdade;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxMae;
        private System.Windows.Forms.Button btnSalvar;
    }
}

