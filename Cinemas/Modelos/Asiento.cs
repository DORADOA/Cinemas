public enum TipoAsiento
{
    Estándar,
    SuperSeat
}

public class Asiento
{ 
    private char Letra { get; set; }
    private int Numero { get; set; }
    private TipoAsiento Tipo { get; set; }
    private bool Ocupado { get; set; }
    private List<Asiento> Asientos { get; set; } = new List<Asiento>();

    public Asiento(char letra, int numero, TipoAsiento tipo)
    {
        Letra = letra;
        Numero = numero;
        Tipo = tipo;
        Asientos = new List<Asiento>();
        Ocupado = false;
    }
    public void CambiarOcupado()
    {foreach (var asiento in Asientos)
        Ocupado = !Ocupado;
    }
    public override string ToString()
    {
        return $"{Ocupado}";
    }

}

