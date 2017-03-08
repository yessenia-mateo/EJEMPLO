namespace Hotel_1
{
    partial class frmHabitacion_Busqueda
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.rbtnTipoHabitacion = new System.Windows.Forms.RadioButton();
            this.rbtnNroHabitacion = new System.Windows.Forms.RadioButton();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarHabitacion = new System.Windows.Forms.Button();
            this.rbtnEstadoHabitacion = new System.Windows.Forms.RadioButton();
            this.txtNroHabitacion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 45);
            this.button3.TabIndex = 21;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(171, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 45);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(157, 71);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoHabitacion.TabIndex = 19;
            // 
            // rbtnTipoHabitacion
            // 
            this.rbtnTipoHabitacion.AutoSize = true;
            this.rbtnTipoHabitacion.Location = new System.Drawing.Point(27, 75);
            this.rbtnTipoHabitacion.Name = "rbtnTipoHabitacion";
            this.rbtnTipoHabitacion.Size = new System.Drawing.Size(106, 17);
            this.rbtnTipoHabitacion.TabIndex = 18;
            this.rbtnTipoHabitacion.TabStop = true;
            this.rbtnTipoHabitacion.Text = "Tipo Habitaccion";
            this.rbtnTipoHabitacion.UseVisualStyleBackColor = true;
            // 
            // rbtnNroHabitacion
            // 
            this.rbtnNroHabitacion.AutoSize = true;
            this.rbtnNroHabitacion.Location = new System.Drawing.Point(27, 47);
            this.rbtnNroHabitacion.Name = "rbtnNroHabitacion";
            this.rbtnNroHabitacion.Size = new System.Drawing.Size(96, 17);
            this.rbtnNroHabitacion.TabIndex = 17;
            this.rbtnNroHabitacion.TabStop = true;
            this.rbtnNroHabitacion.Text = "Nro Habitacion";
            this.rbtnNroHabitacion.UseVisualStyleBackColor = true;
            this.rbtnNroHabitacion.CheckedChanged += new System.EventHandler(this.rtbnNroHabitacion_CheckedChanged);
            // 
            // lstvDatos
            // 
            this.lstvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvDatos.Location = new System.Drawing.Point(12, 135);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(412, 215);
            this.lstvDatos.TabIndex = 16;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            this.lstvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "NRO HABITACION";
            this.columnHeader0.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TIPO HABITACION";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ESTADO";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PISO";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "BUSQUEDA HABITACION";
            // 
            // btnBuscarHabitacion
            // 
            this.btnBuscarHabitacion.Location = new System.Drawing.Point(284, 47);
            this.btnBuscarHabitacion.Name = "btnBuscarHabitacion";
            this.btnBuscarHabitacion.Size = new System.Drawing.Size(95, 45);
            this.btnBuscarHabitacion.TabIndex = 14;
            this.btnBuscarHabitacion.Text = "Busqueda Habitacion";
            this.btnBuscarHabitacion.UseVisualStyleBackColor = true;
            this.btnBuscarHabitacion.Click += new System.EventHandler(this.btnBuscarHabitacion_Click);
            // 
            // rbtnEstadoHabitacion
            // 
            this.rbtnEstadoHabitacion.AutoSize = true;
            this.rbtnEstadoHabitacion.Location = new System.Drawing.Point(27, 98);
            this.rbtnEstadoHabitacion.Name = "rbtnEstadoHabitacion";
            this.rbtnEstadoHabitacion.Size = new System.Drawing.Size(106, 17);
            this.rbtnEstadoHabitacion.TabIndex = 24;
            this.rbtnEstadoHabitacion.TabStop = true;
            this.rbtnEstadoHabitacion.Text = "Tipo Habitaccion";
            this.rbtnEstadoHabitacion.UseVisualStyleBackColor = true;
            // 
            // txtNroHabitacion
            // 
            this.txtNroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroHabitacion.Location = new System.Drawing.Point(157, 44);
            this.txtNroHabitacion.Name = "txtNroHabitacion";
            this.txtNroHabitacion.Size = new System.Drawing.Size(121, 22);
            this.txtNroHabitacion.TabIndex = 23;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(157, 98);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 22);
            this.txtEstado.TabIndex = 25;
            // 
            // frmHabitacion_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 449);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbtnEstadoHabitacion);
            this.Controls.Add(this.txtNroHabitacion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.rbtnTipoHabitacion);
            this.Controls.Add(this.rbtnNroHabitacion);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarHabitacion);
            this.Name = "frmHabitacion_Busqueda";
            this.Text = "frmHabitacion_Busqueda";
            this.Load += new System.EventHandler(this.frmHabitacion_Busqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.RadioButton rbtnTipoHabitacion;
        private System.Windows.Forms.RadioButton rbtnNroHabitacion;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarHabitacion;
        private System.Windows.Forms.RadioButton rbtnEstadoHabitacion;
        private System.Windows.Forms.TextBox txtNroHabitacion;
        private System.Windows.Forms.TextBox txtEstado;
    }
}