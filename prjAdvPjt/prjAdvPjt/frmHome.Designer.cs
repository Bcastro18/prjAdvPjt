namespace prjAdvPjt
{
    partial class frmHome
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
            this.btnCadastra = new System.Windows.Forms.Button();
            this.dgvListaTodosClientes = new System.Windows.Forms.DataGridView();
            this.btnAtual = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCli2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTodosClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(24, 175);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(213, 84);
            this.btnCadastra.TabIndex = 0;
            this.btnCadastra.Text = "Cadastrar Cliente/Processo";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // dgvListaTodosClientes
            // 
            this.dgvListaTodosClientes.AllowUserToAddRows = false;
            this.dgvListaTodosClientes.AllowUserToDeleteRows = false;
            this.dgvListaTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTodosClientes.Location = new System.Drawing.Point(243, 23);
            this.dgvListaTodosClientes.Name = "dgvListaTodosClientes";
            this.dgvListaTodosClientes.ReadOnly = true;
            this.dgvListaTodosClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTodosClientes.Size = new System.Drawing.Size(639, 225);
            this.dgvListaTodosClientes.TabIndex = 1;
            this.dgvListaTodosClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTodosClientes_CellContentDoubleClick);
            // 
            // btnAtual
            // 
            this.btnAtual.Location = new System.Drawing.Point(536, 263);
            this.btnAtual.Name = "btnAtual";
            this.btnAtual.Size = new System.Drawing.Size(75, 23);
            this.btnAtual.TabIndex = 2;
            this.btnAtual.Text = "Atualiza";
            this.btnAtual.UseVisualStyleBackColor = true;
            this.btnAtual.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(299, 171);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(75, 23);
            this.btnAtualiza.TabIndex = 2;
            this.btnAtualiza.Text = "Atualiza";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(130, 265);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(24, 267);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(100, 20);
            this.txtExcluir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos os clientes:";
            // 
            // dgvCli2
            // 
            this.dgvCli2.AllowUserToAddRows = false;
            this.dgvCli2.AllowUserToDeleteRows = false;
            this.dgvCli2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli2.Location = new System.Drawing.Point(243, 305);
            this.dgvCli2.Name = "dgvCli2";
            this.dgvCli2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli2.Size = new System.Drawing.Size(639, 203);
            this.dgvCli2.TabIndex = 6;
            this.dgvCli2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCli2_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clientes não atualizados hoje:";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(893, 519);
            this.Controls.Add(this.dgvCli2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtual);
            this.Controls.Add(this.dgvListaTodosClientes);
            this.Controls.Add(this.btnCadastra);
            this.Name = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTodosClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.DataGridView dgvListaTodosClientes;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnAtual;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCli2;
        private System.Windows.Forms.Label label2;
    }
}

