using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjAdvPjt
{
    public partial class frmCliPro : Form
    {
        public frmCliPro()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CliPro cp = new CliPro();
            DBConnect dp = new DBConnect();
            cp.nome = txtNome.Text;
            cp.processo = txtProcesso.Text;
            cp.vara = txtVara.Text;
            cp.classe = txtClasse.Text;
            cp.data = DateTime.Today;
            cp.assunto = txtAssunto.Text;
            cp.oAssuntos = txtOAssuntos.Text;
            cp.distrib = txtDist.Text;
            cp.controle = txtControle.Text;
            cp.juiz = txtJuiz.Text;
            cp.valor = Convert.ToDouble(txtValor.Text);
            cp.exeqte = txtExeqte.Text;
            cp.exectdo = txtExectdo.Text;
            cp.advExeqte = txtAdvExeqte.Text;
            cp.moviment = txtMoviment.Text;
            try
            {
                string query = "INSERT INTO cliPro (nome, processo, vara, ultAtual, classe, assunto, oAss, dist, controle, juiz, valor, exeqte, advExeqte, exectdo, moviment) VALUES('" + cp.nome + "', '" + cp.processo + "', '" + cp.vara + "', GETDATE(), '" + cp.classe.ToString() + "', '" + cp.assunto.ToString() + "', '" + cp.oAssuntos.ToString() + "', '" + cp.distrib.ToString() + "', '" + cp.controle.ToString() + "', '" + cp.juiz.ToString() + "', '" + cp.valor.ToString() + "', '" + cp.exeqte.ToString() + "', '" + cp.advExeqte.ToString() + "', '" + cp.exectdo.ToString() + "', '" + cp.moviment.ToString() + "');";
                dp.Insert(query);
                //frmHome.cps.Add(cp);
            } catch(Exception ecc)
            {
                MessageBox.Show("Erro na inserção dos dados - FRMCLIPROINSERT " + ecc.ToString());
            }
            MessageBox.Show("Cadastrado!");
            LimpaCampos();

        }
        private void LimpaCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtProcesso.Text = "";
            txtVara.Text = "";
            txtClasse.Text = "";
            txtData.Text = "";
            txtAssunto.Text = "";
            txtOAssuntos.Text = "";
            txtDist.Text = "";
            txtControle.Text = "";
            txtJuiz.Text = "";
            txtValor.Text = "";
            txtExeqte.Text = "";
            txtExectdo.Text = "";
            txtAdvExeqte.Text = "";
            txtMoviment.Text = "";
        }
    }
}
