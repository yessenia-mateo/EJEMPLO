using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_1
{
    class clsEmpleado
    {
        //CREACIÓN DE CAMPOS:
        private Int32 _idEmpleado;
        private string _documentoIdentidadEmpleado;
        private string _nombresEmpleado;
        private string _apellidoPaternoEmpleado;
        private string _apellidoMaternoEmpleado;
        private string _direccionEmpleado;
        private string _telefonoEmpleado;
        private string _celularEmpleado;
        private decimal _sueldoEmpleado;
        private bool _generoEmpleado;
        private string _turnoEmpleado;
        private string _correoElectronicoEmpleado;

        //CREACIÓN DEL CONSTRUCTOR:
        public clsEmpleado(string parametroDocumentoIdentidadEmpleado,
                           string parametroNombresEmpleado,
                           string parametroApellidoPaternoEmpleado,
                           string parametroApellidoMaternoEmpleado,
                           string parametroDireccionEmpleado,
                           decimal parametroSueldoEmpleado,
                           bool parametroGeneroEmpleado,
                           string parametroTurnoEmpleado)
        {
            DocumentoIdentidadEmpleado = parametroDocumentoIdentidadEmpleado;
            NombresEmpleado = parametroNombresEmpleado;
            ApellidoPaternoEmpleado = parametroApellidoPaternoEmpleado;
            ApellidoMaternoEmpleado = parametroApellidoMaternoEmpleado;
            DireccionEmpleado = parametroDireccionEmpleado;
            SueldoEmpleado = parametroSueldoEmpleado;
            GeneroEmpleado = parametroGeneroEmpleado;
            TurnoEmpleado = parametroTurnoEmpleado;
        }

        //CREACIÓN DE PROPIEDADES:
        public Int32 IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        public string DocumentoIdentidadEmpleado
        {
            get { return _documentoIdentidadEmpleado; }
            set { _documentoIdentidadEmpleado = value; }
        }
        public string NombresEmpleado
        {
            get { return _nombresEmpleado; }
            set { _nombresEmpleado = value; }
        }
        public string ApellidoPaternoEmpleado
        {
            get { return _apellidoPaternoEmpleado; }
            set { _apellidoPaternoEmpleado = value; }
        }
        public string ApellidoMaternoEmpleado
        {
            get { return _apellidoMaternoEmpleado; }
            set { _apellidoMaternoEmpleado = value; }
        }
        public string DireccionEmpleado
        {
            get { return _direccionEmpleado; }
            set { _direccionEmpleado = value; }
        }
        public string TelefonoEmpleado
        {
            get { return _telefonoEmpleado; }
            set { _telefonoEmpleado = value; }
        }
        public string CelularEmpleado
        {
            get { return _celularEmpleado; }
            set { _celularEmpleado = value; }
        }
        public decimal SueldoEmpleado
        {
            get { return _sueldoEmpleado; }
            set { _sueldoEmpleado = value; }
        }
        public bool GeneroEmpleado
        {
            get { return _generoEmpleado; }
            set { _generoEmpleado = value; }
        }
        public string TurnoEmpleado
        {
            get { return _turnoEmpleado; }
            set { _turnoEmpleado = value; }
        }
        public string CorreoElectronicoEmpleado
        {
            get { return _correoElectronicoEmpleado; }
            set { _correoElectronicoEmpleado = value; }
        }
        //CREACIÓN DEL MÉTODO:
        public void Insertar_Empleado()
        {
            SqlConnection conexion;
            conexion = new SqlConnection("SERVER=.;DATABASE=Proyecto_Hotel;USER=sa;PWD=continental");
            SqlCommand comando;
            //No importa el orden
            comando = new SqlCommand("usp_Empleado_Insertar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametroDocumentoIdentidadEmpleado", DocumentoIdentidadEmpleado);
            comando.Parameters.AddWithValue("@parametroNombresEmpleado", NombresEmpleado);
            comando.Parameters.AddWithValue("@parametroApellidoPaternoEmpleado", ApellidoPaternoEmpleado);
            comando.Parameters.AddWithValue("@parametroApellidoMaternoEmpleado", ApellidoMaternoEmpleado);
            comando.Parameters.AddWithValue("@parametroDireccionEmpleado", DireccionEmpleado);
            comando.Parameters.AddWithValue("@parametroSueldoEmpleado", SueldoEmpleado);
            comando.Parameters.AddWithValue("@parametroGeneroEmpleado", GeneroEmpleado);
            comando.Parameters.AddWithValue("@parametroTurnoEmpleado", TurnoEmpleado);
            if (string.IsNullOrEmpty(TelefonoEmpleado))
            {
                comando.Parameters.AddWithValue("@parametroTelefonoEmpleado", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parametroTelefonoEmpleado", TelefonoEmpleado);
            }

            if (string.IsNullOrEmpty(CelularEmpleado))
            {
                comando.Parameters.AddWithValue("@parametroCelularEmpleado", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parametroCelularEmpleado", CelularEmpleado);
            }

            if (string.IsNullOrEmpty(CorreoElectronicoEmpleado))
            {
                comando.Parameters.AddWithValue("@parametroCorreoElectronicoEmpleado", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parametroCorreoElectronicoEmpleado", CorreoElectronicoEmpleado);
            }

            conexion.Open();
            comando.ExecuteReader();
            conexion.Close();
        }
    }
}
