using System;
namespace ClassExample
{
   /* class Student
    {
        //Field
        public string name;
        public int number;
        public double GPA;


        //methods davranışları yazıyoruz.
        public void ShowInfo()
        {
            //...gelecek özelliği yazıyoruz.
        }
        public double CaalculateGpa()
        {
            return midterm * 0.4 + finalexam * 0.6;
        }

    }*/
    class Car
    {
        public string brand;
        public string model;
        public int year;
        public double speed;


        //methods
        public void Start()
        {
            Console.WriteLine($"{brand} {model} çalistirildi.");//dolar işaretinden sonra boşluk yok
          
        }
        public void Accelerate(double increase)
        {
            speed += increase;
            Console.WriteLine($"Hiz artirildi. Yeni hiz : {speed} km/h");
        }
        public void Brake (double decrease)
        {
            speed -= decrease;
            if(speed < 0)
            speed=0;
            Console.WriteLine($"Fren yapildi.Yeni hiz: {speed} km/h");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Markasi: {brand}, Model: {model}, Yil:{year}, Anlik Hiz: {speed} km/h");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //obje oluşturma işlemi
            Car mycar = new Car();

            mycar.brand = "Tesla";
            mycar.model = "Model 3";
            mycar.year = 2022;
            mycar.speed = 0;
            //nesne methodlarını çağırma
            mycar.ShowInfo();
            mycar.Start();
            mycar.Accelerate(50);
            mycar.Accelerate(30);
            mycar.Brake(40);
            mycar.ShowInfo();
        }
    }
}