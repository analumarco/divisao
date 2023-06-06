try
{
    Console.WriteLine("Informe o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor: ");
    int b = int.Parse(Console.ReadLine());
    int resultado = a / b;
    Console.WriteLine("Resultado: " + resultado);
} catch(DivideByZeroException ex)
{
    Console.WriteLine("Não é permitido dividir por zero. " + ex.Message);
} catch(InvalidCastException ex)
{
    Console.WriteLine("Letras não são permitidas. " + ex.Message);
} catch(Exception ex)
{
    Console.WriteLine("Algo deu errado! " + ex.Message);
}
finally
{
    Console.WriteLine("Aqui passa de qualquer forma! ");
}


Console.ReadKey();