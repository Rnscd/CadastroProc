using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamaProc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=DESKTOP-F46QBIG;Initial Catalog=Procs;Integrated Security=True";
            string Query = "sp_tb01_01";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            DataTable MinhaTabela = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;

            conexao.Open();

            MinhaTabela.Load(comando.ExecuteReader());



            dataGridView1.DataSource = MinhaTabela;

            conexao.Close();
        }

        private void BtnChamaProc2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(TxtID.Text);
            
            string strConexao = "Data Source=DESKTOP-F46QBIG;Initial Catalog=Procs;Integrated Security=True";
            string Query = "sp_tb01_02";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            DataTable MinhaTabela = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)).Value = ID;
            conexao.Open();

            MinhaTabela.Load(comando.ExecuteReader());



            dataGridView1.DataSource = MinhaTabela;

            conexao.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarNomeNovo_Click(object sender, EventArgs e)
        {
            double Salario = Convert.ToDouble(TxtSalario.Text, 
                CultureInfo.InvariantCulture);
                
            String Nome = TxtNome.Text;


            string strConexao = "Data Source=DESKTOP-F46QBIG;Initial Catalog=Procs;Integrated Security=True";
            string Query = "sp_tb01_03";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            DataTable MinhaTabela = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = Nome;
            comando.Parameters.Add(new SqlParameter("@Salario", SqlDbType.Float)).Value = Salario;
            
            conexao.Open();

            comando.ExecuteNonQuery();
            
            conexao.Close();
        }
    }
}
