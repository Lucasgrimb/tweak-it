
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HideSelection = false;
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNombre.Location = new System.Drawing.Point(837, 297);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 39);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "\r\nNOMBRE";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Silver;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtApellido.Location = new System.Drawing.Point(837, 358);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(303, 39);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "\r\nAPELLIDO";
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
            this.btnAlegre.Location = new System.Drawing.Point(420, 549);
            this.btnAlegre.Name = "btnAlegre";
            this.btnAlegre.Size = new System.Drawing.Size(350, 350);
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
            this.btnTriste.Location = new System.Drawing.Point(813, 549);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(350, 350);
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
            this.btnEnojado.Location = new System.Drawing.Point(1208, 549);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(350, 350);
            this.btnEnojado.TabIndex = 4;
            this.btnEnojado.UseVisualStyleBackColor = false;
            this.btnEnojado.Click += new System.EventHandler(this.btnEnojado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tweak_it.Properties.Resources.Profesor_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1650, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 140);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___textos1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnojado);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnAlegre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAlegre;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnEnojado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}