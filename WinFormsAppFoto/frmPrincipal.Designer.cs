namespace WinFormsAppFoto
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            label2 = new Label();
            pbxImagem = new PictureBox();
            btnFoto = new Button();
            dgvFoto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoto).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.MidnightBlue;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(527, 28);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(185, 45);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(321, 23);
            txtNome.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(527, 79);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(185, 45);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(527, 130);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(185, 45);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Green;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(527, 181);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(185, 45);
            btnSair.TabIndex = 5;
            btnSair.Text = "FECHAR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "IMAGEM";
            // 
            // pbxImagem
            // 
            pbxImagem.Location = new Point(17, 84);
            pbxImagem.Name = "pbxImagem";
            pbxImagem.Size = new Size(167, 173);
            pbxImagem.TabIndex = 7;
            pbxImagem.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.Brown;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(190, 156);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(186, 51);
            btnFoto.TabIndex = 8;
            btnFoto.Text = "FOTO...";
            btnFoto.UseMnemonic = false;
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // dgvFoto
            // 
            dgvFoto.AllowUserToAddRows = false;
            dgvFoto.AllowUserToDeleteRows = false;
            dgvFoto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoto.Location = new Point(12, 273);
            dgvFoto.Name = "dgvFoto";
            dgvFoto.ReadOnly = true;
            dgvFoto.RowTemplate.Height = 25;
            dgvFoto.Size = new Size(700, 189);
            dgvFoto.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 474);
            Controls.Add(dgvFoto);
            Controls.Add(btnFoto);
            Controls.Add(pbxImagem);
            Controls.Add(label2);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnAdicionar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Foto";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Label label1;
        private TextBox txtNome;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnSair;
        private Label label2;
        private PictureBox pbxImagem;
        private Button btnFoto;
        private DataGridView dgvFoto;
    }
}