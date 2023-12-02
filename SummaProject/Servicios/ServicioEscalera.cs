public class ServicioEscalera
{
    private readonly IAgente agente;

    public ServicioEscalera(IAgente _agente)
    {
        this.agente = _agente;
    }

     public string DibujarEscalera(int n)
    {
         return agente.GetStaircase(n);
    }

}
