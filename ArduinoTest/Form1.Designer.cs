namespace ArduinoTest
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
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblestadoboton = new System.Windows.Forms.Label();
            this.txtComs = new System.Windows.Forms.TextBox();
            this.btnLEDon = new System.Windows.Forms.Button();
            this.btnLEDoff = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(12, 48);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(75, 23);
            this.btnon.TabIndex = 0;
            this.btnon.Text = "Conectar";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(103, 48);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(75, 23);
            this.btnoff.TabIndex = 1;
            this.btnoff.Text = "Desconectar";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(22, 13);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado";
            // 
            // lblestadoboton
            // 
            this.lblestadoboton.AutoSize = true;
            this.lblestadoboton.Location = new System.Drawing.Point(9, 174);
            this.lblestadoboton.Name = "lblestadoboton";
            this.lblestadoboton.Size = new System.Drawing.Size(87, 13);
            this.lblestadoboton.TabIndex = 3;
            this.lblestadoboton.Text = "Estado del boton";
            // 
            // txtComs
            // 
            this.txtComs.Location = new System.Drawing.Point(241, 12);
            this.txtComs.Multiline = true;
            this.txtComs.Name = "txtComs";
            this.txtComs.Size = new System.Drawing.Size(471, 237);
            this.txtComs.TabIndex = 4;
            // 
            // btnLEDon
            // 
            this.btnLEDon.Location = new System.Drawing.Point(12, 110);
            this.btnLEDon.Name = "btnLEDon";
            this.btnLEDon.Size = new System.Drawing.Size(100, 23);
            this.btnLEDon.TabIndex = 5;
            this.btnLEDon.Text = "Encender LED";
            this.btnLEDon.UseVisualStyleBackColor = true;
            this.btnLEDon.Click += new System.EventHandler(this.btnLEDon_Click);
            // 
            // btnLEDoff
            // 
            this.btnLEDoff.Location = new System.Drawing.Point(123, 110);
            this.btnLEDoff.Name = "btnLEDoff";
            this.btnLEDoff.Size = new System.Drawing.Size(86, 23);
            this.btnLEDoff.TabIndex = 6;
            this.btnLEDoff.Text = "Apagar LED";
            this.btnLEDoff.UseVisualStyleBackColor = true;
            this.btnLEDoff.Click += new System.EventHandler(this.btnLEDoff_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 200);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 261);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnLEDoff);
            this.Controls.Add(this.btnLEDon);
            this.Controls.Add(this.txtComs);
            this.Controls.Add(this.lblestadoboton);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.btnon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblestadoboton;
        private System.Windows.Forms.TextBox txtComs;
        private System.Windows.Forms.Button btnLEDon;
        private System.Windows.Forms.Button btnLEDoff;
        private System.Windows.Forms.Label lblmsg;
    }
}

