namespace ScriptureMem
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;



        public Reference(string book, int chapter, int startVerse)                      //for single verse
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = startVerse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)        //for multiple verses
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayReference()
        {
            if (_endVerse == _startVerse)
                return $"{_book} {_chapter}:{_startVerse} \n";                             //single verse return
            else
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse} \n";                 //multiple verse return
        }

    }
}