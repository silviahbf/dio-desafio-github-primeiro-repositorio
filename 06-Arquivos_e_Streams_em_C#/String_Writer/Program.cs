﻿string textReaderText = "TextReader é a classe base abstrata " +
                "de StreamReader e StringReader, que lê caracteres " +
                "de streams e strings, respectivamente.\n\n" +

                "Crie uma instância de TextReader para abrir um arquivo de texto " +
                "para ler um intervalo especificado de caracteres " +
                "ou para criar um leitor baseado em fluxo existente.\n\n" +

                "Você também pode usar uma instância de TextReader para ler " +
                "texto de um armazenamento de suporte personalizado usando as mesmas " +
                "APIs que você usaria para uma string ou fluxo.\n\n";

Console.WriteLine($"Texto original: {textReaderText}");

string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while(true) //loop infinito, precisa de mecanismo para sair do loop
{
    linha = sr.ReadLine();
    if(linha != null)
    {
        paragrafo += linha + " "; //mesmo que paragrafo = paragrafo + linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");
int caractereLido;
char caractereConvertido;


var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.Read();
    if(caractereLido == -1) break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if(caractereConvertido == '.')
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }
}
Console.WriteLine($"Texto armazendo no StringWriter: {sw.ToString()}");
Console.WriteLine("\n\nDigite [Enter] para finalizar.");
Console.ReadLine();
