using System;
using System.IO;

namespace EstudodeFiles {
    class Program {
        public static void EstudodeArquivos(FileTests teste) {
            var s = new ExerciciosComArquivos();
            s.TrabalhandoComArquivos((int)teste);
        }

        static void Main(string[] args) {

            Console.WriteLine("Exercicio com Files");
            Console.WriteLine();
            Console.WriteLine("1 – Estudo de manipulação de arquivos (File, FileInfo, FileStream e StreamReader ");
            Console.WriteLine("2 – Estudo de StreamWriter");
            Console.WriteLine("3 – Estudo de Directoryr");
            Console.WriteLine("4 – Estudo de Path");
            Console.WriteLine();
            Console.Write("Digite o código da sua opção: ");

            var Opcao = int.Parse(Console.ReadLine());

            try {
                while (Opcao > 0) {
                    int caseSwitch = Opcao;
                    switch (caseSwitch) {
                        case 1:
                            EstudodeArquivos(FileTests.Teste_de_FileStream_Ex3);
                            break;
                        case 2:
                            EstudodeArquivos(FileTests.Teste_de_StreanWriter);
                            break;
                        case 3:
                            EstudodeArquivos(FileTests.Teste_de_Directory);
                            break;
                        case 4:
                            EstudodeArquivos(FileTests.Teste_de_Path);
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Não existe essa opção de menu.");
                            break;
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("deu erro na bagaça " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
