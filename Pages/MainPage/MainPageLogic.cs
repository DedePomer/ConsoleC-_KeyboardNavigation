using ConsoleC__KeyboardNavigation.Infrastructure.Builders;
using ConsoleC__KeyboardNavigation.Infrastructure.Interfaces;
using ConsoleC__KeyboardNavigation.Model.DataType;

namespace ConsoleC__KeyboardNavigation.Pages.MainPage
{
    public partial class MainPage
    {
        private const string MENU_TITLE = "Управление реализованно с помощью стреок и enter\n";
        private const string MENU_SPLITTER = "#-------------------------------------------#\n";
        private void FillMenu()
        {
            SimpleElementBuilder builder = new SimpleElementBuilder();
            _menu.Add(builder.SetText("Продукты")
                .SetId(1)
                .SetExecute(OpenProducts)
                .Build());
            builder = new SimpleElementBuilder();
            _menu.Add(builder.SetText("Добавить продукт")
                .SetId(2)
                .SetExecute(OpenAddProducts)
                .Build());
            builder = new SimpleElementBuilder();
            _menu.Add(builder.SetText("Выйти")
                .SetId(3)
                .SetExecute(OpenExit)
                .Build());
        }

        private void MenuRendering()
        {
            Console.WriteLine(MENU_TITLE + MENU_SPLITTER);
            foreach (var item in _menu)
            {
                (item as SimpleElement).DisplayElement();
            }
        }
    }
}
