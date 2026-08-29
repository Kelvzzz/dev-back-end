using AtividadeZAbstracao.Entidades;



namespace AtividadeZAbstracao.Classes.Servicos
{
    public class CalculadoraImposto
    {
       public static double Calcular(Contribuinte contribuinte)
        {
            return contribuinte.CalcularImposto();
        }

      
    }
}

