
namespace ProjetoAtendimento
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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.labelSenhas = new System.Windows.Forms.ListBox();
            this.buttonListSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.buttonAddGuiche = new System.Windows.Forms.Button();
            this.buttonListaAtendimentos = new System.Windows.Forms.Button();
            this.labelAtendimentos = new System.Windows.Forms.ListBox();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(64, 33);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(84, 23);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // labelSenhas
            // 
            this.labelSenhas.FormattingEnabled = true;
            this.labelSenhas.Location = new System.Drawing.Point(12, 62);
            this.labelSenhas.Name = "labelSenhas";
            this.labelSenhas.Size = new System.Drawing.Size(199, 225);
            this.labelSenhas.TabIndex = 1;
            // 
            // buttonListSenhas
            // 
            this.buttonListSenhas.Location = new System.Drawing.Point(64, 293);
            this.buttonListSenhas.Name = "buttonListSenhas";
            this.buttonListSenhas.Size = new System.Drawing.Size(97, 23);
            this.buttonListSenhas.TabIndex = 2;
            this.buttonListSenhas.Text = "Listar Senhas";
            this.buttonListSenhas.UseVisualStyleBackColor = true;
            this.buttonListSenhas.Click += new System.EventHandler(this.buttonListSenhas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(238, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtd Guichês";
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblQtdGuiches.Location = new System.Drawing.Point(270, 150);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(32, 36);
            this.lblQtdGuiches.TabIndex = 4;
            this.lblQtdGuiches.Text = "0";
            // 
            // buttonAddGuiche
            // 
            this.buttonAddGuiche.Location = new System.Drawing.Point(242, 219);
            this.buttonAddGuiche.Name = "buttonAddGuiche";
            this.buttonAddGuiche.Size = new System.Drawing.Size(84, 23);
            this.buttonAddGuiche.TabIndex = 5;
            this.buttonAddGuiche.Text = "Adicionar";
            this.buttonAddGuiche.UseVisualStyleBackColor = true;
            this.buttonAddGuiche.Click += new System.EventHandler(this.buttonAddGuiche_Click);
            // 
            // buttonListaAtendimentos
            // 
            this.buttonListaAtendimentos.Location = new System.Drawing.Point(423, 293);
            this.buttonListaAtendimentos.Name = "buttonListaAtendimentos";
            this.buttonListaAtendimentos.Size = new System.Drawing.Size(185, 23);
            this.buttonListaAtendimentos.TabIndex = 8;
            this.buttonListaAtendimentos.Text = "Listar Atendimentos";
            this.buttonListaAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListaAtendimentos.Click += new System.EventHandler(this.buttonListaAtendimentos_Click);
            // 
            // labelAtendimentos
            // 
            this.labelAtendimentos.FormattingEnabled = true;
            this.labelAtendimentos.Location = new System.Drawing.Point(357, 62);
            this.labelAtendimentos.Name = "labelAtendimentos";
            this.labelAtendimentos.Size = new System.Drawing.Size(431, 225);
            this.labelAtendimentos.TabIndex = 7;
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(585, 33);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(84, 23);
            this.buttonChamar.TabIndex = 6;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guiche:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(432, 33);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(137, 20);
            this.txtGuiche.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonListaAtendimentos);
            this.Controls.Add(this.labelAtendimentos);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.buttonAddGuiche);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListSenhas);
            this.Controls.Add(this.labelSenhas);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.ListBox labelSenhas;
        private System.Windows.Forms.Button buttonListSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.Button buttonAddGuiche;
        private System.Windows.Forms.Button buttonListaAtendimentos;
        private System.Windows.Forms.ListBox labelAtendimentos;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuiche;
        #region Código gerado pelo Windows Form Designer
    }
}

#endregion