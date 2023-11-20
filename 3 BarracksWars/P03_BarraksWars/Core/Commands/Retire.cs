using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core;
using System.Reflection;

public class Retire : Command
{
    public Retire(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
    {
    }

    public override string Execute()
    {
        string unitType = Data[1];

        Type repositoryType = Repository.GetType();
        MethodInfo removeUnitMethod = repositoryType.GetMethod("RemoveUnit", BindingFlags.Instance | BindingFlags.Public);

        try
        {
            removeUnitMethod.Invoke(Repository, new object[] { unitType });
            return $"{unitType} retired!";
        }
        catch (ArgumentException ex)
        {
            return "No such units in repository.";
        }
    }
}