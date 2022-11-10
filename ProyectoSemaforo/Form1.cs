using ProyectoSemaforo.Properties;
using System.Drawing;
using System.Resources;



namespace ProyectoSemaforo
{
    public partial class miForma : Form
    {
        bool SemaforosNorteYSur = true;
        double SegundosEnVerde = 0, UltimosSegundosVerde = 0, SegundosEnAmarillo = 0, SegundosEnRojo =0;
        int Estado = 0;

        public miForma()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miForma_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblCont.ForeColor = Color.GreenYellow;
            Estado = 1;
            CambioDeSemaforo(Properties.Resources.Sema_Green);
            tmrCambio.Start();
        }

        private void CambioDeSemaforo(Image img)
        {
            if (SemaforosNorteYSur)
            {
                SemNorte.Image = (Image)img.Clone();
                SemSur.Image = (Image)img.Clone();
                SemSur.Image.RotateFlip(RotateFlipType.Rotate180FlipX);

                SemEste.Image = Properties.Resources.Sema_Red;
                SemOeste.Image = Properties.Resources.Sema_Red;
                SemEste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                SemOeste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
            else
            {
                SemEste.Image = (Image)img.Clone();
                SemOeste.Image = (Image)img.Clone();
                SemEste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                SemOeste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
        }

        private void tmrVerde_Tick(object sender, EventArgs e)
        {   
            if (SegundosEnVerde <=4)
            {  
                int Aux = (int)SegundosEnVerde;
                lblCont.Text = (Aux+1).ToString();
                SegundosEnVerde = SegundosEnVerde + 0.5;
            }
            else
            {
                tmrVerde.Stop();
                SegundosEnVerde = 0;
                CambioDeSemaforo(Properties.Resources.Sema_Off);
                lblCont.ForeColor = Color.Black;
                Estado = 2;
                tmrCambio.Start();
            }
        }

        private void tmrCambio_Tick(object sender, EventArgs e)
        {
            tmrCambio.Stop();
            //Variable de tipo Image, la igualamos a semaforo apagado
            Image SiguienteImagen = Properties.Resources.Sema_Off;
            if (Estado == 1)
            {
                SegundosEnVerde = 0.5;
                tmrVerde.Start();
                SiguienteImagen = Properties.Resources.Sema_Green;
                lblCont.ForeColor = Color.GreenYellow;
            }
            if (Estado == 2)
            {
                UltimosSegundosVerde = 1;
                tmrBlinkVerde.Start();
                SiguienteImagen = Properties.Resources.Sema_Green;
                lblCont.ForeColor = Color.GreenYellow;
            }
            if (Estado == 3)
            {
                SegundosEnAmarillo = 0.5;
                tmrAmarillo.Start();
                SiguienteImagen = Properties.Resources.Sema_Yellow;
                lblCont.ForeColor = Color.Gold;
            }
            if (Estado == 4)
            {
                SegundosEnRojo = 0.5;
                tmrRojo.Start();
                SiguienteImagen = Properties.Resources.Sema_Red;
                lblCont.ForeColor = Color.Red;
            }
            lblCont.Text = "1";
            CambioDeSemaforo(SiguienteImagen);
        }

        private void tmrBlinkVerde_Tick(object sender, EventArgs e)
        {
            if (UltimosSegundosVerde < 4)
            {

                int Aux = (int)UltimosSegundosVerde;
                if (UltimosSegundosVerde == 1.5 || UltimosSegundosVerde == 2.5 || UltimosSegundosVerde == 3.5)
                {
                    CambioDeSemaforo(Properties.Resources.Sema_Off);
                    lblCont.ForeColor = Color.Black;    
                }
                else
                {
                    CambioDeSemaforo(Properties.Resources.Sema_Green);
                    lblCont.ForeColor = Color.GreenYellow;
                    lblCont.Text = Aux.ToString();
                }
                UltimosSegundosVerde = UltimosSegundosVerde + 0.5;
            }
            else
            {
                tmrBlinkVerde.Stop();
                UltimosSegundosVerde = 0;
                lblCont.ForeColor = Color.Black;
                Estado = 3;
                tmrCambio.Start();
            }
        }

        private void tmrRojo_Tick(object sender, EventArgs e)
        {
            if (SegundosEnRojo <= 1)
            {
                int Aux = (int)SegundosEnRojo;
                lblCont.Text = (Aux + 1).ToString();
                SegundosEnRojo = SegundosEnRojo + 0.5;
            }
            else
            {
                tmrRojo.Stop();
                SegundosEnRojo = 0;
                CambioDeSemaforo(Properties.Resources.Sema_Red);
                lblCont.ForeColor = Color.Black;
                Estado = 1;
                SemaforosNorteYSur = !SemaforosNorteYSur;
                tmrCambio.Start();
            }
        }

        private void tmrAmarillo_Tick(object sender, EventArgs e)
        {
            if (SegundosEnAmarillo <= 2)
            {
                int Aux = (int)SegundosEnAmarillo;
                lblCont.Text = (Aux + 1).ToString();
                SegundosEnAmarillo = SegundosEnAmarillo + 0.5;
            }
            else
            {
                tmrAmarillo.Stop();
                SegundosEnAmarillo = 0;
                lblCont.ForeColor = Color.Black;
                Estado = 4;
                tmrCambio.Start();
            }
        }

        private void SemNorte_Click(object sender, EventArgs e)
        {

        }
        private void SemEste_Click(object sender, EventArgs e)
        {

        }
    }
}
