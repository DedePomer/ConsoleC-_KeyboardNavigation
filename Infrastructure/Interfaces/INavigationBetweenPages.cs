using ConsoleC__KeyboardNavigation.Pages.Base;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Interfaces
{
    public interface INavigationBetweenPages
    {
        BasePage CurrentPage { get; set; }
        BasePage PreviousPage { get; set; }
    }
}
