using Cinemas;
namespace Cinemas
{
    public class Cine
    {
        public string Nombre { get; private set; }
        public List<Sala> Salas { get; private set; }

        public Cine(string nombre)
        {
            Nombre = nombre;
            Salas = new List<Sala>();
        }

        public void AgregarSala(Sala sala)
        {
            Salas.Add(sala);
        }
    }
}
