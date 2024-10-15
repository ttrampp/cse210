using System;
using System.Collections.Generic;
using System.Linq;


namespace ScriptureMem
{
    public class Scripture
    {
        private Reference _reference;                               //_reference not used
        private List<Word> _words;

        public Scripture(Reference reference, string text)          //never called
        {
            _reference = reference;
            /////_words = [];
            _words = text.Split(' ').Select(word => new Word(word)).ToList();

            /////List<string> splitText = text.Split(" ").ToList();               //make a new list full of strings, call it splitText
            /////foreach (string word in splitText)
            /////{
            /////    _words.Add(new Word(word));
            /////}

        }

        public Reference GetReference()
        {
            return _reference;
        }
        public string GetDisplayText()
        {
            /////string displayText = "";

            /////foreach (Word word in _words)
            /////{
            /////    displayText += word.GetDisplayText() + " ";
            /////}
            /////return displayText.Trim();
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
            
            
            /////int hiddenCount = 0;

            /////while (hiddenCount < numToHide)
            /*{
                int randomIndex = randomWord.Next(_words.Count);

                if (!_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    hiddenCount++;
                }
            }*/
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
            /*foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;*/
        }

    }
}