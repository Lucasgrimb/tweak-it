namespace Tweak_it
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAlegre = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnEnojado = new System.Windows.Forms.Button();
            this.btnCrear_Usuario = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnombre.Location = new System.Drawing.Point(744, 301);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(477, 39);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "\r\nNOMBRE DE ESTUDIANTE";
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAlegre
            // 
            this.btnAlegre.BackColor = System.Drawing.Color.Transparent;
            this.btnAlegre.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_contento;
            this.btnAlegre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlegre.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlegre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlegre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlegre.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlegre.Location = new System.Drawing.Point(458, 520);
            this.btnAlegre.Name = "btnAlegre";
            this.btnAlegre.Size = new System.Drawing.Size(306, 256);
            this.btnAlegre.TabIndex = 4;
            this.btnAlegre.UseVisualStyleBackColor = false;
            this.btnAlegre.Click += new System.EventHandler(this.btnAlegre_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.BackColor = System.Drawing.Color.Transparent;
            this.btnTriste.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_triste;
            this.btnTriste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTriste.FlatAppearance.BorderSize = 0;
            this.btnTriste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriste.Location = new System.Drawing.Point(814, 520);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(306, 256);
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
            this.btnEnojado.Location = new System.Drawing.Point(1157, 520);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(306, 256);
            this.btnEnojado.TabIndex = 6;
            this.btnEnojado.UseVisualStyleBackColor = false;
            this.btnEnojado.Click += new System.EventHandler(this.btnEnojado_Click);
            // 
            // btnCrear_Usuario
            // 
            this.btnCrear_Usuario.BackgroundImage = global::Tweak_it.Properties.Resources.Listo_1;
            this.btnCrear_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrear_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear_Usuario.Location = new System.Drawing.Point(894, 816);
            this.btnCrear_Usuario.Name = "btnCrear_Usuario";
            this.btnCrear_Usuario.Size = new System.Drawing.Size(132, 57);
            this.btnCrear_Usuario.TabIndex = 7;
            this.btnCrear_Usuario.UseVisualStyleBackColor = true;
            this.btnCrear_Usuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.DarkGray;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtapellido.Location = new System.Drawing.Point(744, 355);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(477, 39);
            this.txtapellido.TabIndex = 8;
            this.txtapellido.Text = "\r\nAPELLIDO DEL ESTUDIANTE";
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tweak_it.Properties.Resources.Profesor;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1656, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 87);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___textos;
            this.ClientSize = new System.Drawing.Size(1649, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.btnCrear_Usuario);
            this.Controls.Add(this.btnEnojado);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnAlegre);
            this.Controls.Add(this.txtnombre);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAlegre;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnEnojado;
        private System.Windows.Forms.Button btnCrear_Usuario;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button button1;
    }
}