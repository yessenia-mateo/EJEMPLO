using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_1
{
    class clsHuesped
    {
        //CREACIÓN DE CAMPOS:
        private Int32 _idHuesped;
        private clsRuc _rucH;
        private string _documentoIdentidadHuesped;
        private string _nombresHuesped;
        private string _apellidoPaternoHuesped;
        private string _apellidoMaternoHuesped;
        private DateTime _fechaNacimientoHuesped;
        private string _procedenciaHuesped;
        private Char _generoHuesped;

        //CREACIÓN DEL CONSTRUCTOR:
        public clsHuesped(string parametroDocumentoIdentidadHuesped,
                          string parametroNombresHuesped,
                          string parametroApellidoPaternoHuesped,
                          string parametroApellidoMaternoHuesped,
                          DateTime parametroFechaNacimientoHuesped,
                          string parametroProcedenciaHuesped,
                          Char parametroGeneroHuesped,
                           clsRuc parametroRUC )
        {
            DocumentoIdentidadHuesped = parametroDocumentoIdentidadHuesped;
            NombresHuesped = parametroNombresHuesped;
            ApellidoPaternoHuesped = parametroApellidoPaternoHuesped;
            ApellidoMaternoHuesped = parametroApellidoMaternoHuesped;
            FechaNacimientoHuesped = parametroFechaNacimientoHuesped;
            ProcedenciaHuesped = parametroProcedenciaHuesped;
            GeneroHuesped = parametroGeneroHuesped;
            RucH = parametroRUC;
        }

        public clsHuesped(string parametroDocumentoIdentidadHuesped,
                          string parametroNombresHuesped,
                          string parametroApellidoPaternoHuesped,
                          string parametroApellidoMaternoHuesped,
                          DateTime parametroFechaNacimientoHuesped,
                          string parametroProcedenciaHuesped,
                          Char parametroGeneroHuesped)
        {
            DocumentoIdentidadHuesped = parametroDocumentoIdentidadHuesped;
            NombresHuesped = parametroNombresHuesped;
            ApellidoPaternoHuesped = parametroApellidoPaternoHuesped;
            ApellidoMaternoHuesped = parametroApellidoMaternoHuesped;
            FechaNacimientoHuesped = parametroFechaNacimientoHuesped;
            ProcedenciaHuesped = parametroProcedenciaHuesped;
            GeneroHuesped = parametroGeneroHuesped;
            
        }

        //CREACIÓN DE PROPIEDADES:
        public Int32 IdHuesped
        {
            get { return _idHuesped; }
            set { _idHuesped = value; }
        }
        public clsRuc RucH
        {
            get { return _rucH; }
            set { _rucH = value; }
        }
        public string DocumentoIdentidadHuesped
        {
            get { return _documentoIdentidadHuesped; }
            set { _documentoIdentidadHuesped = value; }
        }
        public string NombresHuesped
        {
            get { return _nombresHuesped; }
            set { _nombresHuesped = value; }
        }
        public string ApellidoPaternoHuesped
        {
            get { return _apellidoPaternoHuesped; }
            set { _apellidoPaternoHuesped = value; }
        }
        public string ApellidoMaternoHuesped
        {
            get { return _apellidoMaternoHuesped; }
            set { _apellidoMaternoHuesped = value; }
        }
        public DateTime FechaNacimientoHuesped
        {
            get { return _fechaNacimientoHuesped; }
            set { _fechaNacimientoHuesped = value; }
        }
        public string ProcedenciaHuesped
        {
            get { return _procedenciaHuesped; }
            set { _procedenciaHuesped = value; }
        }
        public Char GeneroHuesped
        {
            get { return _generoHuesped; }
            set { _generoHuesped = value; }
        }
        //CREACIÓN DEL MÉTODO:
        public void Insertar_Huesped()
        {
            SqlConnection conexion;
            conexion = new SqlConnection(mdlVarirablesAplicacion.Cadena);
            SqlCommand comando;
            //No importa el orden
            comando = new SqlCommand("usp_Huesped_Insertar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametroDniEmpleado", DocumentoIdentidadHuesped);
            comando.Parameters.AddWithValue("@parametroNombresEmpleado", NombresHuesped);
            comando.Parameters.AddWithValue("@parametroApellidosEmpleado", ApellidoPaternoHuesped);
            comando.Parameters.AddWithValue("@parametroDireccionEmpleado", ApellidoMaternoHuesped);
            comando.Parameters.AddWithValue("@parametroSueldoEmpleado", FechaNacimientoHuesped);
            comando.Parameters.AddWithValue("@parametroSexoEmpleado", ProcedenciaHuesped);
            comando.Parameters.AddWithValue("@parametroSexoEmpleado", GeneroHuesped);

            if (RucH == null)
            {
                comando.Parameters.AddWithValue("@parametroIdRucH", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parametroIdRucH", RucH.IdRuc);
            }

            conexion.Open();
            comando.ExecuteReader();
            conexion.Close();
        }

        public static clsHuesped Buscar_PorNumeroDNI(string parDocumentoIdentidad)
        {
            clsHuesped Resultado = null;
            SqlConnection cn;
            cn= new SqlConnection(mdlVarirablesAplicacion.Cadena);
            SqlCommand cmd = new SqlCommand("usp_Cliente_Buscar_PorDNI", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parDNI", parDocumentoIdentidad);
            SqlDataReader contenedor;
            cn.Open();
            contenedor = cmd.ExecuteReader();
            while (contenedor.Read() == true)
            {
                Resultado = new clsHuesped(contenedor["docuementoIdentidadHuesped"].ToString(),
                                            contenedor["nombresHuesped"].ToString(),
                                            contenedor["apellidoPaterno"].ToString(),
                                            contenedor["apellidoMaterno"].ToString(),
                                            Convert.ToDateTime(contenedor["fechaNacimientoHuesped"]),
                                            contenedor["procedenciaHuesped"].ToString(),
                                            Convert.ToChar(contenedor["generoHuesped"])
                                            );
                                        
            }
            cn.Close();
            return Resultado;
        }
    }
}
