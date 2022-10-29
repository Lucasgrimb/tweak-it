
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.contento = new System.Windows.Forms.Button();
            this.triste = new System.Windows.Forms.Button();
            this.enojado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtname.ForeColor = System.Drawing.Color.DimGray;
            this.txtname.Location = new System.Drawing.Point(841, 301);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(305, 34);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "NOMBRE";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtape
            // 
            this.txtape.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtape.ForeColor = System.Drawing.Color.DimGray;
            this.txtape.Location = new System.Drawing.Point(841, 355);
            this.txtape.Multiline = true;
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(305, 34);
            this.txtape.TabIndex = 1;
            this.txtape.Text = "APELLIDO";
            this.txtape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtape.Enter += new System.EventHandler(this.txtape_Enter);
            this.txtape.Leave += new System.EventHandler(this.txtape_Leave);
            // 
            // contento
            // 
            this.contento.BackColor = System.Drawing.Color.Transparent;
            this.contento.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_contento;
            this.contento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contento.Location = new System.Drawing.Point(422, 498);
            this.contento.Name = "contento";
            this.contento.Size = new System.Drawing.Size(360, 326);
            this.contento.TabIndex = 2;
            this.contento.UseVisualStyleBackColor = false;
            this.contento.Click += new System.EventHandler(this.contento_Click);
            // 
            // triste
            // 
            this.triste.BackColor = System.Drawing.Color.Transparent;
            this.triste.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_triste;
            this.triste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.triste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triste.Location = new System.Drawing.Point(819, 498);
            this.triste.Name = "triste";
            this.triste.Size = new System.Drawing.Size(360, 326);
            this.triste.TabIndex = 3;
            this.triste.UseVisualStyleBackColor = false;
            this.triste.Click += new System.EventHandler(this.triste_Click);
            // 
            // enojado
            // 
            this.enojado.BackColor = System.Drawing.Color.Transparent;
            this.enojado.BackgroundImage = global::Tweak_it.Properties.Resources.Chico_exprecion_enojado;
            this.enojado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enojado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enojado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enojado.Location = new System.Drawing.Point(1221, 498);
            this.enojado.Name = "enojado";
            this.enojado.Size = new System.Drawing.Size(360, 326);
            this.enojado.TabIndex = 4;
            this.enojado.UseVisualStyleBackColor = false;
            this.enojado.Click += new System.EventHandler(this.enojado_Click);
            // 
            // LOGIN
            // 
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___textos_estudiantes;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.enojado);
            this.Controls.Add(this.triste);
            this.Controls.Add(this.contento);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.Button contento;
        private System.Windows.Forms.Button triste;
        private System.Windows.Forms.Button enojado;
    }
}