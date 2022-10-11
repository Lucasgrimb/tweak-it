namespace Tweak_it
{
    partial class juego1
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
            this.pictogramas = new System.Windows.Forms.PictureBox();
            this.fotos = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dibujos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictogramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).BeginInit();
            this.SuspendLayout();
            // 
            // dibujos
            // 
            this.dibujos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dibujos.Location = new System.Drawing.Point(313, 177);
            this.dibujos.Name = "dibujos";
            this.dibujos.Size = new System.Drawing.Size(187, 81);
            this.dibujos.TabIndex = 0;
            this.dibujos.TabStop = false;
            this.dibujos.Click += new System.EventHandler(this.dibujos_Click);
            // 
            // pictogramas
            // 
            this.pictogramas.AccessibleDescription = "";
            this.pictogramas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictogramas.Location = new System.Drawing.Point(81, 177);
            this.pictogramas.Name = "pictogramas";
            this.pictogramas.Size = new System.Drawing.Size(178, 81);
            this.pictogramas.TabIndex = 1;
            this.pictogramas.TabStop = false;
            this.pictogramas.Click += new System.EventHandler(this.pictogramas_Click);
            // 
            // fotos
            // 
            this.fotos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fotos.Location = new System.Drawing.Point(536, 177);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(187, 81);
            this.fotos.TabIndex = 2;
            this.fotos.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(37, 32);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(107, 43);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // juego1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.fotos);
            this.Controls.Add(this.pictogramas);
            this.Controls.Add(this.dibujos);
            this.Name = "juego1";
            this.Text = "juego1";
            this.Load += new System.EventHandler(this.juego1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dibujos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictogramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dibujos;
        private System.Windows.Forms.PictureBox pictogramas;
        private System.Windows.Forms.PictureBox fotos;
        private System.Windows.Forms.Button btnAtras;
    }
}