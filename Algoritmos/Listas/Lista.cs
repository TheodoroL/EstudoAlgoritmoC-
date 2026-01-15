namespace AlogritmoCSharp.Algoritmos.Lista;

public class Lista<T>
{
    public List<T> ListaInterna { get; set; } = new();

    public void Adicionar(T item)
    {
        ListaInterna.Add(item);

    }
    public void AdicionarVarios(List<T> itens)
    {
        ListaInterna.AddRange(itens);
    }

    public void AdicionarPorIndex(int index, T item)
    {
        ListaInterna.Insert(index, item);
    }

    public void Remover(T item)
    {
        ListaInterna.Remove(item);
    }

    public void RemoverPorIndex(int index)
    {
        ListaInterna.RemoveAt(index);
    }

    public void MostrarTodosElementos()
    {
        ListaInterna.MostrarLista();
    }
}