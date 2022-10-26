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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlegre = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnEnojado = new System.Windows.Forms.Button();
            this.btnCrear_Usuario = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(787, 210);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(257, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(770, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Como te llamas?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(742, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Como te sientes hoy?";
            // 
            // btnAlegre
            // 
            this.btnAlegre.Location = new System.Drawing.Point(676, 491);
            this.btnAlegre.Name = "btnAlegre";
            this.btnAlegre.Size = new System.Drawing.Size(132, 108);
            this.btnAlegre.TabIndex = 4;
            this.btnAlegre.Text = "Alegre";
            this.btnAlegre.UseVisualStyleBackColor = true;
            this.btnAlegre.Click += new System.EventHandler(this.btnAlegre_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.Location = new System.Drawing.Point(856, 491);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(132, 108);
            this.btnTriste.TabIndex = 5;
            this.btnTriste.Text = "Triste";
            this.btnTriste.UseVisualStyleBackColor = true;
            this.btnTriste.Click += new System.EventHandler(this.btnTriste_Click);
            // 
            // btnEnojado
            // 
            this.btnEnojado.Location = new System.Drawing.Point(1040, 491);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(132, 108);
            this.btnEnojado.TabIndex = 6;
            this.btnEnojado.Text = "Enojado";
            this.btnEnojado.UseVisualStyleBackColor = true;
            this.btnEnojado.Click += new System.EventHandler(this.btnEnojado_Click);
            // 
            // btnCrear_Usuario
            // 
            this.btnCrear_Usuario.Location = new System.Drawing.Point(856, 661);
            this.btnCrear_Usuario.Name = "btnCrear_Usuario";
            this.btnCrear_Usuario.Size = new System.Drawing.Size(132, 57);
            this.btnCrear_Usuario.TabIndex = 7;
            this.btnCrear_Usuario.Text = "Crear Usuario";
            this.btnCrear_Usuario.UseVisualStyleBackColor = true;
            this.btnCrear_Usuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(787, 284);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(257, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(714, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(714, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1735, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Profesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.btnCrear_Usuario);
            this.Controls.Add(this.btnEnojado);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnAlegre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlegre;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnEnojado;
        private System.Windows.Forms.Button btnCrear_Usuario;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}