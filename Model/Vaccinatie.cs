using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccinatietool.Model
{
    public class Vaccinatie
    {
        public int VaccinatieID { get; set; }
        public DateTime Datum { get; set; }
        public Burger Burger { get; set; }
        public Vaccin Vaccin { get; set; }
        public Vaccinator Vaccinator  { get; set; }
    }
}
