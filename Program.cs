namespace S5;

public class Program
{
  static void Main(string[] args)
  {
    Empregado empregado = new Empregado(1, "Empregado");
    SalarioEmpregado salarioEmpregado = new SalarioEmpregado(2, "Salário Empregado", 2, 1000.00);
    Secretaria secretaria = new Secretaria(3, "Secretária", 3, 1000.00, 3);
    FuncionarioHorista funcionarioHorista = new FuncionarioHorista(4, "Funcionário Horista", "12345", 500.00);


    System.Console.WriteLine($"Id do empregado: {empregado.Id} \nNome do empregado: {empregado.Nome}\n-----------------");

    System.Console.WriteLine($"Código do funcionário: {salarioEmpregado.CodigoFuncionario}\nId do empregado: {salarioEmpregado.Id}\nNome do funcionário: {salarioEmpregado.Nome}\nValor do salário: {salarioEmpregado.ValorSalario}\n-----------------");

    System.Console.WriteLine($"Código do funcionário: {secretaria.CodigoFuncionario}\nId do empregado: {secretaria.Id}\nNome do funcionário: {secretaria.Nome}\nQuantidade de anos na empresa: {secretaria.QtdAnosEmpresa}\nValor do salário: {secretaria.ValorSalario}\n-----------------");

    System.Console.WriteLine($"CNPJ do funcionário: {funcionarioHorista.CNPJ}\nId do funcionário: {funcionarioHorista.Id}\nNome do funcionário: {funcionarioHorista.Nome}\nTaxa do funcionário: {funcionarioHorista.Taxa}");

  }
}