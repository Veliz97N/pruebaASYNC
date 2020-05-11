namespace pruebaASYNC
{
    partial class Form1
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnPrender_Apagar = new System.Windows.Forms.Button();
            this.btnSector1 = new System.Windows.Forms.Button();
            this.btnSector2 = new System.Windows.Forms.Button();
            this.btnSector3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(59, 48);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(468, 27);
            this.txtDatos.TabIndex = 0;
            // 
            // btnPrender_Apagar
            // 
            this.btnPrender_Apagar.Location = new System.Drawing.Point(227, 81);
            this.btnPrender_Apagar.Name = "btnPrender_Apagar";
            this.btnPrender_Apagar.Size = new System.Drawing.Size(112, 30);
            this.btnPrender_Apagar.TabIndex = 1;
            this.btnPrender_Apagar.Text = "Prender";
            this.btnPrender_Apagar.UseVisualStyleBackColor = true;
            this.btnPrender_Apagar.Click += new System.EventHandler(this.btnPrender_Apagar_Click);
            // 
            // btnSector1
            // 
            this.btnSector1.Location = new System.Drawing.Point(613, 48);
            this.btnSector1.Name = "btnSector1";
            this.btnSector1.Size = new System.Drawing.Size(75, 23);
            this.btnSector1.TabIndex = 2;
            this.btnSector1.Text = "Sector1";
            this.btnSector1.UseVisualStyleBackColor = true;
            this.btnSector1.Click += new System.EventHandler(this.btnSector1_Click);
            // 
            // btnSector2
            // 
            this.btnSector2.Location = new System.Drawing.Point(613, 109);
            this.btnSector2.Name = "btnSector2";
            this.btnSector2.Size = new System.Drawing.Size(75, 23);
            this.btnSector2.TabIndex = 3;
            this.btnSector2.Text = "Sector2";
            this.btnSector2.UseVisualStyleBackColor = true;
            this.btnSector2.Click += new System.EventHandler(this.btnSector2_Click);
            // 
            // btnSector3
            // 
            this.btnSector3.Location = new System.Drawing.Point(613, 168);
            this.btnSector3.Name = "btnSector3";
            this.btnSector3.Size = new System.Drawing.Size(75, 23);
            this.btnSector3.TabIndex = 4;
            this.btnSector3.Text = "Sector3";
            this.btnSector3.UseVisualStyleBackColor = true;
            this.btnSector3.Click += new System.EventHandler(this.btnSector3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 329);
            this.Controls.Add(this.btnSector3);
            this.Controls.Add(this.btnSector2);
            this.Controls.Add(this.btnSector1);
            this.Controls.Add(this.btnPrender_Apagar);
            this.Controls.Add(this.txtDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnPrender_Apagar;
        private System.Windows.Forms.Button btnSector1;
        private System.Windows.Forms.Button btnSector2;
        private System.Windows.Forms.Button btnSector3;
    }
}

