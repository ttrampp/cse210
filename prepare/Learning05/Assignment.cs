using System;

class Assignment                                                    //Create Class Assignment
{
    private string _studentName;                                    //Added attributes as private member variables
    private string _topic;

    public Assignment(string studentName, string topic)             //Created constructor that receives student name and topic
    {
        _studentName = studentName;                                 //Sets the values for the member variables
        _topic = topic;
    }


    public string GetSummary()                                      //Added method for GetSummary to return student's name and topic
    {
        return _studentName + ":" + _topic;
    }
}