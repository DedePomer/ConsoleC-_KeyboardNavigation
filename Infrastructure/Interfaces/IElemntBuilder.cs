using ConsoleC__KeyboardNavigation.Model.Interfaces;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Interfaces
{
    public interface IElemntBuilder
    {
        IElemntBuilder SetId(int id);
        IElemntBuilder SetText(string text);
        IElemntBuilder SetExecute(Action<object?> element);
    }
}
