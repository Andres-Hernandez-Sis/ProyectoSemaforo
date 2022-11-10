﻿namespace ProyectoSemaforo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miForma));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCont = new System.Windows.Forms.Label();
            this.SemOeste = new System.Windows.Forms.PictureBox();
            this.SemSur = new System.Windows.Forms.PictureBox();
            this.SemEste = new System.Windows.Forms.PictureBox();
            this.SemNorte = new System.Windows.Forms.PictureBox();
            this.tmrVerde = new System.Windows.Forms.Timer(this.components);
            this.tmrCambio = new System.Windows.Forms.Timer(this.components);
            this.tmrBlinkVerde = new System.Windows.Forms.Timer(this.components);
            this.tmrAmarillo = new System.Windows.Forms.Timer(this.components);
            this.tmrRojo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SemOeste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemSur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemEste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemNorte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Honeydew;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(12, 503);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Honeydew;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev.Location = new System.Drawing.Point(12, 532);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Preventivas";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Honeydew;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApagar.Location = new System.Drawing.Point(12, 561);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(547, 561);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCont
            // 
            this.lblCont.BackColor = System.Drawing.Color.Black;
            this.lblCont.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCont.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCont.Location = new System.Drawing.Point(376, 260);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(167, 53);
            this.lblCont.TabIndex = 4;
            this.lblCont.Text = "0";
            this.lblCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SemOeste
            // 
            this.SemOeste.BackColor = System.Drawing.Color.Black;
            this.SemOeste.Image = global::ProyectoSemaforo.Properties.Resources.Sema_Off;
            this.SemOeste.Location = new System.Drawing.Point(245, 223);
            this.SemOeste.Name = "SemOeste";
            this.SemOeste.Size = new System.Drawing.Size(80, 55);
            this.SemOeste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemOeste.TabIndex = 5;
            this.SemOeste.TabStop = false;
            // 
            // SemSur
            // 
            this.SemSur.BackColor = System.Drawing.Color.Black;
            this.SemSur.Image = global::ProyectoSemaforo.Properties.Resources.Sema_Off;
            this.SemSur.Location = new System.Drawing.Point(299, 345);
            this.SemSur.Name = "SemSur";
            this.SemSur.Size = new System.Drawing.Size(57, 83);
            this.SemSur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemSur.TabIndex = 6;
            this.SemSur.TabStop = false;
            // 
            // SemEste
            // 
            this.SemEste.BackColor = System.Drawing.Color.Black;
            this.SemEste.Image = global::ProyectoSemaforo.Properties.Resources.Sema_Off;
            this.SemEste.Location = new System.Drawing.Point(475, 321);
            this.SemEste.Name = "SemEste";
            this.SemEste.Size = new System.Drawing.Size(81, 54);
            this.SemEste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemEste.TabIndex = 7;
            this.SemEste.TabStop = false;
            this.SemEste.Click += new System.EventHandler(this.SemEste_Click);
            // 
            // SemNorte
            // 
            this.SemNorte.BackColor = System.Drawing.Color.Black;
            this.SemNorte.Image = global::ProyectoSemaforo.Properties.Resources.Sema_Off;
            this.SemNorte.Location = new System.Drawing.Point(447, 146);
            this.SemNorte.Name = "SemNorte";
            this.SemNorte.Size = new System.Drawing.Size(57, 83);
            this.SemNorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemNorte.TabIndex = 8;
            this.SemNorte.TabStop = false;
            this.SemNorte.Click += new System.EventHandler(this.SemNorte_Click);
            // 
            // tmrVerde
            // 
            this.tmrVerde.Interval = 500;
            this.tmrVerde.Tick += new System.EventHandler(this.tmrVerde_Tick);
            // 
            // tmrCambio
            // 
            this.tmrCambio.Interval = 500;
            this.tmrCambio.Tick += new System.EventHandler(this.tmrCambio_Tick);
            // 
            // tmrBlinkVerde
            // 
            this.tmrBlinkVerde.Interval = 500;
            this.tmrBlinkVerde.Tick += new System.EventHandler(this.tmrBlinkVerde_Tick);
            // 
            // tmrAmarillo
            // 
            this.tmrAmarillo.Interval = 500;
            this.tmrAmarillo.Tick += new System.EventHandler(this.tmrAmarillo_Tick);
            // 
            // tmrRojo
            // 
            this.tmrRojo.Interval = 500;
            this.tmrRojo.Tick += new System.EventHandler(this.tmrRojo_Tick);
            // 
            // miForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.SemNorte);
            this.Controls.Add(this.SemEste);
            this.Controls.Add(this.SemSur);
            this.Controls.Add(this.SemOeste);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "miForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.miForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemOeste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemSur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemEste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemNorte)).EndInit();
            this.ResumeLayout(false);

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
    }
}