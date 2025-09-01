using ConsoleC__KeyboardNavigation.Model.DataType;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Services
{
    public static class CreateOutputStringListService
    {
        public static List<string> GetSimpleElementsList(List<SimpleElement> elements)
        {
            List<string> outputStrings = new List<string>();
            foreach (var element in elements)
            {
                outputStrings.Add(element.GetDisplayElement());
            }
            return outputStrings;
        }
    }
}
