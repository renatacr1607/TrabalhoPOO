namespace ControleProduto
{
    partial class Form2
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
            lblRevista = new Label();
            lblTitulo = new Label();
            lblPreco = new Label();
            lblFrequencia = new Label();
            txtTitulo = new TextBox();
            txtPreco = new TextBox();
            txtFrequencia = new TextBox();
            btnCadastrar = new Button();
            btnVerificarDisponibilidade = new Button();
            SuspendLayout();
            // 
            // lblRevista
            // 
            lblRevista.AutoSize = true;
            lblRevista.Location = new Point(32, 29);
            lblRevista.Name = "lblRevista";
            lblRevista.Size = new Size(52, 15);
            lblRevista.TabIndex = 0;
            lblRevista.Text = "REVISTA:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(32, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(32, 106);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço:";
            // 
            // lblFrequencia
            // 
            lblFrequencia.AutoSize = true;
            lblFrequencia.Location = new Point(32, 145);
            lblFrequencia.Name = "lblFrequencia";
            lblFrequencia.Size = new Size(68, 15);
            lblFrequencia.TabIndex = 3;
            lblFrequencia.Text = "Frequência:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(115, 72);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(115, 106);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 5;
            // 
            // txtFrequencia
            // 
            txtFrequencia.Location = new Point(115, 142);
            txtFrequencia.Name = "txtFrequencia";
            txtFrequencia.Size = new Size(100, 23);
            txtFrequencia.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(140, 229);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Comprar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVerificarDisponibilidade
            // 
            btnVerificarDisponibilidade.Location = new Point(140, 189);
            btnVerificarDisponibilidade.Name = "btnVerificarDisponibilidade";
            btnVerificarDisponibilidade.Size = new Size(75, 23);
            btnVerificarDisponibilidade.TabIndex = 8;
            btnVerificarDisponibilidade.Text = "Verificar";
            btnVerificarDisponibilidade.UseVisualStyleBackColor = true;
            btnVerificarDisponibilidade.Click += btnVerificarDisponibilidade_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 310);
            Controls.Add(btnVerificarDisponibilidade);
            Controls.Add(btnCadastrar);
            Controls.Add(txtFrequencia);
            Controls.Add(txtPreco);
            Controls.Add(txtTitulo);
            Controls.Add(lblFrequencia);
            Controls.Add(lblPreco);
            Controls.Add(lblTitulo);
            Controls.Add(lblRevista);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRevista;
        private Label lblTitulo;
        private Label lblPreco;
        private Label lblFrequencia;
        private TextBox txtTitulo;
        private TextBox txtPreco;
        private TextBox txtFrequencia;
        private Button btnCadastrar;
        private Button btnVerificarDisponibilidade;
    }
}