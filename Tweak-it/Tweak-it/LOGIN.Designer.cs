
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
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.ClientSize = new System.Drawing.Size(1162, 867);
            this.Name = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load_1);
            this.ResumeLayout(false);

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