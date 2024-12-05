using System;

namespace DSW_I_CL1.Models
{
    public class Calcular
    {
        public int Disco { get; set; } // Capacidad GB
        public int Cds { get; set; }   // Cantidad de CDs 
        public int Total { get; set; } // Resultado 

        public void CalcularCds()
        {
            const int cdCapacityMb = 700; 
            int discoMb = Disco * 1024; 
            Cds = (int)Math.Ceiling((double)discoMb / cdCapacityMb); 
        }
    }
}
