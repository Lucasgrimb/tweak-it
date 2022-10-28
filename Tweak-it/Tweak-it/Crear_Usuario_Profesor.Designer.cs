
namespace Tweak_it
{
    partial class Crear_Usuario_Profesor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(174, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresa los datos del profesor";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(291, 186);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 20);
            this.txtname.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(291, 233);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(188, 20);
            this.txtPass.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(216, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(200, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crear_Usuario_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Crear_Usuario_Profesor";
            this.Text = "Crear_Usuario_Profesor";
            this.Load += new System.EventHandler(this.Crear_Usuario_Profesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}