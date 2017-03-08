using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_1
{
    class clsHabitacion
    {

        //CREACIÓN DE CAMPOS:
        private Int32 _idHabitacion;
        private clsTipoHabitacion _tipoHabitacion;
        private Int32 _idTipoHabitacion;
        private string _Habitacion_Tipo;

       
        private string _numeroHabitacion;
        private decimal _precioHabitacion;
        private byte _pisoHabitacion;
        private string _estadoHabitacion;

        //CREACIÓN DEL CONTRUCTOR:
        public clsHabitacion(clsTipoHabitacion parametroTipoHabitacion,
                                 string parametroNumeroHabitacion,
                                 decimal parametroPrecioHabitacion,
                                 byte parametroPisoHabitacion,
                                 string parametroEstadoHabitacion)
        {
            TipoHabitacion = parametroTipoHabitacion;
            NumeroHabitacion = parametroNumeroHabitacion;
            PrecioHabitacion = parametroPrecioHabitacion;
            PisoHabitacion = parametroPisoHabitacion;
            EstadoHabitacion = parametroEstadoHabitacion;
        }

        public clsHabitacion(   Int32 parametroIdHabitacion, 
                                Int32 parametroTipoHabitacion,
                                 string parametroNumeroHabitacion,
                                 decimal parametroPrecioHabitacion,
                                 byte parametroPisoHabitacion,
                                 string parametroEstadoHabitacion)
        {
            IdHabitacion = parametroIdHabitacion;
            IdTipoHabitacion = parametroTipoHabitacion;
            NumeroHabitacion = parametroNumeroHabitacion;
            PrecioHabitacion = parametroPrecioHabitacion;
            PisoHabitacion = parametroPisoHabitacion;
            EstadoHabitacion = parametroEstadoHabitacion;
        }

        public clsHabitacion(   Int32 parametroIdHabitacion,
                                Int32 parametroTipoHabitacion,
                                 string parametroNumeroHabitacion,
                                 decimal parametroPrecioHabitacion,
                                 byte parametroPisoHabitacion,
                                 string parametroEstadoHabitacion,
                                string parametroNombreTipoHabitacion)
        {
            IdHabitacion = parametroIdHabitacion;
            IdTipoHabitacion = parametroTipoHabitacion;
            NumeroHabitacion = parametroNumeroHabitacion;
            PrecioHabitacion = parametroPrecioHabitacion;
            PisoHabitacion = parametroPisoHabitacion;
            EstadoHabitacion = parametroEstadoHabitacion;
            Habitacion_Tipo = parametroNombreTipoHabitacion;

        }


        public string Habitacion_Tipo
        {
            get { return _Habitacion_Tipo; }
            set { _Habitacion_Tipo = value; }
        }
        //CREACION DE PROPIEDADES:
        public Int32 IdHabitacion
        {
            get { return _idHabitacion; }
            set { _idHabitacion = value; }
        }
        public clsTipoHabitacion TipoHabitacion
        {
            get { return _tipoHabitacion; }
            set { _tipoHabitacion = value; }
        }
        public string NumeroHabitacion
        {
            get { return _numeroHabitacion; }
            set { _numeroHabitacion = value; }
        }
        public decimal PrecioHabitacion
        {
            get { return _precioHabitacion; }
            set { _precioHabitacion = value; }
        }
        public byte PisoHabitacion
        {
            get { return _pisoHabitacion; }
            set { _pisoHabitacion = value; }
        }
        public string EstadoHabitacion
        {
            get { return _estadoHabitacion; }
            set { _estadoHabitacion = value; }
        }

        public int IdTipoHabitacion
        {
            get
            {
                return _idTipoHabitacion;
            }

            set
            {
                _idTipoHabitacion = value;
            }
        }

        //CREACIÓN DEL MÉTODO:
        public void Insertar_Habitacion()
        {
            SqlConnection conexion;
            conexion = new SqlConnection("SERVER=.;DATABASE=Proyecto_Hotel;USER=sa;PWD=continental");
            SqlCommand comando;

            comando = new SqlCommand("usp_Habitacion_Insertar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametroidTipoH", TipoHabitacion.NombreTipo);
            comando.Parameters.AddWithValue("@parametroNumeroHabitacion", NumeroHabitacion);
            comando.Parameters.AddWithValue("@@parametroPrecioHabitacion,", PrecioHabitacion);
            comando.Parameters.AddWithValue("@parametroPisoHabitacion", PisoHabitacion);
            comando.Parameters.AddWithValue("@parametroEstadoHabitacion", EstadoHabitacion);

            conexion.Open();
            comando.ExecuteReader();
            conexion.Close();
        }

        public void Actualizar(clsHabitacion NuevosDatos)
        {
            SqlConnection conexion;
            conexion = new
            SqlConnection("SERVER=WD25-2;DATABASE=DemoLista;USER=sa;PWD=continental");

            SqlCommand comando;
            comando = new SqlCommand("usp_Habitacion_Actualizar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametroEstadoHabitacion", NumeroHabitacion);
            comando.Parameters.AddWithValue("@parNUEVO_Nombres", NuevosDatos.PrecioHabitacion);
            comando.Parameters.AddWithValue("@parNUEVO_Apellidos", PisoHabitacion);
            comando.Parameters.AddWithValue("@parNUEVO_Sexo", NuevosDatos.EstadoHabitacion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static clsHabitacion Buscar_PorEstadoHabitacion(string parEstado)
        {
            clsHabitacion Resultado = null;
            SqlConnection cn;
            cn = new SqlConnection(mdlVarirablesAplicacion.Cadena);
            SqlCommand cmd = new SqlCommand("usp_Habitacion_Buscar_PorEstado", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parEstado", parEstado);
            SqlDataReader contenedor;
            cn.Open();
            contenedor = cmd.ExecuteReader();
            while (contenedor.Read() == true)
            {
                Resultado = new clsHabitacion(Convert.ToInt32(contenedor["idHabitacion"]),
                                              Convert.ToInt32(contenedor["idTipoHabitacion"]),
                                              contenedor["numeroHabitacion"].ToString(),
                                              Convert.ToDecimal(contenedor["precioHabitacion"]),
                                              Convert.ToByte(contenedor["pisoHabitacion"]),
                                              contenedor["estadoHabitacion"].ToString(),
                                              contenedor["nombretipo"].ToString()
                                            );

            }
            cn.Close();
            return Resultado;
        }


    }
}
