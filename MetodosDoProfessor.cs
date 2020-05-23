using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FormularioDoProfessor
{
    class MetodosDoProfessor
    {
        ArrayList m = new ArrayList();

        public ArrayList introduzir()
        {
            Professor d;

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            do
            {
                d = new Professor();

                d.SetNome(nome);
                d.SetCodigo(codigo);
                Console.WriteLine("Digite o contacto: ");
                d.SetContacto(long.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o Curso: ");
                d.SetCurso(Console.ReadLine());
                Console.WriteLine("Digite a turma: ");
                d.SetHoras(int.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o salario por hora: ");
                d.SetSalario(double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o nivel: ");
                d.SetNivel(Console.ReadLine());

                m.Add(d);

                //Console.BackgroundColor();
                Console.WriteLine("Registo feito com sucesso! \n");

                return m;
            } while (nome != null && codigo != 0);

        }

        public void imprimirObjectosProf(ArrayList m)
        {
            foreach (Professor p in m)
            {
                Console.WriteLine(p.ToString() + "\n Salario: " + p.valor());
            }
        }

        public void imprimir1(ArrayList m)
        {
            Console.WriteLine("Digite o Curso: ");
            string curso = Console.ReadLine();

            foreach (Professor v in m)
            {
                if (v.GetCurso().Equals(curso) || v.GetCurso().StartsWith(curso))
                {
                    Console.WriteLine("Nome: " + v.GetNome() + "\n" +
                                      "Salario: " + v.valor());
                }
            }
        }

        public void imprimirProfNivel(ArrayList m)
        {
            Console.WriteLine("Digite o nivel: ");
            string nivel = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            foreach (Professor z in m)
                if (z.GetNivel().Equals(nivel) && z.GetNome().Equals(nome))
                {
                    Console.WriteLine(z.ToString());
                }
                else
                    Console.WriteLine("Professor inexistente");
        }

        public static void actualizarNivel(ArrayList m)
        {
            Console.WriteLine("Digite o curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            foreach (Professor k in m)
            {
                if (k.GetCurso().Equals(curso) || k.GetNome().StartsWith(nome))
                {
                    Console.WriteLine("Introduza o novo nivel!");
                    k.SetNivel(Console.ReadLine());
                    Console.WriteLine("Actualização feita com sucesso!");
                }
                else
                    Console.WriteLine("Professor inexistente");
            }
        }

        public double salarioMed(ArrayList m)
        {
            double salMed = 0;

            foreach (Professor s in m)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                if (s.GetNome().Equals(nome))
                {
                    salMed = s.valor() / 2;
                    Console.WriteLine("Salario Medio: " + salMed);
                }
            }
            return salMed;
        }

        public void actualizaSal(ArrayList m)
        {
            Console.WriteLine("Digite o Curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            foreach (Professor v in m)
            {
                if (v.GetCurso().Equals(curso) || v.GetCurso().StartsWith(curso) && v.GetNome().Equals(nome) || v.GetNome().StartsWith(nome))
                {
                    Console.WriteLine("\n Introduza o novo salario por hora, a ser actualizo! ");
                    v.SetSalario(double.Parse(Console.ReadLine()));

                    Console.WriteLine("\n Actualização feita com sucesso! \n");
                }
            }
        }

        public void menu()
        {
            do
            {
                Console.WriteLine("\n ------MENU------\n" +
                                  "1.INTRODUZIR:...\n" +
                                  "2.IMPRIMIR:...\n" +
                                  "3.IMPRIMIR DADOS DOS PROFESSORES:...\n" +
                                  "4.IMPRIMIR PROFESSOR POR NIVEL:...\n" +
                                  "5.SALARIO MEDIO:...\n" +
                                  "6.ACTUALIZAR SALARIO:...\n" +
                                  "7.ACTUALIZAR NIVEL:...\n" +
                                  "8.Sair! \n");

                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1: introduzir(); break;
                    case 2: imprimirObjectosProf(m); break;
                    case 3: imprimir1(m); break;
                    case 4: imprimirProfNivel(m); break;
                    case 5: salarioMed(m); break;
                    case 6: actualizaSal(m); break;
                    case 7: actualizarNivel(m); break;
                    case 8: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Escolha uma das opçoes! [ 1/2/3/4/5/6/7/8 ] \n"); break;
                }

            } while (true);
        }
    }
}
