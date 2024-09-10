using Cinemas;
class Program
{
    static void Main()
    {
        Cine cine = new Cine("Showcase");
        Pelicula pelicula = new Pelicula("El Padrino", "Drama", 180, Formato._2D_Subtitulada);
        Sala sala = new Sala(1, pelicula, DateTime.Now);
        Asiento asiento1 = new Asiento('a', 12, TipoAsiento.SuperSeat);
        Asiento asiento2 = new Asiento('a', 13, TipoAsiento.SuperSeat);
        Entrada entrada = new Entrada(cine, pelicula, 200, DateTime.Now);
        sala.AgregarAsiento(asiento1);
        sala.AgregarAsiento(asiento2);
        cine.AgregarSala(sala); 
        entrada.MostrarDetalles();
     
    }
    
}