using Login_Proyecto.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.BL
{
    public class HabitacionBL
    {
        public BindingList<Habitacion> ListadeHabitacion { get; set; }

        public HabitacionBL()
        {
            ListadeHabitacion = new BindingList<Habitacion> ();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var habitacion1 = new Habitacion("Sencilla");
            var habitacion2 = new Habitacion("Doble");
            var habitacion3 = new Habitacion("Triple");
            var habitacion4 = new Habitacion("Precidencial");

            ListadeHabitacion.Add(habitacion1);
            ListadeHabitacion.Add(habitacion2);
            ListadeHabitacion.Add(habitacion3);
            ListadeHabitacion.Add(habitacion4);
        }
    }
}
