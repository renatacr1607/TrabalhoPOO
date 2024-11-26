namespace ControleLivros
{
    partial class frmLivro
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
            txtTituloLivro = new TextBox();
            lblTituloLivro = new Label();
            lblPrecoLivro = new Label();
            lblQuantidadeLivro = new Label();
            lblLinkDownload = new Label();
            lblTamanhoArquivo = new Label();
            lblNomeEditora = new Label();
            lblEmailEditora = new Label();
            txtPrecoLivro = new TextBox();
            txtQuantidadeLivro = new TextBox();
            txtTamanhoArquivo = new TextBox();
            txtLinkDownload = new TextBox();
            txtNomeEditora = new TextBox();
            txtEmailEditora = new TextBox();
            cmbEditora = new ComboBox();
            lblEditoraDoLivro = new Label();
            dgvLivros = new DataGridView();
            btnAdicionarEditora = new Button();
            btnAdicionarLivro = new Button();
            btnConsultarLivros = new Button();
            lblTitutoEditora = new Label();
            lblNomeLivro = new Label();
            lblLivroDigital = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Location = new Point(322, 58);
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(100, 23);
            txtTituloLivro.TabIndex = 0;
            // 
            // lblTituloLivro
            // 
            lblTituloLivro.AutoSize = true;
            lblTituloLivro.Location = new Point(204, 61);
            lblTituloLivro.Name = "lblTituloLivro";
            lblTituloLivro.Size = new Size(86, 15);
            lblTituloLivro.TabIndex = 1;
            lblTituloLivro.Text = "Título do Livro:";
            // 
            // lblPrecoLivro
            // 
            lblPrecoLivro.AutoSize = true;
            lblPrecoLivro.Location = new Point(236, 113);
            lblPrecoLivro.Name = "lblPrecoLivro";
            lblPrecoLivro.Size = new Size(40, 15);
            lblPrecoLivro.TabIndex = 2;
            lblPrecoLivro.Text = "Preço:";
            // 
            // lblQuantidadeLivro
            // 
            lblQuantidadeLivro.AutoSize = true;
            lblQuantidadeLivro.Location = new Point(218, 159);
            lblQuantidadeLivro.Name = "lblQuantidadeLivro";
            lblQuantidadeLivro.Size = new Size(72, 15);
            lblQuantidadeLivro.TabIndex = 3;
            lblQuantidadeLivro.Text = "Quantidade:";
            // 
            // lblLinkDownload
            // 
            lblLinkDownload.AutoSize = true;
            lblLinkDownload.Location = new Point(452, 61);
            lblLinkDownload.Name = "lblLinkDownload";
            lblLinkDownload.Size = new Size(89, 15);
            lblLinkDownload.TabIndex = 4;
            lblLinkDownload.Text = "Link Download:";
            // 
            // lblTamanhoArquivo
            // 
            lblTamanhoArquivo.AutoSize = true;
            lblTamanhoArquivo.Location = new Point(449, 113);
            lblTamanhoArquivo.Name = "lblTamanhoArquivo";
            lblTamanhoArquivo.Size = new Size(104, 15);
            lblTamanhoArquivo.TabIndex = 5;
            lblTamanhoArquivo.Text = "Tamanho Arquivo:";
            // 
            // lblNomeEditora
            // 
            lblNomeEditora.AutoSize = true;
            lblNomeEditora.Location = new Point(9, 58);
            lblNomeEditora.Name = "lblNomeEditora";
            lblNomeEditora.Size = new Size(83, 15);
            lblNomeEditora.TabIndex = 6;
            lblNomeEditora.Text = "Nome Editora:";
            // 
            // lblEmailEditora
            // 
            lblEmailEditora.AutoSize = true;
            lblEmailEditora.Location = new Point(12, 113);
            lblEmailEditora.Name = "lblEmailEditora";
            lblEmailEditora.Size = new Size(39, 15);
            lblEmailEditora.TabIndex = 7;
            lblEmailEditora.Text = "Email:";
            // 
            // txtPrecoLivro
            // 
            txtPrecoLivro.Location = new Point(322, 110);
            txtPrecoLivro.Name = "txtPrecoLivro";
            txtPrecoLivro.Size = new Size(100, 23);
            txtPrecoLivro.TabIndex = 8;
            // 
            // txtQuantidadeLivro
            // 
            txtQuantidadeLivro.Location = new Point(322, 159);
            txtQuantidadeLivro.Name = "txtQuantidadeLivro";
            txtQuantidadeLivro.Size = new Size(100, 23);
            txtQuantidadeLivro.TabIndex = 9;
            // 
            // txtTamanhoArquivo
            // 
            txtTamanhoArquivo.Location = new Point(600, 105);
            txtTamanhoArquivo.Name = "txtTamanhoArquivo";
            txtTamanhoArquivo.Size = new Size(100, 23);
            txtTamanhoArquivo.TabIndex = 10;
            // 
            // txtLinkDownload
            // 
            txtLinkDownload.Location = new Point(600, 58);
            txtLinkDownload.Name = "txtLinkDownload";
            txtLinkDownload.Size = new Size(100, 23);
            txtLinkDownload.TabIndex = 11;
            // 
            // txtNomeEditora
            // 
            txtNomeEditora.Location = new Point(98, 55);
            txtNomeEditora.Name = "txtNomeEditora";
            txtNomeEditora.Size = new Size(100, 23);
            txtNomeEditora.TabIndex = 12;
            // 
            // txtEmailEditora
            // 
            txtEmailEditora.Location = new Point(98, 110);
            txtEmailEditora.Name = "txtEmailEditora";
            txtEmailEditora.Size = new Size(100, 23);
            txtEmailEditora.TabIndex = 13;
            // 
            // cmbEditora
            // 
            cmbEditora.FormattingEnabled = true;
            cmbEditora.Location = new Point(322, 213);
            cmbEditora.Name = "cmbEditora";
            cmbEditora.Size = new Size(100, 23);
            cmbEditora.TabIndex = 14;
            // 
            // lblEditoraDoLivro
            // 
            lblEditoraDoLivro.AutoSize = true;
            lblEditoraDoLivro.Location = new Point(204, 213);
            lblEditoraDoLivro.Name = "lblEditoraDoLivro";
            lblEditoraDoLivro.Size = new Size(94, 15);
            lblEditoraDoLivro.TabIndex = 15;
            lblEditoraDoLivro.Text = "Editora Do Livro:";
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvLivros.Location = new Point(204, 294);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.Size = new Size(443, 160);
            dgvLivros.TabIndex = 16;
            // 
            // btnAdicionarEditora
            // 
            btnAdicionarEditora.Location = new Point(123, 158);
            btnAdicionarEditora.Name = "btnAdicionarEditora";
            btnAdicionarEditora.Size = new Size(75, 23);
            btnAdicionarEditora.TabIndex = 17;
            btnAdicionarEditora.Text = "Adicionar";
            btnAdicionarEditora.UseVisualStyleBackColor = true;
            btnAdicionarEditora.Click += btnAdicionarEditora_Click;
            // 
            // btnAdicionarLivro
            // 
            btnAdicionarLivro.Location = new Point(338, 252);
            btnAdicionarLivro.Name = "btnAdicionarLivro";
            btnAdicionarLivro.Size = new Size(75, 23);
            btnAdicionarLivro.TabIndex = 18;
            btnAdicionarLivro.Text = "Adicionar";
            btnAdicionarLivro.UseVisualStyleBackColor = true;
            btnAdicionarLivro.Click += btnAdicionarLivro_Click;
            // 
            // btnConsultarLivros
            // 
            btnConsultarLivros.Location = new Point(625, 151);
            btnConsultarLivros.Name = "btnConsultarLivros";
            btnConsultarLivros.Size = new Size(75, 23);
            btnConsultarLivros.TabIndex = 19;
            btnConsultarLivros.Text = "Baixar";
            btnConsultarLivros.UseVisualStyleBackColor = true;
            btnConsultarLivros.Click += btnConsultarLivros_Click;
            // 
            // lblTitutoEditora
            // 
            lblTitutoEditora.AutoSize = true;
            lblTitutoEditora.Location = new Point(12, 25);
            lblTitutoEditora.Name = "lblTitutoEditora";
            lblTitutoEditora.Size = new Size(56, 15);
            lblTitutoEditora.TabIndex = 20;
            lblTitutoEditora.Text = "EDITORA:";
            // 
            // lblNomeLivro
            // 
            lblNomeLivro.AutoSize = true;
            lblNomeLivro.Location = new Point(204, 25);
            lblNomeLivro.Name = "lblNomeLivro";
            lblNomeLivro.Size = new Size(42, 15);
            lblNomeLivro.TabIndex = 21;
            lblNomeLivro.Text = "LIVRO:";
            // 
            // lblLivroDigital
            // 
            lblLivroDigital.AutoSize = true;
            lblLivroDigital.Location = new Point(449, 25);
            lblLivroDigital.Name = "lblLivroDigital";
            lblLivroDigital.Size = new Size(86, 15);
            lblLivroDigital.TabIndex = 22;
            lblLivroDigital.Text = "LIVRO DIGITAL:";
            // 
            // Column1
            // 
            Column1.HeaderText = "Título:";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Preço:";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quandidade:";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Editora";
            Column4.Name = "Column4";
            // 
            // frmLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLivroDigital);
            Controls.Add(lblNomeLivro);
            Controls.Add(lblTitutoEditora);
            Controls.Add(btnConsultarLivros);
            Controls.Add(btnAdicionarLivro);
            Controls.Add(btnAdicionarEditora);
            Controls.Add(dgvLivros);
            Controls.Add(lblEditoraDoLivro);
            Controls.Add(cmbEditora);
            Controls.Add(txtEmailEditora);
            Controls.Add(txtNomeEditora);
            Controls.Add(txtLinkDownload);
            Controls.Add(txtTamanhoArquivo);
            Controls.Add(txtQuantidadeLivro);
            Controls.Add(txtPrecoLivro);
            Controls.Add(lblEmailEditora);
            Controls.Add(lblNomeEditora);
            Controls.Add(lblTamanhoArquivo);
            Controls.Add(lblLinkDownload);
            Controls.Add(lblQuantidadeLivro);
            Controls.Add(lblPrecoLivro);
            Controls.Add(lblTituloLivro);
            Controls.Add(txtTituloLivro);
            Name = "frmLivro";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTituloLivro;
        private Label lblTituloLivro;
        private Label lblPrecoLivro;
        private Label lblQuantidadeLivro;
        private Label lblLinkDownload;
        private Label lblTamanhoArquivo;
        private Label lblNomeEditora;
        private Label lblEmailEditora;
        private TextBox txtPrecoLivro;
        private TextBox txtQuantidadeLivro;
        private TextBox txtTamanhoArquivo;
        private TextBox txtLinkDownload;
        private TextBox txtNomeEditora;
        private TextBox txtEmailEditora;
        private ComboBox cmbEditora;
        private Label lblEditoraDoLivro;
        private DataGridView dgvLivros;
        private Button btnAdicionarEditora;
        private Button btnAdicionarLivro;
        private Button btnConsultarLivros;
        private Label lblTitutoEditora;
        private Label lblNomeLivro;
        private Label lblLivroDigital;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }

}