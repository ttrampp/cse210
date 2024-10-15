using System;
using System.Collections.Generic;
using System.Linq;


namespace ScriptureMem
{
    public class Scripture
    {
        private Reference _reference;                             
        private List<Word> _words;

        public Scripture(Reference reference, string text)          
        {
            _reference = reference;

            _words = text.Split(' ').Select(word => new Word(word)).ToList();

        }

        public Reference GetReference()
        {
            return _reference;
        }
        public string GetDisplayText()
        {

            return _reference.GetDisplayReference() + " " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
        }

        public void HideRandomWords(int numToHide)
        {
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            numToHide = Math.Min(numToHide, visibleWords.Count);

            
            Random random = new Random();
            for (int i = 0; i < numToHide; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
            
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }

    }
}