using ConsoleC__KeyboardNavigation.Model.DataType;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Builders
{
    public class SimpleElementBuilder
    {
        private SimpleElement _element = new SimpleElement();
        public SimpleElementBuilder SetExecute(Action<object?> element)
        {
            _element.ExecuteElement += element;
            return this;
        }

        public SimpleElementBuilder SetId(int id)
        {
            _element.Id = id;
            return this;
        }

        public SimpleElementBuilder SetText(string text)
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
