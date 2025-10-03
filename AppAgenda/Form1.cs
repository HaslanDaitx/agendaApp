using Npgsql;
using System.Data;

namespace AppAgenda
{
    public partial class Form1 : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=SUA_SENHA;Database=agenda_2.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "INSERT INTO cadastro (nome, telefone) VALUES (@nome, @telefone)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("telefone", long.Parse(txtTelefone.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            Listar();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE cadastro SET nome = @nome WHERE telefone = @telefone";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("telefone", long.Parse(txtTelefone.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            Listar();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM cadastro WHERE telefone = @telefone";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("telefone", long.Parse(txtTelefone.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            Listar();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            string sql = "SELECT nome AS \"Nome\", telefone AS \"Telefone\" FROM cadastro ORDER BY nome";

            using (var conn = new NpgsqlConnection(connString))
            {
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCadastros.DataSource = dt;
                }
            }

            txtNome.Clear();
            txtTelefone.Clear();
        }
    }
}

