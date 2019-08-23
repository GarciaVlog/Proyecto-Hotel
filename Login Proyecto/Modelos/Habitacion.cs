using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.Modelos
{
    public class Habitacion
    {
        public string TipodeHabitacion { get; set; }

        public Habitacion()
        {
            
        }

        public Habitacion(string tipohabitacion)
        {
            TipodeHabitacion = tipohabitacion;      
        }
    }
}
