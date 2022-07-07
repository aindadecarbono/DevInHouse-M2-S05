namespace S5;

public class FuncionarioHorista : Empregado
{
  public string CNPJ { get; set; }
  public double Taxa { get; set; }

  public FuncionarioHorista() { }

  public FuncionarioHorista(int id, string nome, string cnpj, double taxa) : base(id, nome)
  {
    CNPJ = cnpj;
    Taxa = taxa;
  }

  public static void CalcularTaxas()
  {
    System.Console.WriteLine("Calculando taxas.");
  }

  public static void EmitirNota()
  {
    System.Console.WriteLine("Emitindo nota.");
  }
}