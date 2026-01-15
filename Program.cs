namespace AlogritmoCSharp;

using Algoritmos.Arrays;
using Algoritmos.Lista;

class Program
{
    static void Main()
    {
        Console.Clear();
        // EstudoArrays();
        EstudoListas();

    }

    static void EstudoArrays()
    {
        int[] ArraysInteiros = { 1, 2, 3, 4 };

        var arrays = new Arrays(ArraysInteiros);

        arrays.ArrayPublica[0] = 10;

        arrays.MosrarTodosElementos();

        Console.WriteLine("-----");

        int[] arrayDestino = new int[10];

        arrays.CopiaArray(arrayDestino);

        Console.WriteLine(arrays.RetornarTamanhoDoArray());

        arrays.AumentarOTamanhoDoArray(10);


        arrays.MosrarTodosElementos();

        Console.WriteLine(arrays.RetornarTamanhoDoArray());

        arrays.OrdenarArray();
        Console.WriteLine("Array Ordenado:");
        arrays.MosrarTodosElementos();

        Console.WriteLine("Array Invertido:");
        arrays.InverterArray();
        arrays.MosrarTodosElementos();

    }
    static void EstudoListas()
    {
        var lista = new Lista<int>();
        lista.Adicionar(10);
        lista.Adicionar(20);

        List<int> listaNova = new() { 1, 2, 3, 4, 5 };
        lista.AdicionarVarios(listaNova);

        lista.AdicionarPorIndex(0, 5);
        lista.MostrarTodosElementos();
        Console.WriteLine("-----");
        lista.Remover(3);
        lista.MostrarTodosElementos();
        Console.WriteLine("-----");
        lista.RemoverPorIndex(0);
        lista.MostrarTodosElementos();
    }

}