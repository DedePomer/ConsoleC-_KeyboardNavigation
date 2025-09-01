using ConsoleC__KeyboardNavigation.Infrastructure.Interfaces;
using ConsoleC__KeyboardNavigation.Infrastructure.Services;
using ConsoleC__KeyboardNavigation.Model.DataType;
using ConsoleC__KeyboardNavigation.Pages.Base;

namespace ConsoleC__KeyboardNavigation.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        private const bool CURSOR_VISIBLE = false;


        private INavigationBetweenPages _navigation;
        private List<SimpleElement> _menu = new List<SimpleElement>();

        public MainPage(INavigationBetweenPages navigation)
        {
            Console.CursorVisible = CURSOR_VISIBLE;
            _navigation = navigation;
            FillMenu();
            MenuRendering();
            SimpleElement element = _menu[GetNumberSelectedElement(CreateOutputStringListService.GetSimpleElementsList(_menu))];
            element.Execute(element);
        }

        private void OpenProducts(object? obj)
        {
            Environment.Exit(0);
        }
        private void OpenAddProducts(object? obj)
        {
            Environment.Exit(0);
        }
        private void OpenExit(object? obj)
        {
            Environment.Exit(0);
        }
    }
}
