﻿String x = Console.ReadLine(); 
String y = Console.ReadLine();
String z = Console.ReadLine();

if ((x == "vertebrado") && (y == "ave")  && (z == "carnivoro"))
{
  Console.WriteLine("aguia\n");
}

if ((x == "vertebrado") && (y == "ave")  && (z == "onivoro"))
{
  Console.WriteLine("pomba\n");
}

if ((x == "vertebrado") && (y == "mamifero")  && (z == "onivoro"))
{
  Console.WriteLine("homem\n");
}

if ((x == "vertebrado") && (y == "mamifero")  && (z == "herbivoro"))
{
  Console.WriteLine("vaca\n");
}

if ((x == "invertebrado") && (y == "inseto")  && (z == "hematofago"))
{
  Console.WriteLine("pulga\n");
}

if ((x ==  "invertebrado") && (y == "inseto")  && (z == "herbivoro"))
{
  Console.WriteLine("lagarta\n");
}

if ((x  == "invertebrado") && (y == "anelideo") && (z == "hematofago"))
{
  Console.WriteLine("sanguessuga\n");
}

if ((x  == "invertebrado") && (y == "anelideo") && (z == "onivoro"))
{
  Console.WriteLine("minhoca\n");
}