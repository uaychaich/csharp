/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-07
*/
public class Class1
{
    //field
    public int _Data1;
    //property
    public int Data1{set=>_Data1=value; get=>_Data1;}
    //method
    public int Method1()=>Data1;
    //constructor
    public Class1(){Data1=100;}
    public Class1(int inputdata1){Data1=inputdata1;}
}

public class Class1_1:Class1{}
public class Class1_2:Class1{
    public int _Data1_2;
    public int Data1_2{set=>_Data1_2=value; get=>_Data1_2;}
    public int Method1_2()=>Data1_2;
}

public class Class2 
{
    public int _Data2;
    public int Data2a{set=>_Data2=value; get=>_Data2;}
    public virtual int Data2b{set=>_Data2=value; get=>_Data2;}
    public int Method2a()=>Data2;
    public virtual int Method2b()=>Data2;
    public int Method2c()=>Data2;
    public Class2(){Data2=100;}
    public Class2(int inputdata2){Data2=inputdata2;}
}