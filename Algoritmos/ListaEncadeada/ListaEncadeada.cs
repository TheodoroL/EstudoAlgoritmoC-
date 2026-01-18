using System.Collections;

namespace AlogritmoCSharp.Algoritmos.ListaEncadeada;

class No<T>
{
    public T Valor { get; private set; }
    public No<T>? ProximoNo { get; set; }

    public No(T valor)
    {
        this.Valor = valor;
        this.ProximoNo = null;
    }
}

public class ListaEncadeada<T> : IEnumerable<T>
{
    private No<T>? _lista;
    private int _tamanho;

    public int Tamanho
    {
        get => _tamanho;
        private set => _tamanho = value;
    }

    public ListaEncadeada()
    {
        _lista = null;
    }

    public void Adicionar(T valor)
    {
        if (_lista == null)
        {
            _lista = new No<T>(valor);
        }
        else
        {
            var noAtual = _lista;
            while (noAtual.ProximoNo != null)
            {
                noAtual = noAtual.ProximoNo;
            }
            noAtual.ProximoNo = new No<T>(valor);
        }
        Tamanho++;
    }

    public bool Buscar(T valor)
    {
        var noAtual = _lista;

        while (noAtual != null)
        {
            if (noAtual.Valor!.Equals(valor))
            {
                return true;
            }
            noAtual = noAtual.ProximoNo;
        }

        return false;
    }
    public void Remover(T valor)
    {
        if (_lista == null) return;

        if (_lista.Valor!.Equals(valor))
        {
            _lista = _lista.ProximoNo;
            Tamanho--;
            return;
        }

        var noAtual = _lista;
        while (noAtual.ProximoNo != null && !noAtual.ProximoNo.Valor!.Equals(valor))
        {
            noAtual = noAtual.ProximoNo;
        }

        if (noAtual.ProximoNo != null)
        {
            noAtual.ProximoNo = noAtual.ProximoNo.ProximoNo;
            Tamanho--;
        }
    }



    public IEnumerator<T> GetEnumerator()
    {
        var noAtual = _lista;
        while (noAtual != null)
        {
            yield return noAtual.Valor;
            noAtual = noAtual.ProximoNo;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}