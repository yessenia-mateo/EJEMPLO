namespace Hotel_1
{
    partial class frmPanel_Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanel_Administrador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEmpleadoToolStripMenuItem,
            this.actualizarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registroEmpleadoToolStripMenuItem
            // 
            this.registroEmpleadoToolStripMenuItem.Name = "registroEmpleadoToolStripMenuItem";
            this.registroEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroEmpleadoToolStripMenuItem.Text = "Registro Empleado";
            // 
            // actualizarEmpleadoToolStripMenuItem
            // 
            this.actualizarEmpleadoToolStripMenuItem.Name = "actualizarEmpleadoToolStripMenuItem";
            this.actualizarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.actualizarEmpleadoToolStripMenuItem.Text = "Actualizar Empleado";
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHabitacionesToolStripMenuItem,
            this.alquilarHabitacionesToolStripMenuItem,
            this.reservaHabitacionesToolStripMenuItem,
            this.cancelarAlquilerToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // registrarHabitacionesToolStripMenuItem
            // 
            this.registrarHabitacionesToolStripMenuItem.Name = "registrarHabitacionesToolStripMenuItem";
            this.registrarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registrarHabitacionesToolStripMenuItem.Text = "Registrar Habitaciones";
            // 
            // alquilarHabitacionesToolStripMenuItem
            // 
            this.alquilarHabitacionesToolStripMenuItem.Name = "alquilarHabitacionesToolStripMenuItem";
            this.alquilarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.alquilarHabitacionesToolStripMenuItem.Text = "Alquilar Habitaciones";
            // 
            // reservaHabitacionesToolStripMenuItem
            // 
            this.reservaHabitacionesToolStripMenuItem.Name = "reservaHabitacionesToolStripMenuItem";
            this.reservaHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reservaHabitacionesToolStripMenuItem.Text = "Reserva Habitaciones";
            // 
            // cancelarAlquilerToolStripMenuItem
            // 
            this.cancelarAlquilerToolStripMenuItem.Name = "cancelarAlquilerToolStripMenuItem";
            this.cancelarAlquilerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cancelarAlquilerToolStripMenuItem.Text = "Cancelar Alquiler";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPanel_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 365);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPanel_Administrador";
            this.Text = "frmPanel_Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}