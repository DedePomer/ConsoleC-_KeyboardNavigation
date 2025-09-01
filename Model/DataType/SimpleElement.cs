namespace ConsoleC__KeyboardNavigation.Model.DataType
{
    public class SimpleElement: IElement
    {
        public int Id { get; set; }
        public string Text { get; set; }



        public event Action<object?> ExecuteElement;
        public void Execute(object? obj) => ExecuteElement?.Invoke(obj);
        public void DisplayElement() /*наверно не должен сдесь быть*/
        {
            Console.WriteLine(Text);
        }
    }
}
