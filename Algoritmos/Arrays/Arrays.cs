namespace AlogritmoCSharp.Algoritmos.Arrays;

public class Arrays
{
    public int[] ArrayPublica { get; set; }
    public Arrays(int[] array)
    {
        ArrayPublica = array;
    }
    public void MosrarTodosElementos()
    {
        // foreach (var item in ArrayPublica)
        // {
        //     Console.WriteLine(item);
        // }

        Array.ForEach(ArrayPublica, item => Console.WriteLine(item));
    }

    public void CopiaArray(int[] arrayDestino)
    {
        // vai copiar todos os elementos do array publico para o array destino
        Array.Copy(ArrayPublica, arrayDestino, ArrayPublica.Length);
    }

    public void AumentarOTamanhoDoArray(int novoTamanho)
    {
        var arrayAntigo = ArrayPublica;
        Array.Resize(ref arrayAntigo, novoTamanho);
        ArrayPublica = arrayAntigo;
    }

    public int RetornarTamanhoDoArray()
    {
        return ArrayPublica.Length;
    }

    public void OrdenarArray()
    {
        Array.Sort(ArrayPublica);
    }

    public void InverterArray()
    {
        Array.Reverse(ArrayPublica);
    }
}