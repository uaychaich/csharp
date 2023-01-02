/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-02
*/

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