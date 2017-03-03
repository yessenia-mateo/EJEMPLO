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
    public partial class frmHabitacion_Alquiler : Form
    {
        frmHabitacion_Busqueda x;
        clsRuc UnObjeto;
        private bool _Bandera = false;
        public bool Bandera
        {
            get { return _Bandera; }
            set { _Bandera = value; }
        }
        public frmHabitacion_Alquiler()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Alquiler_Load(object sender, EventArgs e)
        {
            Inhabilitar_ControlesRUC();
        }

        public void Habilitar_ControlesRUC()
        {
            txtRUC.Enabled = true;txtRazonSocial.Enabled = true;  txtDireccion.Enabled = true;
            btnBuscarRuc.Enabled = true; btnGuardarRuc.Enabled = true;
        }

        public void Inhabilitar_ControlesRUC()
        {
            txtRUC.Enabled = false; txtRazonSocial.Enabled = false; txtDireccion.Enabled = false;
            btnBuscarRuc.Enabled = false; btnGuardarRuc.Enabled = false;
            txtRUC.Clear(); txtRazonSocial.Clear(); txtDireccion.Clear();
        }



        private void chkbRuc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbRuc.Checked==true)
            {
                Habilitar_ControlesRUC();
            }
            else
            {
                Inhabilitar_ControlesRUC();
            }
            
        }

        private void btnGuardarCiente_Click(object sender, EventArgs e)
        {
            clsHuesped x ;

            try
            {
                if (rbtMasculino.Checked==true)
                {
                    x = new clsHuesped(txtNroDocIdentidad.Text, txtNombre.Text, txtApellidoPaterno.Text,
                                    txtApellidoMaterno.Text, dtpFechaNacimiento.Value, txtLugarProcedencia.Text
                                    , 'M');
                }
                else if (rbtFemenino.Checked==true)
                {
                    x = new clsHuesped(txtNroDocIdentidad.Text, txtNombre.Text, txtApellidoPaterno.Text,
                                    txtApellidoMaterno.Text, dtpFechaNacimiento.Value, txtLugarProcedencia.Text
                                    , 'F');
                }
                else
                {
                    throw new Exception("Ingrese el genero del cliente");
                }
                
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
                return;
            }
        }

        private void btnBuscarRuc_Click(object sender, EventArgs e)
        {
            UnObjeto = clsRuc.Buscar_PorNumeroRUC(txtRUC.Text);

            if (UnObjeto == null)
            {
                MessageBox.Show("Numero de RUC no encontrado");
                //Preguntar si desea registrar al cliente
                if (MessageBox.Show("¿Desea registrar un nuevo RUC?",
                                  "Confirmación",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) ==
                                  System.Windows.Forms.DialogResult.Yes)
                {
                    txtRazonSocial.Clear(); txtDireccion.Clear();
                    txtRUC.SelectAll(); txtRazonSocial.Focus();

                    //Activar banderita
                    Bandera = true;
                }
            }
            else
            {
                txtRazonSocial.Text = UnObjeto.RazonSocial;
                txtDireccion.Text = UnObjeto.DireccionRuc;
            }
        }

        private void btnBusqueda_Habitacion_Click(object sender, EventArgs e)
        {
            x = new frmHabitacion_Busqueda();

            //Llamar al formulario como Modal            
            x.ShowDialog();
            if (x.HabitacionSelecionada == null)
            {
                MessageBox.Show("La búsqueda fue cancelada");
            }
            else
            {
                txtNombres.Text = x.ClienteSeleccionado.Nombres;
                txtApellidos.Text = x.ClienteSeleccionado.Apellidos;
                if (x.ClienteSeleccionado.Sexo == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }
                nudSueldo.Value = Convert.ToDecimal(x.ClienteSeleccionado.Sueldo);
            }
        }
    }
}
