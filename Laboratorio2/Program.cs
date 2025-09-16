using Laboratorio2;

internal class Program
{
    private static void Main(string[] args)
    {
       Cliente cliente = new Cliente();
        cliente.FirstName = "su nombre";
        cliente.LastName = "Su_Apellido";
        cliente.Age = 15;
        cliente.Id = 1;

        Console.WriteLine(cliente.GetFullName());
    }
}