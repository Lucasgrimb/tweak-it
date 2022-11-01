namespace Tweak_it
{
    partial class eleccionNivelPictos
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
            this.dibujos = new System.Windows.Forms.PictureBox();
            this.fotos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictogramas = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dibujos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictogramas)).BeginInit();
            this.SuspendLayout();
            // 
            // dibujos
            // 
            this.dibujos.BackColor = System.Drawing.Color.Transparent;
            this.dibujos.BackgroundImage = global::Tweak_it.Properties.Resources.nivel_3_p;
            this.dibujos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dibujos.Location = new System.Drawing.Point(1051, 625);
            this.dibujos.Margin = new System.Windows.Forms.Padding(2);
            this.dibujos.Name = "dibujos";
            this.dibujos.Size = new System.Drawing.Size(632, 124);
            this.dibujos.TabIndex = 0;
            this.dibujos.TabStop = false;
            this.dibujos.Click += new System.EventHandler(this.dibujos_Click);
            // 
            // fotos
            // 
            this.fotos.BackColor = System.Drawing.Color.Transparent;
            this.fotos.BackgroundImage = global::Tweak_it.Properties.Resources.nivel_2;
            this.fotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotos.Location = new System.Drawing.Point(1051, 494);
            this.fotos.Margin = new System.Windows.Forms.Padding(2);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(632, 123);
            this.fotos.TabIndex = 2;
            this.fotos.TabStop = false;
            this.fotos.Click += new System.EventHandler(this.fotos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tweak_it.Properties.Resources.gato_personaje_2__modi1_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(209, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 619);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictogramas
            // 
            this.pictogramas.AccessibleDescription = "";
            this.pictogramas.BackColor = System.Drawing.Color.Transparent;
            this.pictogramas.BackgroundImage = global::Tweak_it.Properties.Resources.nivel_1;
            this.pictogramas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictogramas.Location = new System.Drawing.Point(1051, 368);
            this.pictogramas.Margin = new System.Windows.Forms.Padding(2);
            this.pictogramas.Name = "pictogramas";
            this.pictogramas.Size = new System.Drawing.Size(632, 121);
            this.pictogramas.TabIndex = 1;
            this.pictogramas.TabStop = false;
            this.pictogramas.Click += new System.EventHandler(this.pictogramas_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Tweak_it.Properties.Resources.Vector_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(149, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 68);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eleccionNivelPictos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.Fondo_y_texto_eleccion_de_nivel;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fotos);
            this.Controls.Add(this.pictogramas);
            this.Controls.Add(this.dibujos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "eleccionNivelPictos";
            this.Text = "eleccionNivelPictos";
            this.Load += new System.EventHandler(this.juego1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dibujos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictogramas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dibujos;
        private System.Windows.Forms.PictureBox fotos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictogramas;
        private System.Windows.Forms.Button button2;
    }
}