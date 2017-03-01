using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_1
{
    class clsAlquiler
    {
        //CREACIÓN DE CAMPOS:
        private Int32 _idAlquiler;
        private clsHuesped _HuespedA;
        private clsHabitacion _HabitacionA;
        private clsEmpleado _EmpleadoA;
        private DateTime _fechaEntrada;
        private DateTime _horaEntrada;
        private DateTime _fechaSalida;
        private DateTime _horaSalida;
        private decimal _subtotal;
        private decimal _igv;
        private decimal _total;
        
        //CREACIÓN DEL CONSTRUCTOR:


        //CREACIÓN DE PROPIEDADES:
        public Int32 IdAlquiler
        {
            get { return _idAlquiler; }
            set { _idAlquiler = value; }
        }
        internal clsHuesped clsHuesped
        {
            get { return _HuespedA; }
            set { _HuespedA = value; }
        }
        internal clsHabitacion clsHabitacion
        {
            get { return _HabitacionA; }
            set { _HabitacionA = value; }
        }
        internal clsEmpleado EmpleadoA
        {
            get { return _EmpleadoA;}
            set { _EmpleadoA = value; }
        }
        public DateTime FechaEntrada
        {
            get { return _fechaEntrada; }
            set { _fechaEntrada = value; }
        }
        public DateTime HoraEntrada
        {
            get { return _horaEntrada; }
            set { _horaEntrada = value; }
        }
        public DateTime FechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }
        public DateTime HoraSalida
        {
            get { return _horaSalida; }
            set { _horaSalida = value; }
        }
        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        public decimal Igv
        {
            get { return _igv; }
            set { _igv = value; }
        }
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
