using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        float nota1, nota2, nota3, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            txtMedia.Text = Convert.ToString(media);

            switch (media)
            {
                case >= 7:
                    lblSituacao.Text = "ALUNO APROVADO COM SUCESSO";
                    break;
                case < 3:
                    lblSituacao.Text = "ALUNO MUITO ABAIXO DA MÉDIA";
                    break;
                default:
                    lblSituacao.Text = "ALUNO REPROVADO";
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtMedia.Text = " ";
            lblSituacao.Text = " ";
            txtNota1.Text = " ";
            txtNota2.Text = " ";
            txtNota3.Text = " ";
        }
    }
}