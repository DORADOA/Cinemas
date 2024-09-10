namespace Cinemas
{
    public class Entrada
    {
        public Cine cine {  get; private set; }
        public Pelicula pelicula { get; set; }
        public double Precio {  get; private set; }
        public DateTime Fecha { get; private set; }

     public Entrada (Cine cine, Pelicula pelicula, double precio, DateTime fecha)
        {      
            this.cine = cine;
            this.pelicula = pelicula;
            Precio = precio;
            Fecha = fecha;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"\n Cine: {cine.Nombre} \n pelicula : {pelicula} \n el valor es de : $ {Precio} \n {Fecha} \n asientos : {TipoAsiento.SuperSeat}");
        }
    }
}
