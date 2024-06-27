namespace Guia13POO
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
            this.btnAtencion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnPreDis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtencion
            // 
            this.btnAtencion.Location = new System.Drawing.Point(260, 1);
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Size = new System.Drawing.Size(244, 98);
            this.btnAtencion.TabIndex = 0;
            this.btnAtencion.Text = "Atencion al Cliente ";
            this.btnAtencion.UseVisualStyleBackColor = true;
            this.btnAtencion.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(238, 19);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(244, 119);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver Resultado";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnPreDis
            // 
            this.btnPreDis.Location = new System.Drawing.Point(238, 180);
            this.btnPreDis.Name = "btnPreDis";
            this.btnPreDis.Size = new System.Drawing.Size(244, 119);
            this.btnPreDis.TabIndex = 3;
            this.btnPreDis.Text = "Preparar Distribucion";
            this.btnPreDis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmpresa);
            this.groupBox1.Controls.Add(this.btnPreDis);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Location = new System.Drawing.Point(22, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Empresa de Distribucion";
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(6, 69);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(226, 20);
            this.tbEmpresa.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtencion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtencion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnPreDis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmpresa;
    }
}

