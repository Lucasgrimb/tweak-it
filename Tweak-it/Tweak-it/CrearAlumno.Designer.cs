
namespace Tweak_it
{
    partial class CrearAlumno
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
            this.btnCrearAlumno = new System.Windows.Forms.PictureBox();
            this.txtPassCrearAlumno = new System.Windows.Forms.TextBox();
            this.txtUsuarioCrearAlumno = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearAlumno.BackgroundImage = global::Tweak_it.Properties.Resources.boton_crear_removebg_preview2323;
            this.btnCrearAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearAlumno.Location = new System.Drawing.Point(808, 748);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(404, 119);
            this.btnCrearAlumno.TabIndex = 6;
            this.btnCrearAlumno.TabStop = false;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnCrearAlumno_Click);
            // 
            // txtPassCrearAlumno
            // 
            this.txtPassCrearAlumno.BackColor = System.Drawing.Color.Silver;
            this.txtPassCrearAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassCrearAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPassCrearAlumno.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassCrearAlumno.HideSelection = false;
            this.txtPassCrearAlumno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassCrearAlumno.Location = new System.Drawing.Point(669, 457);
            this.txtPassCrearAlumno.Multiline = true;
            this.txtPassCrearAlumno.Name = "txtPassCrearAlumno";
            this.txtPassCrearAlumno.Size = new System.Drawing.Size(689, 61);
            this.txtPassCrearAlumno.TabIndex = 5;
            this.txtPassCrearAlumno.Text = "APELLIDO";
            this.txtPassCrearAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassCrearAlumno.Enter += new System.EventHandler(this.txtPassCrearAlumno_Enter);
            this.txtPassCrearAlumno.Leave += new System.EventHandler(this.txtPassCrearAlumno_Leave);
            // 
            // txtUsuarioCrearAlumno
            // 
            this.txtUsuarioCrearAlumno.BackColor = System.Drawing.Color.Silver;
            this.txtUsuarioCrearAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCrearAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUsuarioCrearAlumno.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuarioCrearAlumno.HideSelection = false;
            this.txtUsuarioCrearAlumno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUsuarioCrearAlumno.Location = new System.Drawing.Point(669, 334);
            this.txtUsuarioCrearAlumno.Multiline = true;
            this.txtUsuarioCrearAlumno.Name = "txtUsuarioCrearAlumno";
            this.txtUsuarioCrearAlumno.Size = new System.Drawing.Size(689, 61);
            this.txtUsuarioCrearAlumno.TabIndex = 4;
            this.txtUsuarioCrearAlumno.Text = "NOMBRE";
            this.txtUsuarioCrearAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioCrearAlumno.Enter += new System.EventHandler(this.txtUsuarioCrearAlumno_Enter);
            this.txtUsuarioCrearAlumno.Leave += new System.EventHandler(this.txtUsuarioCrearAlumno_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.Silver;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.HideSelection = false;
            this.txtEdad.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtEdad.Location = new System.Drawing.Point(669, 574);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(689, 61);
            this.txtEdad.TabIndex = 7;
            this.txtEdad.Text = "EDAD";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // CrearAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.Fondo_y_texto_323232;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnCrearAlumno);
            this.Controls.Add(this.txtPassCrearAlumno);
            this.Controls.Add(this.txtUsuarioCrearAlumno);
            this.Name = "CrearAlumno";
            this.Text = "CrearAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCrearAlumno;
        private System.Windows.Forms.TextBox txtPassCrearAlumno;
        private System.Windows.Forms.TextBox txtUsuarioCrearAlumno;
        private System.Windows.Forms.TextBox txtEdad;
    }
}