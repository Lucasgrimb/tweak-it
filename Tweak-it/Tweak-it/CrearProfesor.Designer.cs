
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Silver;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.HideSelection = false;
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPass.Location = new System.Drawing.Point(742, 556);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(445, 94);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "\r\nCONTRASEÑA";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Silver;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.HideSelection = false;
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUser.Location = new System.Drawing.Point(742, 391);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(445, 94);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "\r\nUSUARIO";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tweak_it.Properties.Resources.boton_crear;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(774, 725);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CrearProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo_y_texto_crear_Profesor;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProfesor";
            this.Text = "CrearProfesor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}