namespace Semaforo_P3
{
    partial class miForma
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miForma));
            btnInicio = new Button();
            btnPrev = new Button();
            btnApagar = new Button();
            btnSalir = new Button();
            lblCont = new Label();
            SemOeste = new PictureBox();
            SemSur = new PictureBox();
            SemEste = new PictureBox();
            SemNorte = new PictureBox();
            tmrVerde = new System.Windows.Forms.Timer(components);
            tmrCambio = new System.Windows.Forms.Timer(components);
            tmrBlinkVerde = new System.Windows.Forms.Timer(components);
            tmrAmarillo = new System.Windows.Forms.Timer(components);
            tmrRojo = new System.Windows.Forms.Timer(components);
            tmrBlinkAmarillo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SemOeste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemSur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemEste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemNorte).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.LimeGreen;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.ForeColor = SystemColors.ControlText;
            btnInicio.Location = new Point(560, 141);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(98, 31);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gold;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.ForeColor = SystemColors.ControlText;
            btnPrev.Location = new Point(664, 141);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(98, 31);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "Preventivas";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Violet;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.ForeColor = SystemColors.ControlText;
            btnApagar.Location = new Point(560, 178);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(98, 31);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = SystemColors.ControlText;
            btnSalir.Location = new Point(664, 178);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 31);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCont
            // 
            lblCont.BackColor = Color.Black;
            lblCont.Font = new Font("Digital-7", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCont.ForeColor = SystemColors.ButtonFace;
            lblCont.Location = new Point(389, 349);
            lblCont.Name = "lblCont";
            lblCont.Size = new Size(87, 64);
            lblCont.TabIndex = 4;
            lblCont.Text = "0";
            lblCont.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SemOeste
            // 
            SemOeste.BackColor = Color.Black;
            SemOeste.Image = Properties.Resources.Sema_Off2_0_LatI;
            SemOeste.Location = new Point(281, 266);
            SemOeste.Name = "SemOeste";
            SemOeste.Size = new Size(80, 55);
            SemOeste.SizeMode = PictureBoxSizeMode.StretchImage;
            SemOeste.TabIndex = 5;
            SemOeste.TabStop = false;
            // 
            // SemSur
            // 
            SemSur.BackColor = Color.Black;
            SemSur.Image = Properties.Resources.Sema_Off2_0_A;
            SemSur.Location = new Point(329, 452);
            SemSur.Name = "SemSur";
            SemSur.Size = new Size(56, 82);
            SemSur.SizeMode = PictureBoxSizeMode.StretchImage;
            SemSur.TabIndex = 6;
            SemSur.TabStop = false;
            // 
            // SemEste
            // 
            SemEste.BackColor = Color.Black;
            SemEste.Image = Properties.Resources.Sema_Off2_0_LatD;
            SemEste.Location = new Point(544, 419);
            SemEste.Name = "SemEste";
            SemEste.Size = new Size(80, 55);
            SemEste.SizeMode = PictureBoxSizeMode.StretchImage;
            SemEste.TabIndex = 7;
            SemEste.TabStop = false;
            SemEste.Click += SemEste_Click;
            // 
            // SemNorte
            // 
            SemNorte.BackColor = Color.Black;
            SemNorte.Image = Properties.Resources.Sema_Off2_0;
            SemNorte.Location = new Point(502, 239);
            SemNorte.Name = "SemNorte";
            SemNorte.Size = new Size(56, 82);
            SemNorte.SizeMode = PictureBoxSizeMode.StretchImage;
            SemNorte.TabIndex = 8;
            SemNorte.TabStop = false;
            SemNorte.Click += SemNorte_Click;
            // 
            // tmrVerde
            // 
            tmrVerde.Interval = 500;
            tmrVerde.Tick += tmrVerde_Tick;
            // 
            // tmrCambio
            // 
            tmrCambio.Interval = 500;
            tmrCambio.Tick += tmrCambio_Tick;
            // 
            // tmrBlinkVerde
            // 
            tmrBlinkVerde.Interval = 500;
            tmrBlinkVerde.Tick += tmrBlinkVerde_Tick;
            // 
            // tmrAmarillo
            // 
            tmrAmarillo.Interval = 500;
            tmrAmarillo.Tick += tmrAmarillo_Tick;
            // 
            // tmrRojo
            // 
            tmrRojo.Interval = 500;
            tmrRojo.Tick += tmrRojo_Tick;
            // 
            // tmrBlinkAmarillo
            // 
            tmrBlinkAmarillo.Interval = 500;
            tmrBlinkAmarillo.Tick += tmrBlinkAmarillo_Tick;
            // 
            // miForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 600);
            Controls.Add(SemNorte);
            Controls.Add(SemEste);
            Controls.Add(SemSur);
            Controls.Add(SemOeste);
            Controls.Add(lblCont);
            Controls.Add(btnSalir);
            Controls.Add(btnApagar);
            Controls.Add(btnPrev);
            Controls.Add(btnInicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "miForma";
            StartPosition = FormStartPosition.Manual;
            Text = "miSemaforo";
            Load += miForma_Load;
            ((System.ComponentModel.ISupportInitialize)SemOeste).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemSur).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemEste).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemNorte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInicio;
        private Button btnPrev;
        private Button btnApagar;
        private Button btnSalir;
        private Label lblCont;
        private PictureBox SemOeste;
        private PictureBox SemSur;
        private PictureBox SemEste;
        private PictureBox SemNorte;
        private System.Windows.Forms.Timer tmrVerde;
        private System.Windows.Forms.Timer tmrCambio;
        private System.Windows.Forms.Timer tmrBlinkVerde;
        private System.Windows.Forms.Timer tmrAmarillo;
        private System.Windows.Forms.Timer tmrRojo;
        private System.Windows.Forms.Timer tmrBlinkAmarillo;
    }
}