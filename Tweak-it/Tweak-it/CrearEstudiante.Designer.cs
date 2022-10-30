
namespace Tweak_it
{
    partial class CrearEstudiante
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HideSelection = false;
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNombre.Location = new System.Drawing.Point(770, 353);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(445, 94);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "\r\nNOMBRE";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Silver;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.HideSelection = false;
            this.txtApellido.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtApellido.Location = new System.Drawing.Point(770, 492);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(445, 94);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "\r\nAPELLIDO\r\n";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.Silver;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.HideSelection = false;
            this.txtEdad.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtEdad.Location = new System.Drawing.Point(770, 627);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(445, 94);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.Text = "\r\nEDAD";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdad.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tweak_it.Properties.Resources.boton_crear;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(785, 762);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Tweak_it.Properties.Resources.Frame_1__17_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1725, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CrearEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.Fondo_y_texto_crear_alumno;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearEstudiante";
            this.Text = "CrearEstudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrearEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}