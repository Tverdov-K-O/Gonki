using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonki
{
    abstract class Car // Автомобиль
    {
        public int Number { get; set; }         // номер автомобиля
        public int Speed { get; set; }          // скорость автомобиля
        public int Distance { get; set; } = 0;  // дистанция которую проехал
        public abstract void Ready();           // метод готовности автомобиля который вызывается через событие "carsRady"
        public abstract int Startrace();        // начало движения автомобиля
        public abstract void Winner();          // метод на случай победы автомобиля который вызывает событие "Winner"
    }

    class SportCar : Car // Спорткар
    {
        public SportCar(int N) { this.Number = N; }
        public override void Ready()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Спорткар готов к гонке!");
        }

        public override int Startrace()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int value = new Random().Next(1, 6);
            this.Distance += value;
            Console.Write($"Спорткар\t№[{this.Number}] дистанция: {Distance}km\t|Start|");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < this.Distance/2; i++){ Console.Write("-"); }
            Console.Write("S");
            for (int i = 0; i < 50 - this.Distance/2; i++) { Console.Write(" "); }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Finish|");
            return Distance;
        }
        public override void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nЯ - {this} №[{this.Number}] и я победил!");
        }
        public override string ToString()
        {
            return "Спорткар";
        }

        
    }
    class LiteCar : Car // Легковой автомобиль
    {
        public LiteCar(int N) { this.Number = N; }
        public override void Ready()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Легковушка готова к гонке!");
        }

        public override int Startrace()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int value = new Random().Next(2, 5);
            this.Distance += value;
            Console.Write($"Легковушка\t№[{this.Number}] дистанция: {Distance}km\t|Start|");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < this.Distance / 2; i++) { Console.Write("-"); }
            Console.Write("L");
            for (int i = 0; i < 50 - this.Distance / 2; i++) { Console.Write(" "); }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Finish|");
            return Distance;
        }
        public override void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Я - {this} №[{this.Number}] и я победил!");
        }
        public override string ToString()
        {
            return "Легковой автомобиль";
        }
    }
    class Truck : Car // Грузовик
    {
        public Truck(int N) { this.Number = N; }
        public override void Ready()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Грузовик готов к гонке!");
        }
        public override int Startrace()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int value = new Random().Next(3, 4);
            this.Distance += value;
            Console.Write($"Грузовик\t№[{this.Number}] дистанция: {Distance}km\t|Start|");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < this.Distance / 2; i++) { Console.Write("-"); }
            Console.Write("T");
            for (int i = 0; i < 50 - this.Distance / 2; i++) { Console.Write(" "); }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Finish|");
            return Distance;
        }
        public override void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Я - {this} №[{this.Number}] и я победил!");
        }
        public override string ToString()
        {
            return "Грузовик";
        }
    }
    class Bus : Car // Автобус
    {
        public Bus(int N) { this.Number = N; }
        public override void Ready()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автобус готов к гонке!");
        }

        public override int Startrace()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int value = new Random().Next(3, 4);
            this.Distance += value;
            Console.Write($"Автобус\t\t№[{this.Number}] дистанция: {Distance}km\t|Start|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < this.Distance / 2; i++) { Console.Write("-"); }
            Console.Write("B");
            for (int i = 0; i < 50 - this.Distance / 2; i++) { Console.Write(" "); }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Finish|");
            return Distance;
        }
        public override void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Я - {this} №[{this.Number}] и я победил!");
        }
        public override string ToString()
        {
            return "Автобус";
        }
    }


}
