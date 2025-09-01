using ConsoleC__KeyboardNavigation.Infrastructure.Interfaces;
using ConsoleC__KeyboardNavigation.Model.DataType;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Builders
{
    public class SimpleElementBuilder : IElemntBuilder
    {
        private SimpleElement _element = new SimpleElement();
        public IElemntBuilder SetExecute(Action<object?> element)
        {
            _element.ExecuteElement += element;
            return this;
        }

        public IElemntBuilder SetId(int id)
        {
            _element.Id = id;
            return this;
        }

        public IElemntBuilder SetText(string text)
        {
            _element.Text = text;
            return this;
        }

        public SimpleElement Build()
        {
            return _element;
        }
    }
}
