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
            this.txtpassPROF = new System.Windows.Forms.TextBox();
            this.txtnombrePROF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtpassPROF
            // 
            this.txtpassPROF.BackColor = System.Drawing.Color.LightGray;
            this.txtpassPROF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassPROF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassPROF.ForeColor = System.Drawing.Color.DimGray;
            this.txtpassPROF.Location = new System.Drawing.Point(586, 521);
            this.txtpassPROF.Multiline = true;
            this.txtpassPROF.Name = "txtpassPROF";
            this.txtpassPROF.Size = new System.Drawing.Size(727, 48);
            this.txtpassPROF.TabIndex = 3;
            this.txtpassPROF.Text = "\r\nCONTRASEÑA";
            this.txtpassPROF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassPROF.Enter += new System.EventHandler(this.txtpassPROF_Enter);
            this.txtpassPROF.Leave += new System.EventHandler(this.txtpassPROF_Leave);
            // 
            // txtnombrePROF
            // 
            this.txtnombrePROF.BackColor = System.Drawing.Color.LightGray;
            this.txtnombrePROF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrePROF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrePROF.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombrePROF.Location = new System.Drawing.Point(586, 433);
            this.txtnombrePROF.Multiline = true;
            this.txtnombrePROF.Name = "txtnombrePROF";
            this.txtnombrePROF.Size = new System.Drawing.Size(727, 48);
            this.txtnombrePROF.TabIndex = 2;
            this.txtnombrePROF.Text = "\r\nUSUARIO";
            this.txtnombrePROF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombrePROF.Enter += new System.EventHandler(this.txtnombrePROF_Enter);
            this.txtnombrePROF.Leave += new System.EventHandler(this.txtnombrePROF_Leave);
            // 
            // LOGIN_PROFESOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tweak_it.Properties.Resources.fondo___texto1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtpassPROF);
            this.Controls.Add(this.txtnombrePROF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN_PROFESOR";
            this.Text = "LOGIN_PROFESOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassPROF;
        private System.Windows.Forms.TextBox txtnombrePROF;
    }
}