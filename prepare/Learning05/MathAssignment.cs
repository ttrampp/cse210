using System;

class MathAssignment : Assignment                           //Create class MathAssignment that also inherits from base Assignment class
{
    private string _textbookSection;                        //Added attributes as private member variables
    private string _problems;
    //vv--below--vv//Created constructor that accepts all four parameters, including two from the base(call two from the base)
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;                 //Sets the values for the member variables
        _problems = problems;
    }

    public string GetHomeworkList()                         //Added method for GetHomeworkList to return textbookSection and problems
    {
        return _textbookSection + ":" + _problems;
    }
}