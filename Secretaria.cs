namespace S5;

public class Secretaria : SalarioEmpregado
{
  public int QtdAnosEmpresa { get; set; }
  public Secretaria() { }

  public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa) : base(id, nome, codigoFuncionario, valorSalario)
  {
    QtdAnosEmpresa = qtdAnosEmpresa;
  }

  public static void AtenderCliente()
  {
    System.Console.WriteLine("Atendendo cliente.");
  }

  public static void RealizarLigacoes()
  {
    System.Console.WriteLine("Realizando ligações.");
  }


}