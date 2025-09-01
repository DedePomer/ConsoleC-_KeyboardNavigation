using ConsoleC__KeyboardNavigation.Infrastructure.Interfaces;
using ConsoleC__KeyboardNavigation.Pages.Base;

namespace ConsoleC__KeyboardNavigation.Infrastructure.Services
{
    public class NavigationBetweenPagesService : INavigationBetweenPages
    {
        private BasePage _currentPage;
        private BasePage _previousPage;

        public BasePage CurrentPage { get => _currentPage; set => _currentPage = value; }
        public BasePage PreviousPage { get => _previousPage; set => _previousPage = value; }
    }
}
