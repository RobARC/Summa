public class AgenteA : IAgente
{
    public double GetMedia(List<double> numeros)
    {
        return numeros.Average();
    }

    public string  GetStaircase(int n)
    {
        // Implementación para dibujar la escalera alineada a la derecha
        if (n == 0) throw new ArgumentException("El valor no puede ser cero");
        
        string staircase = "";
        for (int i = 1; i <= n; i++)
        {
            staircase += new String(' ', n - i) + new String('#', i) + "\n";
        }
        return staircase;
    }
}