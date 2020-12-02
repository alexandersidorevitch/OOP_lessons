﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Butterfly : LivingThingWithWings, IFlyable
    {
        public Butterfly(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
        public void Fly()
        {
            Console.WriteLine("*Нет звука*");
        }
    }
    //Абстрактный класс птица
    /*
     * Два интерйеса плавать, и летать
     Некоторые птицы умеют летать, некоторые умеют плавать,
     а некоторые не умеет ни того, ни другого
     Создать объект потомок курица, не умеет не летать, не плавать
     Создавать объект потомок утку от птицы, которая умеет и летать, и плавать
     Орел который умеет летать
     Пингвин умеет плавать,
     проста птица размах крыльев, средний вес, и максимальный возраст
     Средний вес и максимальный возраст - животное
     Птица частный случай животное
     Размах крыльев - птица
     Живое существо - животное
     ЖивоеСуще -> имеюющее крылья
     Комар и бабочка (их не надо, но можно) -> имеюющее крылья
     2 интерейфаса
    */
}
