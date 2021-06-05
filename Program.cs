using System;

namespace Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");

                        //var nota = decimal.Parse(Console.ReadLine()); 
                        //aluno.Nota = decimal.Parse(Console.ReadLine());


                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            if(nota <= 10)
                            {
                                aluno.Nota = nota;
                            }
                            else
                            {
                                throw new ArgumentException("Valor da nota deve ser menor ou igual a 10!\n\n\n\n");
                            }

                        }
                            
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!\n\n\n\n");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        //TODO: Adicionar Aluno
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome}\nNota: {a.Nota}");
                            }
                        }
                        // Listar Alunos
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal/nrAlunos;
                        

                        Conceito conceitoGeral;

                        if(mediaGeral <= 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral <= 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral <= 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Media Geral: {mediaGeral} - Conceito: {conceitoGeral}");


                        //TODO: Calcular Media Geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\n............................................\nInforme a opção desejada: \n1 - Inserir novo aluno\n2 - Listar alunos\n3 - Calcular média geral\nX - Sair\n............................................");
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}