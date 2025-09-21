using Npgsql;
using System.Data;

namespace AppAgenda
{
    public partial class Form1 : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=19032018;Database=agenda_2.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtTelefone.Text))
            {
                // Se estiverem vazios, exibe uma mensagem de aviso.
                MessageBox.Show("Por favor, preencha o nome e o telefone para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método e não executa o restante do código.
            }

            // A validação agora é feita no banco de dados.
            long telefone;

            if (!long.TryParse(txtTelefone.Text, out telefone) || telefone <= 0)
            {
                MessageBox.Show("Digite apenas números positivos no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "INSERT INTO cadastro (nome, telefone) VALUES (@nome, @telefone)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("telefone", telefone);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException ex)
            {
                // Captura o erro do banco de dados e mostra uma mensagem amigável.
                if (ex.SqlState == "23505") // Código de erro para "violação de restrição única"
                {
                    MessageBox.Show("Este telefone já está cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.SqlState == "23502") // Código de erro para "violação de não nulo"
                {
                    MessageBox.Show("O nome e o telefone são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Listar();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            long telefone;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha o nome e o telefone para Editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtTelefone.Text, out telefone) || telefone <= 0)
            {
                MessageBox.Show("Digite apenas números positivos no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "UPDATE cadastro SET nome = @nome WHERE telefone = @telefone";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("telefone", telefone);
                        int linhas = cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registro atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Listar();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // A validação de campo vazio (not null) continua sendo uma boa prática na aplicação.
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha o telefone para Excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM cadastro WHERE telefone = @telefone";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("telefone", long.Parse(txtTelefone.Text));
                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas == 0)
                        {
                            MessageBox.Show("Nenhum registro encontrado com este telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                MessageBox.Show("Registro excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
