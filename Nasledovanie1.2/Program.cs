using System;

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
       public  string lastname;                                                                // POLYA 

        public int course;

        private int numbook;

        public int validation;


        public string Lastname  {  set; get; }


        public virtual  int Course
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





        public int Numbook
        {

         set {

                value = numbook;
            }

            get
            {

                return numbook;
            }




        }


        public Student()
        {

        }


        public Student(string lastname, int course, int numbook)                                        // KONSTRUKTOR STUDENTA 
        {

           this.lastname = lastname;
           Course = course;
           this.numbook = numbook;
        
        }


        public virtual void Print()                                                                       // METOD PECHATI 
        {
           
           
            
            while (true)
            {
                Console.Write("Введите фамилию студента :  ");
                lastname = (Console.ReadLine());

                if (!int.TryParse(lastname, out validation))  
                {

                    Console.WriteLine(lastname);
                    break;
                }
                Console.WriteLine("Вы ввели числа. Ведите снова");


            }



            Console.Write("Курс обучения студента :  ");
            Course = int.Parse(Console.ReadLine());

            Console.Write("Номер зачетной книжки студента :  ");
            numbook = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Lastname of Student : {Lastname}  \nCourse : {Course}  \nNumber of Book : {numbook}\n");

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

        public override void Print()
        {
            while (true)
            {
                Console.Write("Введите фамилию аспиранта :  ");
                lastname = (Console.ReadLine());

                if (!int.TryParse(lastname, out validation))
                {

                    Console.WriteLine(lastname);
                    break;
                }
                Console.WriteLine("Вы ввели числа. Ведите снова");

            }

            

            Console.Write("Курс обучения аспиранта :  ");
            Course = int.Parse(Console.ReadLine());

            Console.Write("Номер зачетной книжки аспиранта :  ");
            Numbook = int.Parse(Console.ReadLine());

            Console.Write("Номер диссертации :  ");
            Disertation = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Lastname of Aspirant : {Lastname}  \nCourse : {Course}  \nNumber of Book : {Numbook}  \nNum of Disertation : {Disertation}\n");

        }


    }

    class University
    {
        private Student [] array = new Student[3];

        public Student this [int index]
        {
            get 
            {
                return array[index];
            }

             set
            {

                array[index] = value;
            }
        }


    }



    class zadacha6
    {
        static void Main(string[] args)
        {








            Console.WriteLine("Добро пожаловать в Гарвард\n");
            



            while (true)
            {


                    do
                    {

                        Console.WriteLine("Код : 1 - Студенческий лагерь  \nКод: 2 - Лагерь аспирантов  ");
                        int a = int.Parse(Console.ReadLine());


                        if (a == 1)
                        {
                            Console.WriteLine("Добро пожаловать в Студенческий лагерь ");

                            Student student1 = new Student();
                            //Student student2 = new Student();
                            //Student student3 = new Student();

                            student1.Print();
                        //student2.Print();
                        //student3.Print();
                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");
                        break;
                        }
                        else if (a == 2)
                        {
                            Console.WriteLine("Добро пожаловать в Лагерь Аспирантов");
                            Aspirant aspirant1 = new Aspirant();
                            //Aspirant aspirant2 = new Aspirant();
                            //Aspirant aspirant3 = new Aspirant();

                            aspirant1.Print();
                        //aspirant2.Print();
                        //aspirant3.Print();

                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");

                        break;
                           
                        }

                        else
                        {

                            Console.WriteLine("Введите снова");
                        }


                    //Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");

                    } while (true);

                    //Console.WriteLine("Если нужна еще информация нажмите цифру 3");
                //int ab = int.Parse(Console.ReadLine());


            }


        }
    }
}
