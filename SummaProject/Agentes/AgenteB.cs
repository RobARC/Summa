// Implementación del Agente B
public class AgenteB : IAgente
{
    public double GetMedia(List<double> numeros)
    {
        int n = numeros.Count;
        return n / numeros.Sum(x => 1 / x);
    }

    public string GetStaircase(int n)
    {
        // Implementación para dibujar la escalera alineada a la derecha inversa
        if (n == 0) throw new ArgumentException("El valor no puede ser cero");
        string staircase = "";
        for (int i = n; i >= 1; i--)
        {
            staircase += new String(' ', n - i) + new String('#', i) + "\n";
        }
        return staircase;
    }
}