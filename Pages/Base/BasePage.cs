namespace ConsoleC__KeyboardNavigation.Pages.Base
{
    public class BasePage
    {
        private const int TOP_CURSOR_POSITION = 3;
        private ConsoleColor _defaultColor { get; } = Console.ForegroundColor;
        private ConsoleColor _highlightColor { get; } = ConsoleColor.Green;
        private List<string> _texts;

        private void HighlightElement(int correntCursorPosition, int pastCursorPosition)
        {
            Console.SetCursorPosition(0, pastCursorPosition);
            Console.WriteLine(_texts[pastCursorPosition - TOP_CURSOR_POSITION]);
            Console.SetCursorPosition(0, correntCursorPosition);
            Console.ForegroundColor = _highlightColor;
            Console.WriteLine(_texts[correntCursorPosition - TOP_CURSOR_POSITION]);
            Console.ForegroundColor = _defaultColor;
            Console.CursorTop = correntCursorPosition;
        }


        public int GetNumberSelectedElement(List<string> texts)
        {
            _texts = texts;
            int correntCursorPosition = TOP_CURSOR_POSITION;
            int downCursorPosition = texts.Count() + TOP_CURSOR_POSITION;
            Console.CursorTop = TOP_CURSOR_POSITION;
            ConsoleKey key;

            HighlightElement(correntCursorPosition, correntCursorPosition);

            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    if (correntCursorPosition > TOP_CURSOR_POSITION)
                    {
                        HighlightElement(correntCursorPosition - 1, correntCursorPosition);
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

            return correntCursorPosition - TOP_CURSOR_POSITION;

        }
    }
}
