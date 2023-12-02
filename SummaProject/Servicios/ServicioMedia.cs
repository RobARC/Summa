public class ServicioMedia: IServiciosMedia
{
    private readonly IAgente agente;

    public ServicioMedia(IAgente _agente)
    {
        this.agente = _agente;
    }

    public double CalcularMedia(List<double> numeros)
    {
         return agente.GetMedia(numeros);
    }

   
}

