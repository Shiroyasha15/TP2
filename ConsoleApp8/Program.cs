using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    
        class Program

        {

            public static void Main(string[] args)

            {               
             string nome;
             string sobrenome;
             string cpf;
             string endereco;
             string telefone;
             string passagem;
             string vooNum;
             string vooHor;
             int poltrona = 0;
             string destino;
             string voo;

                
                Console.WriteLine("\n\n\n\n\t\t\t Empresa Aérea Queda Livre \n\n\n");

                Console.WriteLine(

                                  "\t---------------------Voos Disponiveis: ----------------------\n\n" +

                    "\n\n  Opção 1 - BH / RIO " +

                    "\n\n  Opção 2 - BH / SP " +

                    "\n\n  Opção 3 - BH / RECIFE ");

                Console.WriteLine("\t\t\t Insira o número correspondente ao voo desejado: \n\n");

                Console.Write("\t\t\t\t");

                voo = Console.ReadLine();

                if (voo == "1")
                {
                    destino = "Voo BH / RIO";
                }

                else if (voo == "2")
                {
                    destino = "Voo BH / SP";
                }

                else if (voo == "3")
                {
                    destino = "Voo BH / RECIFE";
                }

                while (true)
                {
                Passageiros passageiro1 = new Passageiros("José", "da Silva", "53489339029", "Rua Unai, 250", "3175707580", " 8575", "01", "00:00", 15);
                    passageiro1.Cadastrar();
                    Passageiros passageiro2 = new Passageiros("Osmar", "Caetano", "25026541062", "Rua Jozé Oswaldo, 1030", "1138415569", "9300", "02", "14:00",35);
                    passageiro2.Cadastrar();
                    Passageiros passageiro3 = new Passageiros("Cristina", "Sapphira", "82665084023", "Av Cristo Rei, 33", "2144445555", "7120", "02", "14:00", 21);
                    passageiro3.Cadastrar();
                    Passageiros passageiro4 = new Passageiros("Marinalva", "Pereira", "01788115058", "Av Jovenal de Souza", "7570705463", "8585", "03", "18:00", 50);
                    passageiro4.Cadastrar();
                    Passageiros passageiro5 = new Passageiros("Adalberto", "Falcão", "78033609044", "Rua das Cruzes","2141315161","9950","03", "18:00", 53);
                    passageiro5.Cadastrar();


                    Console.Clear();

                  

                    Console.WriteLine("-------------------MENU DE OPÇÕES---------------\n    ");



                    Console.WriteLine("║  Menu referente ao Voo -> " + destino);



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 1 LISTA DE PASSAGEIROS                        ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 2 PESQUISAR                                   ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 3 CADASTRAR PASSAGEIROS                       ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 4 EXCLUIR PASSAGEIRO DA LISTA                 ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 5 MOSTRAR LISTA DE ESPERA                     ║    ");



                    Console.WriteLine("║                                               ║    ");



                    Console.WriteLine("║ 6 SAIR                                        ║    ");



                    Console.WriteLine("╚═══════════════════════════════════════════════╝    ");



                    Console.WriteLine(" ");





                    Console.Write("Selecione a opção desejada : ");



                    var leitura = Console.ReadLine();






                if (leitura == "1")
                {

                    Console.Clear();
                    Console.WriteLine(passageiro1.Consulta1() + "\n\n");
                    Console.WriteLine(passageiro2.Consulta1() + "\n\n");
                    Console.WriteLine(passageiro3.Consulta1() + "\n\n");
                    Console.WriteLine(passageiro4.Consulta1() + "\n\n");
                    Console.WriteLine(passageiro5.Consulta1() + "\n\n");

                    Console.ReadKey();

                }


                if (leitura == "2")
                {

                    Console.Clear();
                    Console.WriteLine("Bem vindo a Busca de passageiros via cpf, por favor, insira o numero do CPF");

                    string SolicitaCpf = null;


                    SolicitaCpf = Console.ReadLine();



                    if (SolicitaCpf == passageiro1.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro1.Consulta2() + "\n\n");
                        Console.ReadKey();

                    }

                    if (SolicitaCpf == passageiro2.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro2.Consulta2() + "\n\n");
                        Console.ReadKey();

                    }

                    if (SolicitaCpf == passageiro3.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro3.Consulta2() + "\n\n");
                        Console.ReadKey();

                    }

                    if (SolicitaCpf == passageiro4.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro4.Consulta2() + "\n\n");
                        Console.ReadKey();

                    }

                    if (SolicitaCpf == passageiro5.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro5.Consulta2() + "\n\n");
                        Console.ReadKey();

                    }

                    if (SolicitaCpf != passageiro5.Contem(SolicitaCpf) && SolicitaCpf != passageiro1.Contem(SolicitaCpf)

                            && SolicitaCpf != passageiro3.Contem(SolicitaCpf) && SolicitaCpf != passageiro2.Contem(SolicitaCpf)

                            && SolicitaCpf != passageiro4.Contem(SolicitaCpf))



                    {

                        Console.WriteLine("\n\nPassageiro não localizado neste voo!");

                        Console.ReadKey();

                    }


                    if (leitura == "3")
                    {
                    Console.Clear();

                    Console.WriteLine("Bem vindo ao cadastro de passageiros, por favor, insira as informações solicitadas.");

                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o sobrenome: ");
                    sobrenome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF: ");
                    cpf = Console.ReadLine();
                    Console.WriteLine("Digite o endereço(logradouro e número): ");
                    endereco = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone: ");
                    telefone = Console.ReadLine();
                    Console.WriteLine("Digite o numero da passagem: ");
                    passagem = Console.ReadLine();
                    Console.WriteLine("Digite o numero do voo: ");
                    vooNum = Console.ReadLine();
                    Console.WriteLine("Digite o horário do voo: ");
                    vooHor = Console.ReadLine();
                    Console.WriteLine("Digite o número da poltrona:");
                    poltrona = Convert.ToInt32(Console.ReadLine());

                    }


                    if (leitura == "4")
                    {
                        // dificil essa, nao sei bem como fazer, acredito que armazenando os cadastros em vetores e limpando o espaço alocado, mas não soube mesmo como fazer
                    }
            
                    if (leitura == "5")
                    {
                        // para fazer este, teria que definir o limite do espaço nos voos, certo? eu procurei muito pela internet, exercicios parecidos, e achei alguns em java, que faziam isto, infelizmente nao consegui adaptar.
                    }

                    }

                    if (leitura == "6")
                    {
                        System.Environment.Exit(0);
                    }

                    Console.ReadKey();

                }

            }
        }
}
