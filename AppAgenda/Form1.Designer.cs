namespace AppAgenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Button GetBtnEditar()
        {
            return btnEditar;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnSalvar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblTelefone = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            txtTelefone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvCadastros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.Location = new Point(50, 193);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 50);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(252, 18);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 1;
            label1.Text = "Agenda 2.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtNome.Location = new Point(50, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 34);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(50, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(166, 28);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome Completo";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefone.Location = new Point(410, 83);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(93, 28);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(191, 193);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 50);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(332, 193);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(115, 50);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnListar.Location = new Point(473, 193);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(115, 50);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtTelefone.Location = new Point(410, 114);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(178, 34);
            txtTelefone.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(607, 377);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 10;
            label2.Text = "cervantes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(661, 414);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 11;
            label3.Text = "//tecnologia";
            // 
            // dgvCadastros
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvCadastros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCadastros.BackgroundColor = Color.OrangeRed;
            dgvCadastros.BorderStyle = BorderStyle.None;
            dgvCadastros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOrange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCadastros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCadastros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCadastros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCadastros.EnableHeadersVisualStyles = false;
            dgvCadastros.Location = new Point(50, 274);
            dgvCadastros.Name = "dgvCadastros";
            dgvCadastros.RowHeadersWidth = 51;
            dgvCadastros.RowTemplate.Height = 30;
            dgvCadastros.Size = new Size(538, 170);
            dgvCadastros.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(776, 479);
            Controls.Add(dgvCadastros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefone);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label label1;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTelefone;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListar;
        private TextBox txtTelefone;
        private Label label2;
        private Label label3;
        private DataGridView dgvCadastros;
    }
}
