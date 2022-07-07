namespace S5;

public class SalarioEmpregado : Empregado
{
  public int CodigoFuncionario { get; set; }
  public double ValorSalario { get; set; }

  public SalarioEmpregado() { }

  public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario) : base(id, nome)
  {
    this.CodigoFuncionario = codigoFuncionario;
    this.ValorSalario = valorSalario;
  }

  public static void CalcularFolhaPagamento()
  {
    System.Console.WriteLine("Calculando folha pagamento.");
  }
}