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
    public partial class frmHome : Form
    {
        private BindingSource bgs = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        private BindingSource bgs2 = new BindingSource();
        private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
        public static List<CliPro> cps = new List<CliPro>();
        public frmHome()
        {
            InitializeComponent();
            Atualiza();
            AtualizaDGV2();
        }
        
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            frmCliPro fcp = new frmCliPro();
            fcp.Show();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            Atualiza();
            AtualizaDGV2();
        }

        private void Atualiza()
        {
            dgvListaTodosClientes.DataSource = bgs;
            String connectionString =
                ConfigurationSettings.AppSettings["connectionString"];
            dataAdapter = new SqlDataAdapter("select * from cliPro", connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            bgs.DataSource = table;
        }
        private void AtualizaDGV2()
        {

            dgvCli2.DataSource = bgs2;
            String connectionString =
                ConfigurationSettings.AppSettings["connectionString"];
            dataAdapter2 = new SqlDataAdapter("select * from clipro where DATEDIFF(dd, ultAtual, GETDATE()) > 0", connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter2);

            DataTable table2 = new DataTable();
            table2.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter2.Fill(table2);
            bgs2.DataSource = table2;

        }

        private void dgvListaTodosClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvListaTodosClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmAlteraMoviment fa = new frmAlteraMoviment(id);
            fa.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtExcluir.Text != "")
            {
                int id = Convert.ToInt32(txtExcluir.Text);

                DialogResult dialogResult = MessageBox.Show("Deseja mesmo excluir?", "Excluir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DBConnect db = new DBConnect();
                        string query = "DELETE FROM cliPro WHERE id=" + id.ToString() + ";";
                        db.Delete(query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                    MessageBox.Show("Excluído com sucesso!");
                    txtExcluir.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    ;
                }
            } else
            {
                MessageBox.Show("O campo deve conter um valor ID válido!");
            }
        }

        private void dgvCli2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvListaTodosClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmAlteraMoviment fa = new frmAlteraMoviment(id);
            fa.Show();
        }
    }
}
