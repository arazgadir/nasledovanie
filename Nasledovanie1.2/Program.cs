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
        private  string lastname;                                                                // POLYA 

        private int course;

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





        public virtual int Numbook { get; set; }
        


        public Student()
        {

        }


        public Student(string lastname, int course, int numbook)                                        // KONSTRUKTOR STUDENTA 
        {

           Lastname = lastname;
           Course = course;
           Numbook = numbook;
        
        }


        public virtual void Print()                                                                       // METOD PECHATI 
        {
           
           
            
            while (true)
            {
                Console.Write("Введите фамилию студента :  ");
                Lastname = (Console.ReadLine());

                if (!int.TryParse(Lastname, out validation))  
                {

                    Console.WriteLine(Lastname);
                    break;
                }
                Console.WriteLine("Вы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("Курс обучения студента :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер зачетной книжки студента :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }



            Console.WriteLine();

            Console.WriteLine($"Lastname of Student : {Lastname}  \nCourse : {Course}  \nNumber of Book : {numbook}\n");

        }

    }



    class Aspirant : Student                                                                                                           // KLASS ASPIRANT
    {

        private int course;

        public override int Numbook { get; set; }
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
                Lastname = (Console.ReadLine());

                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine(Lastname);
                    break;
                }
                Console.WriteLine("Вы ввели числа. Ведите снова");

            }

            

            
            while (true)
            {


                try
                {
                    Console.Write("Курс обучения аспиранта :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер зачетной книжки аспиранта :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("Номер диссертации :  ");
                    Disertation = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Пожалуйста введите только число");
                }
            }




            

            Console.WriteLine();

            Console.WriteLine($"Lastname of Aspirant : {Lastname}  \nCourse : {Course}  \nNumber of Book : {Numbook}  \nNum of Disertation : {Disertation}\n");

        }


    }




    class zadacha6
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Добро пожаловать в Гарвард\n");



            do
            {

                
                    Console.WriteLine("Код : 1 - Студенческий лагерь  \nКод: 2 - Лагерь аспирантов  ");
                
  
                string selection = ( Console.ReadLine());
                switch (selection)


             {
   
                    case "1":   
                        
                        Console.WriteLine("Добро пожаловать в Студенческий лагерь ");

                        Student student1 = new Student();
                        //Student student2 = new Student();
                        //Student student3 = new Student();

                        student1.Print();
                        //student2.Print();
                        //student3.Print();
                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");
                        break;
                    
                    case "2":
                        
                        Console.WriteLine("Добро пожаловать в Лагерь Аспирантов");
                        Aspirant aspirant1 = new Aspirant();
                        //Aspirant aspirant2 = new Aspirant();
                        //Aspirant aspirant3 = new Aspirant();

                        aspirant1.Print();
                        //aspirant2.Print();
                        //aspirant3.Print();
                        Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу");
                        break;


                    default:

                        Console.WriteLine("Нажмите на 1 или 2.");
                        break;

            }



            }  while (true);

  

        }
    }
}
