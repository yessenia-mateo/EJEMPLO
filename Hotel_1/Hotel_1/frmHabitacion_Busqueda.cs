using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_1
{
    public partial class frmHabitacion_Busqueda : Form
    {
        clsHabitacion UnObjeto;
        
        private clsHabitacion _HabitacionSeleccionado;
        internal clsHabitacion HabitacionSeleccionado
        {
            get
            {
                return _HabitacionSeleccionado;
            }

            set
            {
                _HabitacionSeleccionado = value;
            }
        }

        

        //Crear un campo para representar a todos los clientes encontrados como 
        //  producto de la búsqueda
        private List<clsHabitacion> _HabitacionesEncontrados = new List<clsHabitacion>();
        internal List<clsHabitacion> HabitacionesEncontrados
        {
            get
            {
                return _HabitacionesEncontrados;
            }

            set
            {
                _HabitacionesEncontrados = value;
            }
        }

        public frmHabitacion_Busqueda()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Busqueda_Load(object sender, EventArgs e)
        {
            InhabilitarControles();
        }

        public void InhabilitarControles()
        {
            txtNroHabitacion.Enabled = false;
            cmbTipoHabitacion.Enabled = false;
            btnAceptar.Enabled = false;
            txtNroHabitacion.Clear();
            cmbTipoHabitacion.Items.Clear();
        }

        private void rtbnNroHabitacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNroHabitacion.Checked==true)
            {
                txtNroHabitacion.Enabled = true;
                btnBuscarHabitacion.Enabled = true;
                btnAceptar.Enabled = true;
            }
            else
            {
                InhabilitarControles();
            }
        }

        private void btnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            if (rbtnTipoHabitacion.Checked==false || rbtnEstadoHabitacion.Checked==false || rbtnNroHabitacion.Checked==false )
            {
                throw new Exception("Escoge una opcion de busqueda");
            }
            else 
            {
                
               
            }
        }
    }
}
