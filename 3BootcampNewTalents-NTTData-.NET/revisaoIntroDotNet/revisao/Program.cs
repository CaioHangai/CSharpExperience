using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            var opcaoUsuario = ObteropcaoUsuario();

            //.ToUper É PARA CONVERTER O X PARA MAIÚSCULO PARA CASO O USUÁRIO DIGITAR MINUSCULO ELE CONVERTER PARA COMPARAR C/ MENU.  
            while (opcaoUsuario.ToUpper() != "X") ;
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: ADD ALUNO   
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        //TRYPARSE E UM METODO BOOLEANO QUE SE CONSEGUE OU NAO FAZER A CONVERSAO DE STRING PARA DECIMAL
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            //TRATA A EXCESSAO DE O USUARIO DIGITAR ALGO QUE NAO SEJA DECIMAL
                            throw new ArgumentException("Valor sa nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    //TODO: LISTAR ALUNOS
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))

                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;

                    //TODO: CALCULAR MEDIA GERAL 
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MEDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                        break;

                }

                opcaoUsuario = ObteropcaoUsuario();
            }

        }

        private static string ObteropcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inseririr novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
