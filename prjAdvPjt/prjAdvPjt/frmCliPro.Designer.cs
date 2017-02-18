namespace prjAdvPjt
{
    partial class frmCliPro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtProcesso = new System.Windows.Forms.TextBox();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.txtVara = new System.Windows.Forms.TextBox();
            this.lblVara = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtOAssuntos = new System.Windows.Forms.TextBox();
            this.lblOAssuntos = new System.Windows.Forms.Label();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.txtJuiz = new System.Windows.Forms.TextBox();
            this.lblJuiz = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gpbParteProcesso = new System.Windows.Forms.GroupBox();
            this.lblExecqtdo = new System.Windows.Forms.Label();
            this.lblAdvExeqte = new System.Windows.Forms.Label();
            this.lblExeqte = new System.Windows.Forms.Label();
            this.txtAdvExeqte = new System.Windows.Forms.TextBox();
            this.txtExectdo = new System.Windows.Forms.TextBox();
            this.txtExeqte = new System.Windows.Forms.TextBox();
            this.gpbMovimentações = new System.Windows.Forms.GroupBox();
            this.txtMoviment = new System.Windows.Forms.TextBox();
            this.gpbCliente.SuspendLayout();
            this.gpbParteProcesso.SuspendLayout();
            this.gpbMovimentações.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(288, 472);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(139, 51);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(51, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtProcesso
            // 
            this.txtProcesso.Location = new System.Drawing.Point(108, 122);
            this.txtProcesso.Name = "txtProcesso";
            this.txtProcesso.Size = new System.Drawing.Size(100, 22);
            this.txtProcesso.TabIndex = 2;
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesso.Location = new System.Drawing.Point(33, 128);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(69, 16);
            this.lblProcesso.TabIndex = 4;
            this.lblProcesso.Text = "Processo:";
            // 
            // txtVara
            // 
            this.txtVara.Location = new System.Drawing.Point(108, 150);
            this.txtVara.Name = "txtVara";
            this.txtVara.Size = new System.Drawing.Size(100, 22);
            this.txtVara.TabIndex = 3;
            // 
            // lblVara
            // 
            this.lblVara.AutoSize = true;
            this.lblVara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVara.Location = new System.Drawing.Point(58, 153);
            this.lblVara.Name = "lblVara";
            this.lblVara.Size = new System.Drawing.Size(40, 16);
            this.lblVara.TabIndex = 4;
            this.lblVara.Text = "Vara:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(124, 178);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 22);
            this.txtData.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 184);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(121, 16);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Última atualização:";
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(108, 206);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(100, 22);
            this.txtClasse.TabIndex = 4;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(46, 206);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(53, 16);
            this.lblClasse.TabIndex = 4;
            this.lblClasse.Text = "Classe:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(108, 234);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(100, 22);
            this.txtAssunto.TabIndex = 5;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(39, 237);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(59, 16);
            this.lblAssunto.TabIndex = 4;
            this.lblAssunto.Text = "Assunto:";
            // 
            // txtOAssuntos
            // 
            this.txtOAssuntos.Location = new System.Drawing.Point(108, 262);
            this.txtOAssuntos.Name = "txtOAssuntos";
            this.txtOAssuntos.Size = new System.Drawing.Size(100, 22);
            this.txtOAssuntos.TabIndex = 6;
            // 
            // lblOAssuntos
            // 
            this.lblOAssuntos.AutoSize = true;
            this.lblOAssuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOAssuntos.Location = new System.Drawing.Point(9, 268);
            this.lblOAssuntos.Name = "lblOAssuntos";
            this.lblOAssuntos.Size = new System.Drawing.Size(100, 16);
            this.lblOAssuntos.TabIndex = 4;
            this.lblOAssuntos.Text = "Outros assunto:";
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(108, 290);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 22);
            this.txtDist.TabIndex = 7;
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.Location = new System.Drawing.Point(12, 293);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(82, 16);
            this.lblDist.TabIndex = 4;
            this.lblDist.Text = "Distribuição:";
            // 
            // txtControle
            // 
            this.txtControle.Location = new System.Drawing.Point(108, 320);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(100, 22);
            this.txtControle.TabIndex = 8;
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControle.Location = new System.Drawing.Point(33, 323);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(61, 16);
            this.lblControle.TabIndex = 4;
            this.lblControle.Text = "Controle:";
            // 
            // txtJuiz
            // 
            this.txtJuiz.Location = new System.Drawing.Point(108, 348);
            this.txtJuiz.Name = "txtJuiz";
            this.txtJuiz.Size = new System.Drawing.Size(100, 22);
            this.txtJuiz.TabIndex = 9;
            // 
            // lblJuiz
            // 
            this.lblJuiz.AutoSize = true;
            this.lblJuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuiz.Location = new System.Drawing.Point(60, 351);
            this.lblJuiz.Name = "lblJuiz";
            this.lblJuiz.Size = new System.Drawing.Size(34, 16);
            this.lblJuiz.TabIndex = 4;
            this.lblJuiz.Text = "Juiz:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(108, 374);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 10;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(55, 377);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 16);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.lblId);
            this.gpbCliente.Controls.Add(this.txtId);
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.lblValor);
            this.gpbCliente.Controls.Add(this.lblNome);
            this.gpbCliente.Controls.Add(this.lblJuiz);
            this.gpbCliente.Controls.Add(this.txtProcesso);
            this.gpbCliente.Controls.Add(this.lblControle);
            this.gpbCliente.Controls.Add(this.txtVara);
            this.gpbCliente.Controls.Add(this.lblDist);
            this.gpbCliente.Controls.Add(this.txtData);
            this.gpbCliente.Controls.Add(this.txtValor);
            this.gpbCliente.Controls.Add(this.lblProcesso);
            this.gpbCliente.Controls.Add(this.txtJuiz);
            this.gpbCliente.Controls.Add(this.txtClasse);
            this.gpbCliente.Controls.Add(this.lblOAssuntos);
            this.gpbCliente.Controls.Add(this.lblVara);
            this.gpbCliente.Controls.Add(this.txtControle);
            this.gpbCliente.Controls.Add(this.txtAssunto);
            this.gpbCliente.Controls.Add(this.lblAssunto);
            this.gpbCliente.Controls.Add(this.lblData);
            this.gpbCliente.Controls.Add(this.txtDist);
            this.gpbCliente.Controls.Add(this.txtOAssuntos);
            this.gpbCliente.Controls.Add(this.lblClasse);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(21, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(237, 448);
            this.gpbCliente.TabIndex = 5;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(70, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(108, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 16;
            // 
            // gpbParteProcesso
            // 
            this.gpbParteProcesso.Controls.Add(this.lblExecqtdo);
            this.gpbParteProcesso.Controls.Add(this.lblAdvExeqte);
            this.gpbParteProcesso.Controls.Add(this.lblExeqte);
            this.gpbParteProcesso.Controls.Add(this.txtAdvExeqte);
            this.gpbParteProcesso.Controls.Add(this.txtExectdo);
            this.gpbParteProcesso.Controls.Add(this.txtExeqte);
            this.gpbParteProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParteProcesso.Location = new System.Drawing.Point(288, 12);
            this.gpbParteProcesso.Name = "gpbParteProcesso";
            this.gpbParteProcesso.Size = new System.Drawing.Size(403, 182);
            this.gpbParteProcesso.TabIndex = 6;
            this.gpbParteProcesso.TabStop = false;
            this.gpbParteProcesso.Text = "Partes do Processo:";
            // 
            // lblExecqtdo
            // 
            this.lblExecqtdo.AutoSize = true;
            this.lblExecqtdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecqtdo.Location = new System.Drawing.Point(66, 135);
            this.lblExecqtdo.Name = "lblExecqtdo";
            this.lblExecqtdo.Size = new System.Drawing.Size(60, 16);
            this.lblExecqtdo.TabIndex = 1;
            this.lblExecqtdo.Text = "Exectdo:";
            // 
            // lblAdvExeqte
            // 
            this.lblAdvExeqte.AutoSize = true;
            this.lblAdvExeqte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvExeqte.Location = new System.Drawing.Point(6, 96);
            this.lblAdvExeqte.Name = "lblAdvExeqte";
            this.lblAdvExeqte.Size = new System.Drawing.Size(120, 16);
            this.lblAdvExeqte.TabIndex = 1;
            this.lblAdvExeqte.Text = "Advogado Exeqte:";
            // 
            // lblExeqte
            // 
            this.lblExeqte.AutoSize = true;
            this.lblExeqte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeqte.Location = new System.Drawing.Point(66, 66);
            this.lblExeqte.Name = "lblExeqte";
            this.lblExeqte.Size = new System.Drawing.Size(53, 16);
            this.lblExeqte.TabIndex = 1;
            this.lblExeqte.Text = "Exeqte:";
            // 
            // txtAdvExeqte
            // 
            this.txtAdvExeqte.Location = new System.Drawing.Point(132, 93);
            this.txtAdvExeqte.Name = "txtAdvExeqte";
            this.txtAdvExeqte.Size = new System.Drawing.Size(100, 22);
            this.txtAdvExeqte.TabIndex = 12;
            // 
            // txtExectdo
            // 
            this.txtExectdo.Location = new System.Drawing.Point(132, 132);
            this.txtExectdo.Name = "txtExectdo";
            this.txtExectdo.Size = new System.Drawing.Size(100, 22);
            this.txtExectdo.TabIndex = 13;
            // 
            // txtExeqte
            // 
            this.txtExeqte.Location = new System.Drawing.Point(132, 60);
            this.txtExeqte.Name = "txtExeqte";
            this.txtExeqte.Size = new System.Drawing.Size(100, 22);
            this.txtExeqte.TabIndex = 11;
            // 
            // gpbMovimentações
            // 
            this.gpbMovimentações.Controls.Add(this.txtMoviment);
            this.gpbMovimentações.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMovimentações.Location = new System.Drawing.Point(288, 200);
            this.gpbMovimentações.Name = "gpbMovimentações";
            this.gpbMovimentações.Size = new System.Drawing.Size(403, 266);
            this.gpbMovimentações.TabIndex = 7;
            this.gpbMovimentações.TabStop = false;
            this.gpbMovimentações.Text = "Movimentações:";
            // 
            // txtMoviment
            // 
            this.txtMoviment.Location = new System.Drawing.Point(9, 28);
            this.txtMoviment.Multiline = true;
            this.txtMoviment.Name = "txtMoviment";
            this.txtMoviment.Size = new System.Drawing.Size(379, 232);
            this.txtMoviment.TabIndex = 14;
            // 
            // frmCliPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(703, 535);
            this.Controls.Add(this.gpbMovimentações);
            this.Controls.Add(this.gpbParteProcesso);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCliPro";
            this.Text = "Clientes/Processos";
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbParteProcesso.ResumeLayout(false);
            this.gpbParteProcesso.PerformLayout();
            this.gpbMovimentações.ResumeLayout(false);
            this.gpbMovimentações.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtProcesso;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.TextBox txtVara;
        private System.Windows.Forms.Label lblVara;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtOAssuntos;
        private System.Windows.Forms.Label lblOAssuntos;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.TextBox txtJuiz;
        private System.Windows.Forms.Label lblJuiz;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbParteProcesso;
        private System.Windows.Forms.Label lblExecqtdo;
        private System.Windows.Forms.Label lblExeqte;
        private System.Windows.Forms.TextBox txtExectdo;
        private System.Windows.Forms.TextBox txtExeqte;
        private System.Windows.Forms.Label lblAdvExeqte;
        private System.Windows.Forms.TextBox txtAdvExeqte;
        private System.Windows.Forms.GroupBox gpbMovimentações;
        private System.Windows.Forms.TextBox txtMoviment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}