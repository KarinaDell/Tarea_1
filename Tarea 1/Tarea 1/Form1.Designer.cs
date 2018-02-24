namespace Tarea_1
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAjustarFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.bit6 = new System.Windows.Forms.PictureBox();
            this.bitBrujula = new System.Windows.Forms.PictureBox();
            this.bit7 = new System.Windows.Forms.PictureBox();
            this.bitLlenado = new System.Windows.Forms.PictureBox();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBrujula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitLlenado)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(98, 49);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 26);
            this.txtEntrada.TabIndex = 1;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(22, 52);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 20);
            this.lblEntrada.TabIndex = 2;
            this.lblEntrada.Text = "Entrada:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(222, 49);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(104, 26);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor1.Location = new System.Drawing.Point(19, 105);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(73, 20);
            this.lblSensor1.TabIndex = 2;
            this.lblSensor1.Text = "Sensor 1";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(377, 105);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(118, 20);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel de tanque";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(551, 105);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(42, 284);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha lectura";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(22, 376);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(62, 20);
            this.lblSelectDate.TabIndex = 2;
            this.lblSelectDate.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnAjustarFecha
            // 
            this.btnAjustarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustarFecha.Location = new System.Drawing.Point(305, 372);
            this.btnAjustarFecha.Name = "btnAjustarFecha";
            this.btnAjustarFecha.Size = new System.Drawing.Size(100, 31);
            this.btnAjustarFecha.TabIndex = 5;
            this.btnAjustarFecha.Text = "Ajustar";
            this.btnAjustarFecha.UseVisualStyleBackColor = true;
            this.btnAjustarFecha.Click += new System.EventHandler(this.btnAjustarFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Enabled = false;
            this.txtFechaSalida.Location = new System.Drawing.Point(113, 430);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(168, 20);
            this.txtFechaSalida.TabIndex = 7;
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor2.Location = new System.Drawing.Point(183, 105);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(73, 20);
            this.lblSensor2.TabIndex = 2;
            this.lblSensor2.Text = "Sensor 2";
            // 
            // bit6
            // 
            this.bit6.Image = global::Tarea_1.Properties.Resources.loading;
            this.bit6.Location = new System.Drawing.Point(204, 141);
            this.bit6.Name = "bit6";
            this.bit6.Size = new System.Drawing.Size(122, 122);
            this.bit6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bit6.TabIndex = 0;
            this.bit6.TabStop = false;
            // 
            // bitBrujula
            // 
            this.bitBrujula.Image = global::Tarea_1.Properties.Resources.loading;
            this.bitBrujula.Location = new System.Drawing.Point(585, 141);
            this.bitBrujula.Name = "bitBrujula";
            this.bitBrujula.Size = new System.Drawing.Size(122, 122);
            this.bitBrujula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bitBrujula.TabIndex = 0;
            this.bitBrujula.TabStop = false;
            // 
            // bit7
            // 
            this.bit7.Image = global::Tarea_1.Properties.Resources.loading;
            this.bit7.Location = new System.Drawing.Point(26, 141);
            this.bit7.Name = "bit7";
            this.bit7.Size = new System.Drawing.Size(122, 122);
            this.bit7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bit7.TabIndex = 0;
            this.bit7.TabStop = false;
            // 
            // bitLlenado
            // 
            this.bitLlenado.Image = global::Tarea_1.Properties.Resources.loading;
            this.bitLlenado.Location = new System.Drawing.Point(394, 141);
            this.bitLlenado.Name = "bitLlenado";
            this.bitLlenado.Size = new System.Drawing.Size(122, 122);
            this.bitLlenado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bitLlenado.TabIndex = 0;
            this.bitLlenado.TabStop = false;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(165, 285);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(0, 18);
            this.lblFechaSalida.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 533);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjustarFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblSensor2);
            this.Controls.Add(this.lblSensor1);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.bit6);
            this.Controls.Add(this.bitBrujula);
            this.Controls.Add(this.bit7);
            this.Controls.Add(this.bitLlenado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Karina";
            ((System.ComponentModel.ISupportInitialize)(this.bit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBrujula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitLlenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox bitLlenado;
        private System.Windows.Forms.PictureBox bit7;
        private System.Windows.Forms.PictureBox bitBrujula;
        private System.Windows.Forms.PictureBox bit6;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAjustarFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label lblFechaSalida;
    }
}

