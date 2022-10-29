
namespace Tweak_it
{
    partial class LOGIN_PROFESOR
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLOGIN_PROF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Silver;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.HideSelection = false;
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUser.Location = new System.Drawing.Point(686, 475);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(517, 33);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "USUARIO";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Silver;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.HideSelection = false;
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPass.Location = new System.Drawing.Point(686, 543);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(517, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnLOGIN_PROF
            // 
            this.btnLOGIN_PROF.BackColor = System.Drawing.Color.Transparent;
            this.btnLOGIN_PROF.BackgroundImage = global::Tweak_it.Properties.Resources.Boton_listo_v2_removebg_preview;
            this.btnLOGIN_PROF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLOGIN_PROF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLOGIN_PROF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN_PROF.Location = new System.Drawing.Point(739, 691);
            this.btnLOGIN_PROF.Name = "btnLOGIN_PROF";
            this.btnLOGIN_PROF.Size = new System.Drawing.Size(404, 115);
            this.btnLOGIN_PROF.TabIndex = 3;
            this.btnLOGIN_PROF.UseVisualStyleBackColor = false;
            this.btnLOGIN_PROF.Click += new System.EventHandler(this.btnLOGIN_PROF_Click);
            // 
            // LOGIN_PROFESOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___texto1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLOGIN_PROF);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN_PROFESOR";
            this.Text = "Crear_Usuario";
            this.Load += new System.EventHandler(this.LOGIN_PROFESOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLOGIN_PROF;
    }
}