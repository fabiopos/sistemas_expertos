namespace SECarros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbMaleteroP = new System.Windows.Forms.RadioButton();
            this.rbMaleteroM = new System.Windows.Forms.RadioButton();
            this.rbMaleteroG = new System.Windows.Forms.RadioButton();
            this.txtCaballos = new System.Windows.Forms.TextBox();
            this.rbAbsSi = new System.Windows.Forms.RadioButton();
            this.rbAbsNo = new System.Windows.Forms.RadioButton();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que cantidad en EUR desea gastarse?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Busca maletero pequeño, mediano o grande (p|m|g)?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Como minimo cuantos caballos debe tener el coche?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desea ABS (s|n)?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Como maximo, ¿Que consumo debe tener el coche a los 100 km?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(145, 81);
            this.txtPrecio.MaxLength = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(314, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.Text = "13000";
            // 
            // rbMaleteroP
            // 
            this.rbMaleteroP.AutoSize = true;
            this.rbMaleteroP.Location = new System.Drawing.Point(145, 165);
            this.rbMaleteroP.Name = "rbMaleteroP";
            this.rbMaleteroP.Size = new System.Drawing.Size(67, 17);
            this.rbMaleteroP.TabIndex = 7;
            this.rbMaleteroP.TabStop = true;
            this.rbMaleteroP.Text = "pequeño";
            this.rbMaleteroP.UseVisualStyleBackColor = true;
            // 
            // rbMaleteroM
            // 
            this.rbMaleteroM.AutoSize = true;
            this.rbMaleteroM.Location = new System.Drawing.Point(247, 165);
            this.rbMaleteroM.Name = "rbMaleteroM";
            this.rbMaleteroM.Size = new System.Drawing.Size(65, 17);
            this.rbMaleteroM.TabIndex = 8;
            this.rbMaleteroM.TabStop = true;
            this.rbMaleteroM.Text = "mediano";
            this.rbMaleteroM.UseVisualStyleBackColor = true;
            // 
            // rbMaleteroG
            // 
            this.rbMaleteroG.AutoSize = true;
            this.rbMaleteroG.Checked = true;
            this.rbMaleteroG.Location = new System.Drawing.Point(353, 165);
            this.rbMaleteroG.Name = "rbMaleteroG";
            this.rbMaleteroG.Size = new System.Drawing.Size(58, 17);
            this.rbMaleteroG.TabIndex = 9;
            this.rbMaleteroG.TabStop = true;
            this.rbMaleteroG.Text = "grande";
            this.rbMaleteroG.UseVisualStyleBackColor = true;
            // 
            // txtCaballos
            // 
            this.txtCaballos.Location = new System.Drawing.Point(145, 238);
            this.txtCaballos.MaxLength = 3;
            this.txtCaballos.Name = "txtCaballos";
            this.txtCaballos.Size = new System.Drawing.Size(314, 20);
            this.txtCaballos.TabIndex = 10;
            this.txtCaballos.Text = "79";
            // 
            // rbAbsSi
            // 
            this.rbAbsSi.AutoSize = true;
            this.rbAbsSi.Checked = true;
            this.rbAbsSi.Location = new System.Drawing.Point(15, 38);
            this.rbAbsSi.Name = "rbAbsSi";
            this.rbAbsSi.Size = new System.Drawing.Size(36, 17);
            this.rbAbsSi.TabIndex = 11;
            this.rbAbsSi.TabStop = true;
            this.rbAbsSi.Text = "Sí";
            this.rbAbsSi.UseVisualStyleBackColor = true;
            // 
            // rbAbsNo
            // 
            this.rbAbsNo.AutoSize = true;
            this.rbAbsNo.Location = new System.Drawing.Point(71, 38);
            this.rbAbsNo.Name = "rbAbsNo";
            this.rbAbsNo.Size = new System.Drawing.Size(39, 17);
            this.rbAbsNo.TabIndex = 12;
            this.rbAbsNo.TabStop = true;
            this.rbAbsNo.Text = "No";
            this.rbAbsNo.UseVisualStyleBackColor = true;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(145, 386);
            this.txtConsumo.MaxLength = 2;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(314, 20);
            this.txtConsumo.TabIndex = 13;
            this.txtConsumo.Text = "9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAbsSi);
            this.groupBox1.Controls.Add(this.rbAbsNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(141, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 69);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(145, 527);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 20);
            this.lblRespuesta.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 620);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtCaballos);
            this.Controls.Add(this.rbMaleteroG);
            this.Controls.Add(this.rbMaleteroM);
            this.Controls.Add(this.rbMaleteroP);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbMaleteroP;
        private System.Windows.Forms.RadioButton rbMaleteroM;
        private System.Windows.Forms.RadioButton rbMaleteroG;
        private System.Windows.Forms.TextBox txtCaballos;
        private System.Windows.Forms.RadioButton rbAbsSi;
        private System.Windows.Forms.RadioButton rbAbsNo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

