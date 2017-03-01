using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_1
{
    class clsTipoHabitacion
    {
        //CREACIÓN DE CAMPOS:
        private Int32 _idTipo;
        private string _nombreTipo;
        private string _descripcion;

        //CREACION DEL CONSTRUCTOR:
        public clsTipoHabitacion(Int32 parametroIdTipo,
                                 string parametroNombreTipo,
                                 string parametroDescripcion)
        {
            IdTipo = parametroIdTipo;
            NombreTipo = parametroNombreTipo;
            Descripcion = parametroDescripcion;
        }

        //CREACIÓN DE PROPIEDADES:
        public Int32 IdTipo
        {
            get { return _idTipo; }
            set { _idTipo = value; }
        }
        public string NombreTipo
        {
            get { return _nombreTipo; }
            set { _nombreTipo = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //CREACION DEL MÉTODO:
        public static List<clsTipoHabitacion> Listar_TipoHabitacion()
        {
            List<clsTipoHabitacion> x = new List<clsTipoHabitacion>();

            SqlConnection conexion;
            conexion = new SqlConnection("SERVER=.;DATABASE=Proyecto_Hotel;USER=sa;PWD=continental");
            SqlCommand comando;

            comando = new SqlCommand("usp_Listar_TipoHabitacion", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader contenedor;
            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {
                clsTipoHabitacion MiObjeto;
                MiObjeto = new clsTipoHabitacion(Convert.ToInt32(contenedor["idTipo"]),
                                                contenedor["nombreTipo"].ToString(),
                                                contenedor["descripcion"].ToString());
                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }
    }
}
