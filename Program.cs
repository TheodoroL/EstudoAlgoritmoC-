namespace AlogritmoCSharp;

using System.Text;
using Algoritmos.Arrays;
using Algoritmos.Lista;

class Program
{
    static void Main()
    {
        Console.Clear();
        // EstudoArrays();
        // EstudoListas();
        EstudoString();
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

    static void EstudoString()
    {
        string nome = "Lucas";
        string sobrenome = "Theodoro";
        var nomeCompleto = $"{nome} {sobrenome}";

        string nome2 = "Lucas";

        bool igual = nome == nome2;
        bool iguaisRef = ReferenceEquals(nome, nome2);

        Console.WriteLine(igual);
        Console.WriteLine(iguaisRef);

        bool iguais = false;
        string nomeCompleto2 = "Lucas Theodoro";
        iguais = nomeCompleto == nomeCompleto2;
        Console.WriteLine(iguais);
        Console.WriteLine(ReferenceEquals(nomeCompleto, nomeCompleto2));//false

        nomeCompleto = "";// outro espaço na memória
        nomeCompleto = string.Concat(nome, " ", sobrenome);// novo espaço na memória
        Console.WriteLine(nomeCompleto);

        string frase = "O rato roeu a roupa do rei de Roma";
        int posicao = frase.IndexOf("roupa");// primeira ocorrência da palavra roupa
        int posicaoUltima = frase.LastIndexOf("r");// última ocorrência da letra r
        Console.WriteLine(posicao);
        Console.WriteLine(posicaoUltima);

        string novaString = frase.Replace("rato", "gato"); // substitui rato por gato
        string outraFrase = frase.Replace("r", "g"); // substitui todas as letras r por g
        Console.WriteLine(novaString);
        Console.WriteLine(outraFrase);

        string palavra = frase.Substring(2, 4); // começa na posição 2 e pega 4 caracteres
        string restoDaFrase = frase.Substring(11); // começa na posição 10 e pega até o final
        Console.WriteLine(palavra);
        Console.WriteLine(restoDaFrase);

        string texto = "eXeMpLo De TeXtO CoMiNhaS MiXTaS";
        string textoMinusculo = texto.ToLower(); // converte para minúsculo
        string textoMaiusculo = texto.ToUpper(); // converte para maiúsculo
        Console.WriteLine(textoMinusculo);
        Console.WriteLine(textoMaiusculo);

        string fraseComEspacos = "   Olá, Mundo!   ";
        string fraseTrim = fraseComEspacos.Trim(); // remove espaços no início e no fim
        string fraseTrimStart = fraseComEspacos.TrimStart(); // remove espaços no início
        string fraseTrimEnd = fraseComEspacos.TrimEnd(); // remove espaços no fim
        Console.WriteLine($"'{fraseTrim}'");
        Console.WriteLine($"'{fraseTrimStart}'");
        Console.WriteLine($"'{fraseTrimEnd}'");

        string teste = "Texto Teste";
        string resultado = teste.Replace(" ", new string(' ', 5));
        Console.WriteLine(resultado);

        string[] listaPalavra = { "Olá", "Mundo", "!" };
        string fraseJunta = string.Join(" ", listaPalavra);
        Console.WriteLine(fraseJunta);

        StringBuilder sb = new StringBuilder("Olá mundo no StringBuilder"); // capacidade inicial de 16 caracteres

        sb.Append(" Teste sla");
        sb.AppendLine("Linha nova");
        sb.Replace("mundo", "universo");

        string sbTexto = sb.ToString();

        Console.WriteLine(sbTexto);
    }


}