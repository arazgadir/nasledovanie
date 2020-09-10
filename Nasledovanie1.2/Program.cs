using System;
using System.Security.Cryptography.X509Certificates;

namespace zadacha6
{




    //    1) Создать базовый класс Student, который будет содержать информацию о студенте(фамилия, курс обучения, номер зачетной книги).
    //С помощью механизма наследование реализовать класс Aspirant(аспирант – студент, который готовится к защите кандидатской диссертации). Класс Aspirant есть производным от класса Student.
    //В классах Student и Aspirant необходимо реализовать следующие элементы:


    //конструкторы классов с соответствующим количеством параметров.В классе Aspirant для доступа к методам класса Student нужно использовать ключевое слово base;
    //    свойства get/set для доступа к полям класса;
    //    метод Print(), который выводит информацию о содержимом полей класса.






    class Student                                                                              // KLASS STUDENT

    {
        public string lastname;                                                                // POLYA 

        public int course;

        public int numbook;



        public virtual int Course
        {

            set

            {
                if (value >= 5)
                {
                    course = 4;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }                                                                      // SVOYSTVO Course




        public Student()
        {

        }


        public Student(string lastname, int course, int numbook)                                        // KONSTRUKTOR STUDENTA 
        {

            this.lastname = lastname;
            Course = course;
            this.numbook = numbook;

        }
        public void PrintS()
        {
            Console.Write("Lastname of Student: ");
            lastname = (Console.ReadLine());
            Console.WriteLine("Course: ");
            course = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbook: ");
            numbook = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        

    }



    class Aspirant : Student                                                                                                           // KLASS ASPIRANT
    {




        public int Disertation { get; set; }

        public override int Course
        {

            set

            {
                if (value >= 3)
                {
                    course = 2;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }

        public Aspirant() : base()
        {

        }


        public Aspirant(string lastname, int course, int numbook, int disertation)                                                            // VIZOV KONSTRUKTORA BAZI
            : base(lastname, course, numbook)


        {

            Disertation = disertation;

        }
        public void PrintA()
        {
            Console.Write("Lastname of Student: ");
            lastname = (Console.ReadLine());
            Console.WriteLine("Course: ");
            course = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbook: ");
            numbook = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        

    }



    class zadacha6
    {

        Student[] data;


        static void Main(string[] args)
        {

            Student student1 = new Student();
            Console.WriteLine("Инофомация о Первом студенте: ");
            student1.PrintS();
            Student student2 = new Student();
            Console.WriteLine("Инофомация о Втором студенте: ");
            student2.PrintS();
            Student student3 = new Student();
            Console.WriteLine("Инофомация о Третем студенте: ");
            student3.PrintS();



            Aspirant aspirant1 = new Aspirant();
            Console.WriteLine("Инофомация о Первом Аспиранте: ");
            aspirant1.PrintA();
            Aspirant aspirant2 = new Aspirant();
            Console.WriteLine("Инофомация о Втором Аспиранте: ");
            aspirant2.PrintA();
            Aspirant aspirant3 = new Aspirant();
            Console.WriteLine("Инофомация о Третем Аспиранте: ");
            aspirant3.PrintA();





           











        }
    }
}
