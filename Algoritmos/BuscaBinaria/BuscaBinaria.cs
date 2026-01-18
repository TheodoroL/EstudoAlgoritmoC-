namespace AlogritmoCSharp.Algoritmos.BuscaBinaria;

public static class BuscaBinaria
{
    public static int Buscar(List<int> lista, int valor)
    {
        int inicio = 0;
        int fim = lista.Count - 1;

        while (inicio <= fim)
        {
            var meio = (inicio + fim) / 2;

            if (lista[meio] == valor) return meio;

            if (lista[meio] < valor) inicio = meio + 1;

            else fim = meio - 1;
        }

        return -1;
    }
}