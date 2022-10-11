namespace Tweak_it
{
    partial class j1pictosN1
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
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB4 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).BeginInit();
            this.SuspendLayout();
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(508, 53);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(170, 136);
            this.pB1.TabIndex = 0;
            this.pB1.TabStop = false;
            this.pB1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pB2
            // 
            this.pB2.Location = new System.Drawing.Point(63, 331);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(182, 138);
            this.pB2.TabIndex = 1;
            this.pB2.TabStop = false;
            this.pB2.Click += new System.EventHandler(this.pB2_Click);
            // 
            // pB3
            // 
            this.pB3.Location = new System.Drawing.Point(483, 331);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(182, 138);
            this.pB3.TabIndex = 2;
            this.pB3.TabStop = false;
            this.pB3.Click += new System.EventHandler(this.pB3_Click);
            // 
            // pB4
            // 
            this.pB4.Location = new System.Drawing.Point(888, 331);
            this.pB4.Name = "pB4";
            this.pB4.Size = new System.Drawing.Size(182, 138);
            this.pB4.TabIndex = 3;
            this.pB4.TabStop = false;
            this.pB4.Click += new System.EventHandler(this.pB4_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(63, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 63);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // j1pictosN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Name = "j1pictosN1";
            this.Text = "j1pictos";
            this.Load += new System.EventHandler(this.j1pictos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.PictureBox pB4;
        private System.Windows.Forms.Button btnAtras;
    }
}