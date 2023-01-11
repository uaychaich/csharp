/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-07
*/
public class SampleClass
{
    //field
    public int _Data1;
    //property
    public int Data1{set=>_Data1=value; get=>_Data1;}
    //method
    public void Dosomething(){}
    //constructor
    public SampleClass(){Data1=500;Dosomething();}
    public SampleClass(int inputdata){Data1=inputdata;Dosomething();}
}

public class PeopleClass
{
    //field
    public string _FirstName="", _LastName="";
    //property
    public string FirstName{set=>_FirstName = value; get=>_FirstName;}
    public string LastName{set=>_LastName = value;get=>_LastName;}
    //method
    public void WriteLog(string log){/*Write log in database*/}
    //constructor
    public PeopleClass(){_FirstName="Jon";_LastName="Dow";WriteLog("Jon Dow is created");}
    public PeopleClass(string inputFirstName, string inputLastName)
    {FirstName=inputFirstName;LastName=inputLastName;WriteLog($"{FirstName} {LastName} is created");}
}