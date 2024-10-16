using System;

class WritingAssignment : Assignment                            //Create class MathAssignment that also inherits from base Assignment class
{
    private string _title;                                      //Added attributes as private member variables
                                                                //vv--below--vv//Created constructor that accepts all four parameters, including two from the base(call two from the base)
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;                                         //Sets the values for the member variables
    }


    public string GetWritingInformation()                       //Added method for GetWritingInformation to return title
    {
        return _title;
    }
}