namespace Cap_Presentacion
{
    partial class frmmenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudcantidadventas = new System.Windows.Forms.NumericUpDown();
            this.nudporcentaje_comision = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalario_Neto = new System.Windows.Forms.TextBox();
            this.btnCalcularsalario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonto_venta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalario_base = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudporcentaje_comision)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFemenino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Location = new System.Drawing.Point(157, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(410, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbtnFemenino.Location = new System.Drawing.Point(36, 116);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(140, 30);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbtnMasculino.Location = new System.Drawing.Point(36, 59);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(141, 30);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudcantidadventas);
            this.groupBox2.Controls.Add(this.nudporcentaje_comision);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSalario_Neto);
            this.groupBox2.Controls.Add(this.btnCalcularsalario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtmonto_venta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtsalario_base);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(157, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(698, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salario";
            // 
            // nudcantidadventas
            // 
            this.nudcantidadventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcantidadventas.Location = new System.Drawing.Point(278, 159);
            this.nudcantidadventas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudcantidadventas.Name = "nudcantidadventas";
            this.nudcantidadventas.Size = new System.Drawing.Size(246, 32);
            this.nudcantidadventas.TabIndex = 3;
            // 
            // nudporcentaje_comision
            // 
            this.nudporcentaje_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudporcentaje_comision.Location = new System.Drawing.Point(276, 106);
            this.nudporcentaje_comision.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudporcentaje_comision.Name = "nudporcentaje_comision";
            this.nudporcentaje_comision.Size = new System.Drawing.Size(250, 32);
            this.nudporcentaje_comision.TabIndex = 2;
            this.nudporcentaje_comision.ValueChanged += new System.EventHandler(this.nudporcentaje_comision_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(98, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salario Neto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSalario_Neto
            // 
            this.txtSalario_Neto.BackColor = System.Drawing.Color.Yellow;
            this.txtSalario_Neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario_Neto.ForeColor = System.Drawing.Color.Black;
            this.txtSalario_Neto.Location = new System.Drawing.Point(278, 367);
            this.txtSalario_Neto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSalario_Neto.Name = "txtSalario_Neto";
            this.txtSalario_Neto.ReadOnly = true;
            this.txtSalario_Neto.Size = new System.Drawing.Size(244, 37);
            this.txtSalario_Neto.TabIndex = 6;
            this.txtSalario_Neto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCalcularsalario
            // 
            this.btnCalcularsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularsalario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCalcularsalario.Location = new System.Drawing.Point(278, 281);
            this.btnCalcularsalario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcularsalario.Name = "btnCalcularsalario";
            this.btnCalcularsalario.Size = new System.Drawing.Size(246, 61);
            this.btnCalcularsalario.TabIndex = 5;
            this.btnCalcularsalario.Text = "Calcular Salario";
            this.btnCalcularsalario.UseVisualStyleBackColor = true;
            this.btnCalcularsalario.Click += new System.EventHandler(this.btnCalcularsalario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(98, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto de Venta";
            // 
            // txtmonto_venta
            // 
            this.txtmonto_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonto_venta.Location = new System.Drawing.Point(278, 222);
            this.txtmonto_venta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmonto_venta.Name = "txtmonto_venta";
            this.txtmonto_venta.Size = new System.Drawing.Size(244, 32);
            this.txtmonto_venta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(66, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porcentaje Por Comision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(129, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salario Base";
            // 
            // txtsalario_base
            // 
            this.txtsalario_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario_base.Location = new System.Drawing.Point(276, 56);
            this.txtsalario_base.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtsalario_base.Name = "txtsalario_base";
            this.txtsalario_base.Size = new System.Drawing.Size(244, 32);
            this.txtsalario_base.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(650, 735);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(191, 36);
            this.btnsalir.TabIndex = 21;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Favor ingresar todos los datos";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 972);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmmenu";
            this.Text = "Calculo Planilla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudporcentaje_comision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalario_Neto;
        private System.Windows.Forms.Button btnCalcularsalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmonto_venta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalario_base;
        private System.Windows.Forms.NumericUpDown nudcantidadventas;
        private System.Windows.Forms.NumericUpDown nudporcentaje_comision;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label6;
    }
}

