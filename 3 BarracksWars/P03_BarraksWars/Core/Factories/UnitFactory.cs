namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Reflection;
    using _03BarracksFactory.Models.Units;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = Assembly.GetExecutingAssembly().GetType(unitType);
            return (IUnit)Activator.CreateInstance(type);
            //TODO: implement for Problem 3
        }
    }
}
