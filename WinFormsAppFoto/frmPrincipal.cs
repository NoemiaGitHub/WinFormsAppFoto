namespace WinFormsAppFoto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Foto foto = new Foto();
            List<Foto> fotos = foto.listafoto();
            dgvFoto.DataSource = fotos;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "selecione uma imagem...";
            dialog.Filter = "Arquivos de imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif|todos os arquivos|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagem = dialog.FileName;
                pbxImagem.ImageLocation = imagem;
            }


        }
    }
}