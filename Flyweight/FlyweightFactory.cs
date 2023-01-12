using System;
using System.Collections.Generic;
using Flyweight.Models;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
            }
        }

        private string getKey(Car elem)
        {
            throw new NotImplementedException();
        }
    }
}