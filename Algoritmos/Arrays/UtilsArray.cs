public static class UtilsArray
{
    // método de extensão para imprimir elementos de um array com uma mensagem personalizada
    public static void ImprimirElementos<T>(this T[] array, string mensagem)
    {
        Console.WriteLine(mensagem);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}