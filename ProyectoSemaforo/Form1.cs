using System.Media;

namespace Semaforo_P3
{
    public partial class miForma : Form
    {
        bool SemaforosNorteYSur = true;
        double SegundosEnVerde = 0, UltimosSegundosVerde = 0, SegundosEnAmarillo = 0, SegundosEnRojo = 0;
        int Estado = 0;

        public miForma()
        {
            InitializeComponent();
        }

        private void miForma_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            DetenerTimerYSegundos();
            SemEste.Image = Properties.Resources.Sema_Red2_0;
            SemEste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            SemOeste.Image = Properties.Resources.Sema_Red2_0;
            SemOeste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);

            SemaforosNorteYSur = true;
            lblCont.ForeColor = Color.GreenYellow; lblCont.Text = "1";
            Estado = 1; SegundosEnVerde = 1;
            CambioDeSemaforo(Properties.Resources.Sema_Green2_0);
            tmrCambio.Start();
        }

        private void tmrCambio_Tick(object sender, EventArgs e)
        {
            tmrCambio.Stop();
            Image SiguienteImagen = Properties.Resources.Sema_Off2_0;
            if (Estado == 1)
            {
                tmrVerde.Start();
                SiguienteImagen = Properties.Resources.Sema_Green2_0;
                lblCont.ForeColor = Color.GreenYellow;
            }
            if (Estado == 2)
            {
                UltimosSegundosVerde = 1.5;
                tmrBlinkVerde.Start();
                SiguienteImagen = Properties.Resources.Sema_Green2_0;
                lblCont.ForeColor = Color.GreenYellow;
            }
            if (Estado == 3)
            {
                SegundosEnAmarillo = 0.5;
                tmrAmarillo.Start();
                SiguienteImagen = Properties.Resources.Sema_Yellow2_0;
                lblCont.ForeColor = Color.Gold;
            }
            if (Estado == 4)
            {
                SegundosEnRojo = 0.5;
                tmrRojo.Start();
                SiguienteImagen = Properties.Resources.Sema_Red2_0;
                lblCont.ForeColor = Color.Red;
            }
            lblCont.Text = "1";
            CambioDeSemaforo(SiguienteImagen);
        }

        private void tmrVerde_Tick(object sender, EventArgs e)
        {
            if (SegundosEnVerde <= 19)
            {
                int Aux = (int)SegundosEnVerde;
                lblCont.Text = (Aux + 1).ToString();
                SegundosEnVerde = SegundosEnVerde + 0.5;
            }
            else
            {
                tmrVerde.Stop();
                SegundosEnVerde = 0;
                CambioDeSemaforo(Properties.Resources.Sema_Off2_0);
                lblCont.ForeColor = Color.Gray;
                Estado = 2; SegundosEnVerde = 0.5;
                tmrCambio.Start();
            }
        }

        private void tmrBlinkVerde_Tick(object sender, EventArgs e)
        {
            if (UltimosSegundosVerde < 3.5)
            {
                int Aux = (int)UltimosSegundosVerde;
                if (UltimosSegundosVerde == 1.5 || UltimosSegundosVerde == 2.5)
                {
                    CambioDeSemaforo(Properties.Resources.Sema_Off2_0);
                    lblCont.ForeColor = Color.Gray;
                }
                else
                {
                    CambioDeSemaforo(Properties.Resources.Sema_Green2_0);
                    lblCont.ForeColor = Color.GreenYellow;
                    lblCont.Text = Aux.ToString();
                }
                UltimosSegundosVerde = UltimosSegundosVerde + 0.5;
            }
            else
            {
                tmrBlinkVerde.Stop();
                UltimosSegundosVerde = 0;
                CambioDeSemaforo(Properties.Resources.Sema_Off2_0);
                lblCont.ForeColor = Color.Gray;
                Estado = 3;
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
                CambioDeSemaforo(Properties.Resources.Sema_Off2_0);
                lblCont.ForeColor = Color.Gray;
                Estado = 4;
                tmrCambio.Start();
            }
        }

        private void tmrBlinkAmarillo_Tick(object sender, EventArgs e)
        {
            if (lblCont.ForeColor == Color.Gray)
            {
                lblCont.Text = "0";
                lblCont.ForeColor = Color.Gold;
                ParpadeoAmarillo(Properties.Resources.Sema_Yellow2_0);
            }
            else
            {
                lblCont.Text = "0";
                lblCont.ForeColor = Color.Gray;
                ParpadeoAmarillo(Properties.Resources.Sema_Off2_0);
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
                CambioDeSemaforo(Properties.Resources.Sema_Off2_0);
                lblCont.ForeColor = Color.Gray;
                Estado = 1;
                SemaforosNorteYSur = !SemaforosNorteYSur;
                tmrCambio.Start();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            DetenerTimerYSegundos();
            ParpadeoAmarillo(Properties.Resources.Sema_Yellow2_0);
            lblCont.ForeColor = Color.Gold;
            tmrBlinkAmarillo.Start();
        }

        private void CambioDeSemaforo(Image img)
        {
            if (SemaforosNorteYSur)
            {
                SemNorte.Image = (Image)img.Clone();
                SemSur.Image = (Image)img.Clone();
                SemSur.Image.RotateFlip(RotateFlipType.Rotate180FlipX);

                SemEste.Image = Properties.Resources.Sema_Red2_0;
                SemOeste.Image = Properties.Resources.Sema_Red2_0;
                SemOeste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                SemEste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
            else
            {
                SemNorte.Image = Properties.Resources.Sema_Red2_0;
                SemSur.Image = Properties.Resources.Sema_Red2_0;
                SemEste.Image = (Image)img.Clone();
                SemOeste.Image = (Image)img.Clone();
                SemOeste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                SemEste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                SemSur.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
        }

        private void ParpadeoAmarillo(Image img)
        {
            SemNorte.Image = (Image)img.Clone();
            SemSur.Image = (Image)img.Clone();
            SemEste.Image = (Image)img.Clone();
            SemOeste.Image = (Image)img.Clone();
            SemEste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            SemSur.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            SemOeste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DetenerTimerYSegundos();
            lblCont.ForeColor = Color.Gray;
            lblCont.Text = "0";
            Apagar(Properties.Resources.Sema_Off2_0);
        }

        private void Apagar(Image img)
        {
            SemNorte.Image = (Image)img.Clone();
            SemSur.Image = (Image)img.Clone();
            SemEste.Image = (Image)img.Clone();
            SemOeste.Image = (Image)img.Clone();
            SemEste.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            SemSur.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            SemOeste.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
        }

        public void DetenerTimerYSegundos()
        {
            tmrAmarillo.Stop();
            tmrVerde.Stop();
            tmrRojo.Stop();
            tmrBlinkVerde.Stop();
            tmrBlinkAmarillo.Stop();
            SegundosEnVerde = 0; UltimosSegundosVerde = 0; SegundosEnAmarillo = 0; SegundosEnRojo = 0;
            lblCont.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SemNorte_Click(object sender, EventArgs e)
        {

        }
        private void SemEste_Click(object sender, EventArgs e)
        {

        }
    }
}
