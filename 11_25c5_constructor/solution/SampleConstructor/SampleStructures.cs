/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-07
*/
public class SampleStructure
{
    //field
    public int _Data1;
    //property
    public int Data1{set=>_Data1=value; get=>_Data1;}
    //method
    public void Dosomething(){}
    //constructor
    public SampleStructure(){Data1=500;Dosomething();}
    public SampleStructure(int inputdata){Data1=inputdata;Dosomething();}
}

public class PeopleStructure
{
    //field
    public string _FirstName="", _LastName="";
    //property
    public string FirstName{set=>_FirstName = value; get=>_FirstName;}
    public string LastName{set=>_LastName = value;get=>_LastName;}
    //method
    public void WriteLog(string log){/*Write log in database*/}
    //constructor
    public PeopleStructure(){_FirstName="Jon";_LastName="Dow";WriteLog("Jon Dow is created");}
    public PeopleStructure(string inputFirstName, string inputLastName)
    {FirstName=inputFirstName;LastName=inputLastName;WriteLog($"{FirstName} {LastName} is created");}
}