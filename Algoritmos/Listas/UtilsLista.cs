namespace AlogritmoCSharp.Algoritmos.Lista;

public static class UtilListas
{
    public static void MostrarLista<T>(this List<T> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}