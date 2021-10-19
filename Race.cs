using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonki
{

    public delegate void Cars();    // делегат без параметров
    class Race
    {
        public int Distance { get; set; } = 100;    // дистанция 100км
        List<Car> Cars = new List<Car>();           // список Автомобилей в гонке
        public event Cars carsRady; // событие о готовности Автомобилей к гонке!
        public event Cars Winner;   // событие о победителе!
        int NumberCar = 0;          // номер машины!
        public Race() { }           // конструктор без параметров
        public void StartRace()     // гонка
        {
            carsRady();
            Console.ReadKey(); Console.Clear(); Console.ForegroundColor = ConsoleColor.White;
            while (Winner == null) 
            {
                System.Console.SetCursorPosition(0, 0);
                System.Console.CursorVisible = false;
                foreach (var item in Cars)
                {
                    item.Startrace();
                    if(item.Distance >= this.Distance && Winner == null)
                    {
                        Winner += item.Winner;
                    }
                }
                System.Threading.Thread.Sleep(200);
            }
            Winner();
            Console.ReadKey();
        }
        public void Menu()          // главное меню
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\t\t-Гонки-");
                Console.WriteLine(" 1 - Добавить в гонку Легковушку");
                Console.WriteLine(" 2 - Добавить в гонку Спорткар ");
                Console.WriteLine(" 3 - Добавить в гонку Грузовик");
                Console.WriteLine(" 4 - Добавить в гонку Автобус");
                Console.WriteLine(" 5 - Начать гонку");
                Console.WriteLine(" 6 - Выйти");
                int action = Convert.ToInt32(Console.ReadLine());
                Car car= null;
                switch (action)
                {
                    case 1:
                        car = new LiteCar(++NumberCar);
                        Cars.Add(car);
                        carsRady += car.Ready;
                        break;
                    case 2:
                        car = new SportCar(++NumberCar);
                        Cars.Add(car);
                        carsRady += car.Ready;
                        break;
                    case 3:
                        car = new Truck(++NumberCar);
                        Cars.Add(car);
                        carsRady += car.Ready;
                        break;
                    case 4:
                        car = new Bus(++NumberCar);
                        Cars.Add(car);
                        carsRady += car.Ready;
                        break;
                    case 5:
                        StartRace();
                        exit = true;
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
