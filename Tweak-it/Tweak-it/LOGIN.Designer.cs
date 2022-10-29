
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
            this.btnAlegre = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnEnojado = new System.Windows.Forms.Button();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.txtNombre.Location = new System.Drawing.Point(780, 292);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 39);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Silver;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.HideSelection = false;
            this.txtApellido.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtApellido.Location = new System.Drawing.Point(780, 345);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(404, 35);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "APELLIDO";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // btnAlegre
            // 
            this.btnAlegre.BackColor = System.Drawing.Color.Transparent;
            this.btnAlegre.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_contento1;
            this.btnAlegre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlegre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlegre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlegre.Location = new System.Drawing.Point(422, 489);
            this.btnAlegre.Name = "btnAlegre";
            this.btnAlegre.Size = new System.Drawing.Size(350, 300);
            this.btnAlegre.TabIndex = 2;
            this.btnAlegre.UseVisualStyleBackColor = false;
            this.btnAlegre.Click += new System.EventHandler(this.btnAlegre_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.BackColor = System.Drawing.Color.Transparent;
            this.btnTriste.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_triste1;
            this.btnTriste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTriste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriste.Location = new System.Drawing.Point(815, 489);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(350, 300);
            this.btnTriste.TabIndex = 3;
            this.btnTriste.UseVisualStyleBackColor = false;
            this.btnTriste.Click += new System.EventHandler(this.btnTriste_Click);
            // 
            // btnEnojado
            // 
            this.btnEnojado.BackColor = System.Drawing.Color.Transparent;
            this.btnEnojado.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_enojado1;
            this.btnEnojado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnojado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnojado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnojado.Location = new System.Drawing.Point(1210, 489);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(350, 300);
            this.btnEnojado.TabIndex = 4;
            this.btnEnojado.UseVisualStyleBackColor = false;
            this.btnEnojado.Click += new System.EventHandler(this.btnEnojado_Click);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.btnLOGIN.BackgroundImage = global::Tweak_it.Properties.Resources.Boton_listo_v2_removebg_preview;
            this.btnLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLOGIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN.Location = new System.Drawing.Point(811, 830);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(358, 95);
            this.btnLOGIN.TabIndex = 5;
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tweak_it.Properties.Resources.Profesor_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1602, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 151);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___textos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.btnEnojado);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnAlegre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_Load);
<<<<<<< Updated upstream
=======
            this.TextChanged += new System.EventHandler(this.LOGIN_TextChanged);
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAlegre;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnEnojado;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.Button button1;
    }
}