namespace S5;

public class Empregado
{
  public int Id { get; set; }
  public string Nome { get; set; }

  public Empregado() { }

  public Empregado(int id, string nome)
  {
    Id = id;
    Nome = nome;
  }

  public static void Trabalhar()
  {
    System.Console.WriteLine("Trabalhando.");
  }

  public static void IrEmbora()
  {
    System.Console.WriteLine("Indo embora.");
  }

  public static void TirarFolga()
  {
    System.Console.WriteLine("Tirando folga.");
  }

}