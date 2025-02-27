﻿using static System.Console;

//LerCsv();

CriarCsv();

WriteLine("\n\nPressione [Enter] para terminar.");
ReadLine();

static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saída");
    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1970, month: 2 , day: 14)
        },
        new Pessoa()
        {
            Nome = "Pedro Paiva",
            Email = "pp@gmail.com",
            Telefone = 456789,
            Nascimento = new DateOnly(year: 2002, month: 4, day: 20)
        },
        new Pessoa()
        {
            Nome = "Maria Antonia",
            Email = "ma@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year:1982, month:04, day: 12)
        },
        new Pessoa()
        {
            Nome = "Carla Moraes",
            Email = "cms@gmail.com",
            Telefone = 9987411,
            Nascimento = new DateOnly(year: 2000, month: 07, day: 20)
        }
    };

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "Usuarios.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,eamil,telefone,nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}



static void LerCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

    if(File.Exists(path))
    {
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');
        //? é usada para indicar que, se sr.ReadLine() for nulo, o comando Split deve ser ignorado, assim não dará erro.
        //Split vai transformar cada item separado por vírgula da primeira linha (cabeçalho) numa string separada num array.
        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            if (cabecalho.Length != registro.Length)
            {
                WriteLine("Arquivo fora do padrão.");
                break;
            }
            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}:{registro[i]}");
            }
            WriteLine("-----------------------------------");
        }
    }
    else
    {
        WriteLine($"\nO arquivo {path} não existe.");
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}