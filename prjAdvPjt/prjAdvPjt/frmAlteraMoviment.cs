using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdvPjt
{
    public partial class frmAlteraMoviment : Form
    {
        private SqlConnection connection;
        public frmAlteraMoviment()
        {
            InitializeComponent();
        }
        public frmAlteraMoviment(int id)
        {
            InitializeComponent();
            preencheCampos(id);
        }

        private void preencheCampos(int id)
        {
            CliPro cp = SelectBusca(id);
            txtId.Text = cp.id.ToString();
            txtNome.Text = cp.nome;
            txtProcesso.Text = cp.processo;
            txtVara.Text = cp.vara;
            txtClasse.Text = cp.classe;
            txtData.Text = cp.data.ToString();
            txtAssunto.Text = cp.assunto;
            txtOAssuntos.Text = cp.oAssuntos;
            txtDist.Text = cp.distrib;
            txtControle.Text = cp.controle;
            txtJuiz.Text = cp.juiz;
            txtValor.Text = cp.valor.ToString();
            txtExeqte.Text = cp.exeqte;
            txtExectdo.Text = cp.exectdo;
            txtAdvExeqte.Text = cp.advExeqte;
            txtMoviment.Text = cp.moviment;
        }

        private CliPro SelectBusca(int id)
        {
            CliPro cli = new CliPro(id);

            //instância da conexão 
            string connectionString;
            connectionString = ConfigurationSettings.AppSettings["connectionString"];
            connection = new SqlConnection(connectionString);
            string sql = "SELECT * from cliPro WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", id);
            connection.Open();
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                cli.id = Convert.ToInt32(leitor["id"].ToString());
                cli.nome = leitor["nome"].ToString();
                cli.processo = leitor["processo"].ToString();
                cli.vara = leitor["vara"].ToString(); 
                cli.data = Convert.ToDateTime(leitor["ultAtual"].ToString());
                cli.classe = leitor["classe"].ToString();
                cli.assunto = leitor["assunto"].ToString();
                cli.oAssuntos = leitor["oAss"].ToString();
                cli.distrib = leitor["dist"].ToString();
                cli.controle = leitor["controle"].ToString();
                cli.juiz = leitor["juiz"].ToString();
                cli.valor = Convert.ToDouble(leitor["valor"].ToString());
                cli.exeqte = leitor["exeqte"].ToString();
                cli.advExeqte = leitor["advExeqte"].ToString();
                cli.exectdo = leitor["exectdo"].ToString();
                cli.moviment = leitor["moviment"].ToString();
            }
            connection.Close();
            return cli;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CliPro cp = new CliPro();
            DBConnect db = new DBConnect();
      
            cp.id = Convert.ToInt32(txtId.Text);
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
                string q = "UPDATE cliPro SET nome='" + cp.nome.ToString() + "', processo='" + cp.processo.ToString() + "', vara='" + cp.vara.ToString() + "', ultAtual=GETDATE(), classe='" + cp.classe.ToString() + "', assunto='" + cp.assunto.ToString() + "', oAss='" + cp.oAssuntos.ToString() + "', dist='" + cp.distrib.ToString() + "', controle='" + cp.controle.ToString() + "', juiz='" + cp.juiz.ToString() + "', valor='" + cp.valor.ToString() + "', exeqte='" + cp.exeqte.ToString() + "', advExeqte='" + cp.advExeqte.ToString() + "', exectdo='" + cp.exectdo.ToString() + "', moviment='" + cp.moviment.ToString() + "' WHERE id=" + cp.id.ToString() + ";";
                db.Update(q);
            } catch(Exception ex)
            {
                MessageBox.Show("ERRO - FRMALTERAMOVIMENTO: " + ex.ToString());
            }
            //frmHome.cps.Add(cp);
            MessageBox.Show("Salvo com sucesso!");
            this.Close();
        }
    }
}
