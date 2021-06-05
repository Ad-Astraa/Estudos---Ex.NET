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
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
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
                        var notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome}\nNota: {a.Nota}");
                            }

                        }

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
            Console.WriteLine("\nInforme a opção desejada: \n1 - Inserir novo aluno\n2 - Listar alunos\n3 - Calcular média geral\nX - Sair\n............................................");
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}