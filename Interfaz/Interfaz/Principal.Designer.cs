namespace Interfaz
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSanjose = new System.Windows.Forms.Button();
            this.btnAlajuela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Pronostico";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSanjose
            // 
            this.btnSanjose.Location = new System.Drawing.Point(328, 118);
            this.btnSanjose.Name = "btnSanjose";
            this.btnSanjose.Size = new System.Drawing.Size(75, 23);
            this.btnSanjose.TabIndex = 2;
            this.btnSanjose.Text = "San Jose";
            this.btnSanjose.UseVisualStyleBackColor = true;
            this.btnSanjose.Click += new System.EventHandler(this.btnSanjose_Click);
            // 
            // btnAlajuela
            // 
            this.btnAlajuela.Location = new System.Drawing.Point(423, 117);
            this.btnAlajuela.Name = "btnAlajuela";
            this.btnAlajuela.Size = new System.Drawing.Size(75, 23);
            this.btnAlajuela.TabIndex = 3;
            this.btnAlajuela.Text = "Alajuela";
            this.btnAlajuela.UseVisualStyleBackColor = true;
            this.btnAlajuela.Click += new System.EventHandler(this.btnAlajuela_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 508);
            this.Controls.Add(this.btnAlajuela);
            this.Controls.Add(this.btnSanjose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSanjose;
        private System.Windows.Forms.Button btnAlajuela;
    }
}

