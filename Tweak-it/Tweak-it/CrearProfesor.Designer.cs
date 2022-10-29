
namespace Tweak_it
{
    partial class CrearProfesor
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
            this.txtUsuarioCrearPROF = new System.Windows.Forms.TextBox();
            this.txtPassCrearPROF = new System.Windows.Forms.TextBox();
            this.btnCrearProfesor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuarioCrearPROF
            // 
            this.txtUsuarioCrearPROF.BackColor = System.Drawing.Color.Silver;
            this.txtUsuarioCrearPROF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCrearPROF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUsuarioCrearPROF.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuarioCrearPROF.HideSelection = false;
            this.txtUsuarioCrearPROF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUsuarioCrearPROF.Location = new System.Drawing.Point(638, 326);
            this.txtUsuarioCrearPROF.Multiline = true;
            this.txtUsuarioCrearPROF.Name = "txtUsuarioCrearPROF";
            this.txtUsuarioCrearPROF.Size = new System.Drawing.Size(689, 61);
            this.txtUsuarioCrearPROF.TabIndex = 1;
            this.txtUsuarioCrearPROF.Text = "USUARIO";
            this.txtUsuarioCrearPROF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioCrearPROF.Enter += new System.EventHandler(this.txtUsuarioCrearPROF_Enter);
            this.txtUsuarioCrearPROF.Leave += new System.EventHandler(this.txtUsuarioCrearPROF_Leave);
            // 
            // txtPassCrearPROF
            // 
            this.txtPassCrearPROF.BackColor = System.Drawing.Color.Silver;
            this.txtPassCrearPROF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassCrearPROF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPassCrearPROF.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassCrearPROF.HideSelection = false;
            this.txtPassCrearPROF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassCrearPROF.Location = new System.Drawing.Point(638, 496);
            this.txtPassCrearPROF.Multiline = true;
            this.txtPassCrearPROF.Name = "txtPassCrearPROF";
            this.txtPassCrearPROF.Size = new System.Drawing.Size(689, 61);
            this.txtPassCrearPROF.TabIndex = 2;
            this.txtPassCrearPROF.Text = "CONTRASEÑA";
            this.txtPassCrearPROF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassCrearPROF.Enter += new System.EventHandler(this.txtPassCrearPROF_Enter);
            this.txtPassCrearPROF.Leave += new System.EventHandler(this.txtPassCrearPROF_Leave);
            // 
            // btnCrearProfesor
            // 
            this.btnCrearProfesor.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearProfesor.BackgroundImage = global::Tweak_it.Properties.Resources.boton_crear_removebg_preview2323;
            this.btnCrearProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearProfesor.Location = new System.Drawing.Point(770, 631);
            this.btnCrearProfesor.Name = "btnCrearProfesor";
            this.btnCrearProfesor.Size = new System.Drawing.Size(404, 119);
            this.btnCrearProfesor.TabIndex = 3;
            this.btnCrearProfesor.TabStop = false;
            this.btnCrearProfesor.Click += new System.EventHandler(this.btnCrearProfesor_Click);
            // 
            // CrearProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo_y_texto_profesor;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnCrearProfesor);
            this.Controls.Add(this.txtPassCrearPROF);
            this.Controls.Add(this.txtUsuarioCrearPROF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProfesor";
            this.Text = "CrearProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioCrearPROF;
        private System.Windows.Forms.TextBox txtPassCrearPROF;
        private System.Windows.Forms.PictureBox btnCrearProfesor;
    }
}