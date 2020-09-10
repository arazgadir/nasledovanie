using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Nasledovanie.Zadacha2
{
    //    2) Создать базовый класс Счет, котороый содержит информацию - сумма, номер счета, дата открытия, 
    //        а также методы Выдача суммы и Выдача даты открытия счета.
    //       С помошью механизма наследования создать класс "Счет физического лица" и "Счет юридического лица.

    //      "Счет физического лица" содержит:
    //         поле "Вид счета"
    //         методы "Начисление процентов" и "Снятие денег со счета"

    //           "Счет юридического лица содержит:
    //             метод начисления процентов


    class Score
    {
        public double kassa { get; set; }

        public int numscore { get; set; }

        public string opendate { get; set; }



        public Score() { }



        public Score(double Kassa , int Numscore, string Opendate)
        {
            Kassa = kassa;
            Numscore = numscore;
            Opendate = opendate;

        }

      


        public void GetSum()                                                                      //   СУММЫ К ВЫДАЧЕ 
        {

            Console.Write("\nСумма на счету : " + kassa);


        }

        public void GetOpenDate()                                                                   // data otkritiya sheta 
        {

            Console.WriteLine("Дата открытия счета: ");
            DateTime date1 = new DateTime();
            Console.WriteLine(DateTime.Now);

        }



    }



    class Person : Score                                                              // shet   FIZ LICO
    {


        public string Scoretype { get; set; }


       
        public void infoP()

        {
            Console.Write("Введите сумму счета  :  ");
            kassa = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nНомер счета  :  ");
            numscore = int.Parse(Console.ReadLine());

            GetOpenDate();

            GetSum();

        }


        public void GetProcent()

        {
            double total = (kassa + ((kassa / 100) * 10));
            double procent = total - kassa;
            Console.WriteLine("Начисленные проценты: " + procent + "манат");

        }                                                                          // методы "Начисление процентов" и "Снятие денег со счета"



        public void GetMoney()
        {


            do

            {
                double total = (kassa + ((kassa / 100) * 10));

                Console.WriteLine("На счету " + total + " манатов");

                Console.WriteLine("\nСколько денег надо к выдаче : ");
                double Summ = Convert.ToDouble(Console.ReadLine());

                if (total >= Summ)
                {
                    Console.Write("Денег достаточно. " + Summ + "манат готовы к  выдаче. \n");
                    double remainder = total - Summ;

                    Console.WriteLine("Остаток на счету:" + remainder);                                    // ОСТАТОК В КАССЕ 
                    break;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег.Попробуйте снова \n");
                }


            } while (true);




        }


    }



    class Entity : Score                                                                   // SHET YURIDICESKOE LICO
    {


        public double Procent { get; set; }

      
        public void infoE()

        {
            Console.Write("Введите сумму счета  :  ");
            kassa = Convert.ToDouble(Console.ReadLine());


            Console.Write("\nномер счета  :  ");
            numscore = int.Parse(Console.ReadLine());


            GetOpenDate();

            GetSum();
        }



        public void GetProcent()
        {

            double total = (kassa + ((kassa / 100) * 10));
            double Procent = total - kassa;
            Console.WriteLine("\nНачисленные проценты: " + Procent + "манат");



        }
    }



    class Program
    {


        static void Main(string[] args)
        {
            _ = new Score();

            Entity E = new Entity();
            
            Person P = new Person();


            do
            {

           
            Console.WriteLine("Код : 1 - для физических лиц  \nКод: 2 - для юридических лиц  ");
            int a = int.Parse(Console.ReadLine());

            
            if (a==1 )
            {
                    Console.WriteLine("Добро пожаловать в отдел обслуживания Физических лиц");

                P.infoP();

                P.Scoretype = " Депозит\n";
                Console.Write("\nВид счета: " + P.Scoretype);

                P.GetProcent();
                P.GetMoney();
                    break;
            }
            else if (a== 2)
            {
                    Console.WriteLine("Добро пожаловать в отдел обслуживания Юридических лиц");
                    E.infoE();
                E.GetProcent();
                break;

            }
            
            else
            {

                Console.WriteLine("Введите снова");
            }



            } while (true);


        }


        
        
    }
}
