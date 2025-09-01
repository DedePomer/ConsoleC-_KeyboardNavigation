using ConsoleC__KeyboardNavigation.Model.DataType;
using ConsoleC__KeyboardNavigation.Model.Interfaces;

namespace ConsoleC__KeyboardNavigation.Pages.Base
{
    public class BasePage
    {
        private const int TOP_CURSOR_POSITION = 2;
        private ConsoleColor _defaultColor { get; } = Console.ForegroundColor;
        private ConsoleColor _highlightColor { get; } = ConsoleColor.Green;
        private List<SimpleElement> _elements; 

        private void HighlightElement(int correntCursorPosition, int pastCursorPosition)
        {
            Console.SetCursorPosition(0, pastCursorPosition);
            Console.WriteLine(_elements[pastCursorPosition - 1].Text);
            Console.SetCursorPosition(0, correntCursorPosition);
            Console.ForegroundColor = _highlightColor;
            Console.WriteLine(_elements[correntCursorPosition - 1].Text);
            Console.ForegroundColor = _defaultColor;
            Console.CursorTop = correntCursorPosition;
        }


        public void NavigationOnMenu(List<SimpleElement> elements)
        {
            _elements = elements;
            int correntCursorPosition = TOP_CURSOR_POSITION;
            int downCursorPosition = elements.Count() + TOP_CURSOR_POSITION;
            Console.CursorTop = TOP_CURSOR_POSITION;
            ConsoleKey key;

            HighlightElement(correntCursorPosition, correntCursorPosition);

            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    if (correntCursorPosition > TOP_CURSOR_POSITION)
                    {
                        HighlightElement(correntCursorPosition-1, correntCursorPosition);
                        correntCursorPosition--;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (correntCursorPosition < downCursorPosition - 1)
                    {
                        HighlightElement(correntCursorPosition + 1, correntCursorPosition);
                        correntCursorPosition++;
                    }
                }
            }

            elements[correntCursorPosition - 1].Execute(null);

        }




    }
}
