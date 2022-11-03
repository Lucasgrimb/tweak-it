
namespace Tweak_it
{
    partial class LOGIN
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnContento = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnEnojado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(722, 301);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(534, 33);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(722, 350);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(534, 33);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "APELLIDO";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tweak_it.Properties.Resources.Frame_1__17_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1725, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Tweak_it.Properties.Resources.Profesor1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1642, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 141);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContento
            // 
            this.btnContento.BackColor = System.Drawing.Color.Transparent;
            this.btnContento.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_contento;
            this.btnContento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContento.Location = new System.Drawing.Point(413, 523);
            this.btnContento.Name = "btnContento";
            this.btnContento.Size = new System.Drawing.Size(349, 338);
            this.btnContento.TabIndex = 4;
            this.btnContento.UseVisualStyleBackColor = false;
            this.btnContento.Click += new System.EventHandler(this.btnContento_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.BackColor = System.Drawing.Color.Transparent;
            this.btnTriste.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_triste;
            this.btnTriste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTriste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriste.Location = new System.Drawing.Point(812, 523);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(349, 338);
            this.btnTriste.TabIndex = 5;
            this.btnTriste.UseVisualStyleBackColor = false;
            this.btnTriste.Click += new System.EventHandler(this.btnTriste_Click);
            // 
            // btnEnojado
            // 
            this.btnEnojado.BackColor = System.Drawing.Color.Transparent;
            this.btnEnojado.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_enojado;
            this.btnEnojado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnojado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnojado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnojado.Location = new System.Drawing.Point(1205, 523);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(349, 338);
            this.btnEnojado.TabIndex = 6;
            this.btnEnojado.UseVisualStyleBackColor = false;
            this.btnEnojado.Click += new System.EventHandler(this.btnEnojado_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___textos_estudiantes;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnEnojado);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnContento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnContento;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnEnojado;
    }
}