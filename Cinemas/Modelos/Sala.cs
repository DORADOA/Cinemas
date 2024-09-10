using System;
namespace Cinemas
{
    public class Sala
    {
        private int Numero { get; set; }
        private List<Asiento> asientos { get; set; }
        private Pelicula pelicula { get; set; }
        private DateTime Horario { get; set; }
    
        public Sala(int numero, Pelicula _pelicula, DateTime horario)
        {
            Numero = numero;
            pelicula = _pelicula;
            Horario = horario;
            asientos = new List<Asiento>();
        }

        public void AgregarAsiento(Asiento asiento)
        {
            asientos.Add(asiento);
        }
       
    }
}
