using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;

            do
            {

                Console.WriteLine("Escolha uma opção: \n" +
                    "1 - para cadastrar novo professor. \n" +
                    "2 - para cadastrar novo aluno. \n" +
                    "3 - para cadastrar nova disciplina. \n" +
                    "0 - para encerrar o programa");
                escolha = Console.ReadLine();


                if (escolha == "1")
                {


                    Console.WriteLine("Cadastramento de um novo professor");
                    Professores professor = new Professores();
                    Console.WriteLine("Digite o nome do professor: ");
                    professor.NomeProfessor = Console.ReadLine();
                    Console.WriteLine($"Digite o tempo de empresa do professor {professor.NomeProfessor}: ");
                    professor.TempoDeEmpresa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Digite a idade do professor {professor.NomeProfessor}: ");
                    professor.IdadeProfessor = Convert.ToInt32(Console.ReadLine());
                    if (professor.TempoDeEmpresa < 5)
                    {
                        professor.NovoNaEscola = true;
                    }

                    Console.WriteLine($"Cadastramento do professor {professor.NomeProfessor}, com {professor.IdadeProfessor} anos de idade. \n" +
                        $"Ele é novo na empresa: {professor.NovoNaEscola}, pois o tempo dele na impresa é de: {professor.TempoDeEmpresa} anos");
                }

                else if (escolha == "2")
                {


                    Alunos aluno = new Alunos();
                    Console.WriteLine("Cadastramento de um novo aluno");
                    Console.WriteLine("Digite o sexo do estudante (M - masculino / F - feminino): ");
                    aluno.sexo = Convert.ToChar(Console.ReadLine());
                    if (aluno.sexo == 'M')
                    {
                        Console.WriteLine("Digite o nome do aluno: ");
                        aluno.NomeAluno = Console.ReadLine();
                        Console.WriteLine($"Digite a idade do {aluno.NomeAluno}: ");
                        aluno.IdadeAluno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Digite a série do {aluno.NomeAluno}: ");
                        aluno.AnoAluno = Console.ReadLine();
                        Console.WriteLine($"Digite a nota do {aluno.NomeAluno}: ");
                        aluno.NotasAlunos = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Cadastramento de um nova aluna");
                        Console.WriteLine("Digite o nome do aluna: ");
                        aluno.NomeAluno = Console.ReadLine();
                        Console.WriteLine($"Digite a idade da {aluno.NomeAluno}: ");
                        aluno.IdadeAluno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Digite a série da {aluno.NomeAluno}: ");
                        aluno.AnoAluno = Console.ReadLine();
                        Console.WriteLine($"Digite a nota da {aluno.NomeAluno}: ");
                        aluno.NotasAlunos = Convert.ToDouble(Console.ReadLine());
                    }
                    if (aluno.NotasAlunos > 7)
                    {
                        aluno.Aprovado = true;
                    }
                    else
                    {
                        aluno.Aprovado = false;
                    }

                    if (aluno.Aprovado == true)
                    {
                        Console.WriteLine($"Parabéns {aluno.NomeAluno}, sua nota final foi {aluno.NotasAlunos} e você foi promovido(a) para o próximo ano.");
                    }
                    else
                    {
                        Console.WriteLine($"{aluno.NomeAluno}, não foi desta vez. Sua nota foi {aluno.NotasAlunos} e você ficou de recuperação.");
                    }


                }
                else if (escolha == "3")
                {
                    Disciplinas disciplina = new Disciplinas();
                    Console.WriteLine("Cadastre uma nova disciplina!");
                    Console.WriteLine("Digite o bimestre: ");
                    disciplina.Bimentre = Console.ReadLine();
                    Console.WriteLine($"Digite a nota p1 para o {disciplina.Bimentre} bimestre: ");
                    disciplina.P1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Digite a nota p2 para o {disciplina.Bimentre} bimestre: ");
                    disciplina.P2 = Convert.ToDouble(Console.ReadLine());
                    disciplina.MediaFinal = (disciplina.P1 + disciplina.P2) / 2;
                    Console.WriteLine("Digite uma disciplina: ");
                    disciplina.Disciplina = Console.ReadLine();
                    if (disciplina.MediaFinal >= disciplina.MediaAprovacao)
                    {
                        Console.WriteLine($"No {disciplina.Bimentre} bimestre, em {disciplina.Disciplina} suas notas foram na p1: {disciplina.P1}," +
                        $" e na p2: {disciplina.P2}, obtendo assim uma média {disciplina.MediaFinal} e por isso está aprovado. Parabéns");
                    }
                    else
                    {
                        Console.WriteLine($"No {disciplina.Bimentre} bimestre, em {disciplina.Disciplina} suas notas foram na p1: {disciplina.P1}," +
                        $" e na p2: {disciplina.P2}, obtendo assim uma média {disciplina.MediaFinal} e por isso está reprovado. Sinto muito");
                    }
                }

                else if (escolha == "0")
                {
                    Console.WriteLine("O programa foi encerrado");
                    break;
                }
            } while (escolha != "0");

            }



        }
    }

