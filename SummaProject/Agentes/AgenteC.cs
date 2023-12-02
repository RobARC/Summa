// Implementación del Agente C
public class AgenteC : IAgente
{
    public double GetMedia(List<double> numeros)
    {
        int n = numeros.Count;
        var sortedNumbers = numeros.OrderBy(num => num).ToList();
        if (n % 2 == 0)
            return (sortedNumbers[n / 2 - 1] + sortedNumbers[n / 2]) / 2;
        else
            return sortedNumbers[n / 2];
    }
   
       public string GetStaircase(int n)
    {
       string staircase = "";
       for (int i = 0; i < n; i++)
    {
        int spaces = Math.Max(0, n - i - 1);
        staircase += new String(' ', spaces) + new String('#', n + 2 * i) + "\n";
    }
    for (int i = n - 2; i >= 0; i--)
    {
        int spaces = Math.Max(0, n - i - 1);
        staircase += new String(' ', spaces) + new String('#', n + 2 * i) + "\n";
    }
        return staircase;
    }
    
}