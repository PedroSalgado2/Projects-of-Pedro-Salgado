# Projects

using System;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, district;
            int grade;
            

            Console.WriteLine("Type your name: ");
            name = Console.ReadLine(); 

            Console.WriteLine("Type your district: ");
            district = Console.ReadLine();

            Console.WriteLine("Type your grade: ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 10)
            {
                Console.WriteLine("Welcome " + name + " you live in " + district + ". Your grade is " + grade + " values, you are approved");
            }

            else
            {
                Console.WriteLine("Welcome " + name + " you live in " + district + ". Your grade is " + grade + " values, you are not approved");
            }

            Console.WriteLine("\nPorject done by: Pedro Miguel Meira Salgado");

            Console.ReadLine();

            Console.ReadKey();
        }  
    }
}

Guess the number game

using System;

namespace numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, i;

            Console.WriteLine("Lets play a game!");
            Console.WriteLine("\nYou have to guess a number!");
            Console.WriteLine("\nType a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Try to guess the number (you have 10 tries): ");

            int j = 1, tentativa;

            for (i = 0; i < 9; i++)
            {
                tentativa = j + i;
                Console.WriteLine("Try number " + tentativa);
                tentativa = Convert.ToInt32(Console.ReadLine());

                if (tentativa == num1)
                {
                    Console.WriteLine("Nice guess!");
                    Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
                    return;
                }
                else if (tentativa <= 10)
                {
                    Console.WriteLine("Wrong number! Try again!");
                    
                }


            }
            Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");

            Console.ReadKey();

        }
    }
}

Arrays Project

using System;

using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine("\n\nThe sum of the values are: " + arr.Sum());

            Console.WriteLine("\nThe values in descending order: ");
            foreach (int val in arr)
            { 
                Console.WriteLine("{0} ", val);
            }
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");

            Console.ReadLine();
        }
    }
}

Array Project 2

using System;

using System.Linq;

namespace Array Project 2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size=Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[size];
            int even, odd;

            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            even = 0;
            odd = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine("\nTotal even elements: {0}", even);
            Console.WriteLine("\nTotal odd elements: {0}", odd);
            Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}

Array Project 3

using System;

using System.Linq;

namespace Array Project 3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, size, num, pos;

            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2;

            Console.WriteLine("\nEnter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter element to insert : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the element position 1 to {0}:", size);
            pos = Convert.ToInt32(Console.ReadLine());

            if (pos > size + 1 || pos <= 0)
            {
                Console.Write("\nInvalid position! Please enter position between 1 to {0}", size);
            }
            else
            {
                arr2 = new int[size + 1];
                for (i = size; i >= pos; i--)
                {
                    arr2[i] = arr[i - 1];

                }

                arr2[pos - 1] = num;
                size++;

                for (i = 0; i < pos - 1; i++)
                {
                    arr2[i] = arr[i];
                }

                Console.Write("\nArray elements after insertion : ");
                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}\t", arr2[i]);
                }
            }

            Console.WriteLine("\n\nProject done by: Pedro Miguel Meira Salgado");
            Console.ReadLine();

        }
    }
}

Calculator Project

using System;

using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado;
            string operation;
            


            Console.WriteLine("Type the first number: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nType the second number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n+, -, x or / ?: ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                resultado = num1 * num2;
                Console.WriteLine("\nThe result is: " + num1 + " x " + num2 + " = " + resultado);
                Console.ReadLine();
                Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
            }
            else if (operation == "/")
            {
                resultado = num1 / num2;
                Console.WriteLine("\nThe result is: " + num1 + " / " + num2 + " = " + resultado);
                Console.ReadLine();
                Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
            }
            else if (operation == "+")
            {
                resultado = num1 + num2;
                Console.WriteLine("\nThe result is: " + num1 + " + " + num2 + " = " + resultado);
                Console.ReadLine();
                Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
            }
            else if (operation == "-")
            {
                resultado = num1 - num2;
                Console.WriteLine("\nThe result is: " + num1 + " - " + num2 + " = " + resultado);
                Console.ReadLine();
                Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
            }
        }
    }
}

Python Project

Meteo App

from configparser import ConfigParser
from tkinter import *
from tkinter import messagebox
import requests
import contextlib
import os

with contextlib.suppress(FileNotFoundError):
    os.remove("Images.py")

url_api = "https://api.openweathermap.org/data/2.5/weather?q={}&lang=pt&appid={}&units=metric"

api_file = "weather.key"
file_a = ConfigParser()
file_a.read(api_file)
api_key = file_a["api_key"]["key"]


def weather_find(city):
    final = requests.get(url_api.format(city, api_key))
    if final:
        json_file = final.json()
        city = json_file["name"]
        country_name = json_file["sys"]["country"]
        c_maxtemperature = json_file["main"]["temp_max"]
        c_mintemperature = json_file["main"]["temp_min"]
        f_maxtemperature = c_maxtemperature * 1.8 + 32
        f_mintemperature = c_mintemperature * 1.8 + 32
        feel_temperature = json_file["main"]["feels_like"]
        k_feel_temperature = feel_temperature * 1.8 + 32
        weather_display = json_file["weather"][0]["description"]
        result = (city, country_name, c_maxtemperature, f_maxtemperature, c_mintemperature, f_mintemperature, feel_temperature, k_feel_temperature, weather_display)

        return result
    else:
        return None


def print_weather():
    city = search_city.get()
    weather = weather_find(city)
    if weather:
        location_entry["text"] = "Cidade: {} País: {}".format(weather[0], weather[1])
        max_temperature_entry["text"] = "Máx. {:.2f} C, {:.2f} F".format(weather[2], weather[3])
        min_temperature_entry["text"] = "Min. {:.2f} C, {:.2f} F".format(weather[4], weather[5])
        feel_temperature_entry["text"] = "Temperatura Sentida: {:.2f} C, {:.2f} F".format(weather[6], weather[7])
        weather_entry["text"] = 'Estado do tempo: {}'.format(weather[8])

    else:
        messagebox.showerror("ERRO", "Digite uma cidade válida.")


root = Tk()

root.title("Projeto Meteorologia by Pedro Salgado")
root.geometry("900x500")
root.config(background="lightblue")

search_city = StringVar()
enter_city = Entry(root, textvariable=search_city, font=("Arial", 30, "bold"))
enter_city.pack()

search_button = Button(root, text="Procurar", width=15, bg="black", fg="white", font=("Arial", 15, "bold"),
                       command=print_weather)
search_button.pack()

location_entry = Label(root, text="", font=("Arial", 35, "bold"))
location_entry.pack()

max_temperature_entry = Label(root, text="", font=("Arial", 35, "bold"), bg="red")
max_temperature_entry.pack()

min_temperature_entry = Label(root, text="", font=("Arial", 35, "bold"), bg="blue")
min_temperature_entry.pack()

feel_temperature_entry = Label(root, text="", font=("Arial", 35, "bold"), bg="gray")
feel_temperature_entry.pack()

weather_entry = Label(root, text="", font=("Arial", 35, "bold"), bg="pink")
weather_entry.pack()

root.mainloop()
