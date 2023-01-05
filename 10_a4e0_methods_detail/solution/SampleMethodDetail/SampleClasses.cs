/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-05
*/
public class SampleClassMethod
{
    public void method1(int input1){}
    public void method1(int input1, int input2){}

    public void method2(int input1, out int output1)
    {output1=6;}

    public void method3(params int[] inputlist){}
}


public class PeopleClass
{
    //field
    public string _FirstName, _LastName;
    public double _Height;
    
    //method
    public void setFirstName(string inputFirstName)
    {   _FirstName = inputFirstName;    }
    public string getFirstName()
    {   return _FirstName;}
    public void setLastName(string inputLastName)=>_LastName=inputLastName;
    public string getLastName()=>_LastName;
}