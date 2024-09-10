namespace Cinemas;

    public class Pelicula
    {
        private string Nombre {  get; set; }
        private string Genero { get; set; }
        private int DuracionMin { get; set; }
        private Formato formato { get; set; }

        public Pelicula(string nombre, string genero, int duracionmin, Formato formato)
        {
            Nombre = nombre;
            Genero = genero;
            DuracionMin = duracionmin;
            this.formato = formato;
           
        }
        public override string ToString()
        {
            return $"{Nombre} \n Genero:{Genero} \n Duracion: {DuracionMin} min \n {Formato._2D_Subtitulada}";
        }
    }
 
