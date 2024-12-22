using CourseWork1.Interfaces;
using CourseWork1.Repositories;
using System;
using System.Collections.Generic;

namespace CourseWork1
{
    internal class Program
    {
        static void Main()
        {
            IRepository<IClient> repo = new ClientJsonRepository("..\\..\\..\\clients");
            repo.Add(new Client(0, "a", "b", "c", new DateTime(2005, 09, 23), new RUPassport("9519", "994238", new DateTime(2019, 10, 16), "mvd"), "C:\\Users\\дмитрий\\Desktop\\уник\\very important, top secret\\mew.jpeg"));


        }
    }
}
