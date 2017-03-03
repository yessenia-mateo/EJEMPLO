using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_1
{
    class clsRuc
    {
        //CREACIÓN DE CAMPOS:
        private Int32 _idRuc;
        private string _numeroRuc;
        private string _razonSocial;
        private string _direccionRuc;

        //CREACIÓN DE CONSTRUCTOR:
        public clsRuc(string parametroNumeroRuc,
                      string parametroRazonSocial,
                      string parametroDireccionRuc)
        {
            NumeroRuc = parametroNumeroRuc;
            RazonSocial = parametroRazonSocial;
            DireccionRuc = parametroDireccionRuc;
        }
        public clsRuc(Int32 parametroIdRUC,
                      string parametroNumeroRuc,
                      string parametroRazonSocial,
                      string parametroDireccionRuc)
        {
            IdRuc = parametroIdRUC;
            NumeroRuc = parametroNumeroRuc;
            RazonSocial = parametroRazonSocial;
            DireccionRuc = parametroDireccionRuc;
        }

        //CREACIÓN DE PROPIEDADES:
        public Int32 IdRuc
        {
            get { return _idRuc; }
            set { _idRuc = value; }
        }
        public string NumeroRuc
        {
            get { return _numeroRuc; }
            set { _numeroRuc = value; }
        }
        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }
        public string DireccionRuc
        {
            get { return _direccionRuc; }
            set { _direccionRuc = value; }
        }

        //CREACIÓN DE MÉTODO 1:
        public void Insertar_Ruc()
        {
            SqlConnection conexion;
            conexion = new SqlConnection("SERVER=.;DATABASE=Proyecto_Hotel;USER=sa;PWD=continental");
            SqlCommand comando;

            comando = new SqlCommand("usp_Ruc_Insertar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametroNumeroRuc", NumeroRuc);
            comando.Parameters.AddWithValue("@parametroRazonSocial", RazonSocial);
            comando.Parameters.AddWithValue("@parametroDireccion", DireccionRuc);

            conexion.Open();
            comando.ExecuteReader();
            conexion.Close();
        }


        public static clsRuc Buscar_PorNumeroRUC(string parNroRUC)
        {
            clsRuc Resultado = null;
            SqlConnection cn;
            cn = new SqlConnection(mdlVarirablesAplicacion.Cadena);
            SqlCommand cmd = new SqlCommand("usp_RUC_Buscar_PorNroRUC", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parRUC", parNroRUC);
            SqlDataReader contenedor;
            cn.Open();
            contenedor = cmd.ExecuteReader();
            while (contenedor.Read() == true)
            {
                Resultado = new clsRuc      (Convert.ToInt32(contenedor["idRuc"]),
                                             contenedor["numeroRuc"].ToString(),
                                             contenedor["razonSocial"].ToString(),
                                             contenedor["direccion"].ToString()
                                            );

            }
            cn.Close();
            return Resultado;
        }
    }
}
