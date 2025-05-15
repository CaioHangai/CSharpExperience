using System;

namespace desafioNomeDoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            String animal1; //declare as suas variaveis
            String animal2;
            String animal3;

            animal1 = Console.ReadLine(); //insira suas variaveis
            animal2 = Console.ReadLine();
            animal3 = Console.ReadLine();


            if ((animal1 == "vertebrado") && (animal2 == "ave") && (animal3 == "carnivoro" ))
            {
                Console.WriteLine("aguia");
            }

            if ((animal1 == "vertebrado") && (animal2 == "ave") && (animal3 == "onivoro"))
            {
                Console.WriteLine("pomba");
            }

            if ((animal1 == "vertebrado") && (animal2 == "mamifero") && (animal3 == "onivoro"))
            {
                Console.WriteLine("homem");
            }

            if ((animal1 == "vertebrado") && (animal2 == "mamifero") && (animal3 == "herbivoro"))
            {
                Console.WriteLine("vaca");
            }

            if ((animal1 == "invertebrado") && (animal2 == "inseto") && (animal3 == "hematofago"))
            {
                Console.WriteLine("pulga");
            }

            if ((animal1 == "invertebrado") && (animal2 == "inseto") && (animal3 == "herbivoro"))
            {
                Console.WriteLine("lagarta");
            }

            if ((animal1 == "invertebrado") && (animal2 == "anelideo") && (animal3 == "hematofago"))
            {
                Console.WriteLine("sanguessuga");
            }

            if ((animal1 == "invertebrado") && (animal2 == "anelideo") && (animal3 == "onivoro"))
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}