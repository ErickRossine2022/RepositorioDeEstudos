using System.Text.RegularExpressions;

class Provas
{
    private int resposta;
    private string? escolha;

    public bool Final = false;

    public void Matemática(Aluno aln, int Pergunta)
    {
        bool loop = true;

        if (Pergunta == 1)
        {
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Resolva a Equação: 3x + 7 = 19");
                Console.WriteLine("======================================\n");

                escolha = Console.ReadLine();

                if (!int.TryParse(escolha, out resposta))
                {
                    Console.WriteLine("\nVocê não digitou a resposta corretamente. Tente novamente!\n");
                }

                if (resposta == 4)
                {
                    Console.WriteLine("\nResposta Correta!\n");
                    Carregando.LoadingSystem(100, 100, true);
                    Matemática(aln, 2);
                    aln.nota += 1.5;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nResposta Errada. Tente novamente!\n");
                }

            } while (loop);
        }

        else if (Pergunta == 2)
        {
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Qual é a raiz quadrada de 64?");
                Console.WriteLine("======================================\n");

                escolha = Console.ReadLine();

                if (!int.TryParse(escolha, out resposta))
                {
                    Console.WriteLine("\nVocê não digitou a resposta corretamente. Tente novamente!\n");
                }

                if (resposta == 8)
                {
                    Console.WriteLine("\nResposta Correta!\n");
                    Carregando.LoadingSystem(100, 100, true);
                    Matemática(aln, 3);
                    aln.nota += 1.5;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nResposta Errada. Tente novamente!\n");
                }

            } while (loop);
        }

        else if (Pergunta == 3)
        {
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Quanto é (24 * 5) + 8 / 2 ?");
                Console.WriteLine("======================================\n");

                escolha = Console.ReadLine();

                if (!int.TryParse(escolha, out resposta))
                {
                    Console.WriteLine("\nVocê não digitou a resposta corretamente. Tente novamente!\n");
                }

                if (resposta == 124)
                {
                    Console.WriteLine("\nResposta Correta!\n");
                    Carregando.LoadingSystem(100, 100, true);
                    Portugues(aln, 1);
                    aln.nota += 1.5;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nResposta Errada. Tente novamente!\n");
                }

            } while (loop);
        }
    }

    public void Portugues(Aluno aln, int Pergunta)
    {
        if (Pergunta == 1)
        {
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("A leitura é uma janela para o mundo. Quem lê, enxerga além do que está diante dos olhos.");
                Console.WriteLine("Qual é a mensagem principal do texto?");
                Console.WriteLine("======================================\n");

                Console.WriteLine("A) A leitura é cansativa e pouco útil.");
                Console.WriteLine("B) Ler é uma obrigação escolar.");
                Console.WriteLine("C) Quem lê perde tempo com imaginação.");
                Console.WriteLine("D) A leitura amplia o conhecimento e ajuda a compreender melhor o mundo.");
                Console.WriteLine("E) Ler serve apenas para fazer provas.");
                Console.WriteLine("F) A leitura é uma atividade exclusiva de escritores.\n");

                Console.WriteLine("Se baseando na pergunta e nas opções de (A) a (F), qual é a resposta correta?");
                Console.Write("Digite aqui: ");

                escolha = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(escolha))
                {
                    Console.WriteLine("\nVocê não digitou a resposta corretamente. Tente novamente!\n");
                }
                else if (char.IsDigit(escolha[0]))
                {
                    Console.WriteLine("\nA resposta não deve ser um número, e sim uma letra!\n");
                    escolha = null;
                }

            } while (string.IsNullOrWhiteSpace(escolha));

            if (escolha == "A")
            {
                Console.WriteLine("\nResposta A Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "B")
            {
                Console.WriteLine("\nResposta B Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "C")
            {
                Console.WriteLine("\nResposta C Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "D")
            {
                Console.WriteLine("\nResposta D Correta!");
                Console.WriteLine("A leitura amplia o conhecimento e ajuda a compreender melhor o mundo.\n");
                Carregando.LoadingSystem(100, 100, true);
                Portugues(aln, 2);
                aln.nota += 1.5;
            }
            else if (escolha == "E")
            {
                Console.WriteLine("\nResposta E Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "F")
            {
                Console.WriteLine("\nResposta F Errada. Programa Encerrado!\n");
                return;
            }
            else
            {
                Console.WriteLine("\nVocê digitou uma resposta inválida. Programa Encerrado!\n");
                return;
            }
        }

        else if (Pergunta == 2)
        {
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Identifique e classifique o sujeito na frase:");
                Console.WriteLine("Os professores corrigiram as provas com atenção.");
                Console.WriteLine("======================================\n");

                Console.WriteLine("A) Sujeito oculto — eles.");
                Console.WriteLine("B) Sujeito indeterminado.");
                Console.WriteLine("C) Sujeito simples — 'Os professores'.");
                Console.WriteLine("D) Sujeito composto — 'Os professores e os alunos'.");
                Console.WriteLine("E) Oração sem sujeito.");
                Console.WriteLine("F) Sujeito indeterminado — verbo impessoal.\n");

                Console.Write("Digite aqui: ");
                escolha = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(escolha))
                {
                    Console.WriteLine("\nA resposta não deve ser vazia. Tente novamente!\n");
                    escolha = null;
                }

            } while (string.IsNullOrWhiteSpace(escolha));

            if (escolha == "A")
            {
                Console.WriteLine("\nResposta A Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "B")
            {
                Console.WriteLine("\nResposta B Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "C")
            {
                Console.WriteLine("\nVocê respondeu C — Resposta Correta!");
                Console.WriteLine("Sujeito simples — 'Os professores'.\n");
                Carregando.LoadingSystem(100, 100, true);
                aln.nota += 1.5;
                Final = true;
            }
            else if (escolha == "D")
            {
                Console.WriteLine("\nResposta D Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "E")
            {
                Console.WriteLine("\nResposta E Errada. Programa Encerrado!\n");
                return;
            }
            else if (escolha == "F")
            {
                Console.WriteLine("\nResposta F Errada. Programa Encerrado!\n");
                return;
            }
            else
            {
                Console.WriteLine("\nVocê digitou uma resposta inválida. Programa Encerrado!\n");
                return;
            }
        }
    }
}
