/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-07
*/
SampleClass sc1 = new SampleClass();Console.WriteLine(sc1.Data1);
SampleClass sc2 = new SampleClass(700);Console.WriteLine(sc2.Data1);

SampleStructure ss1 = new SampleStructure();Console.WriteLine(ss1.Data1);
SampleStructure ss2 = new SampleStructure(700);Console.WriteLine(ss2.Data1);

PeopleClass pc1 = new PeopleClass();Console.WriteLine(pc1.FirstName);
PeopleClass pc2 = new PeopleClass("Uaychai","Chotjaratwanich");Console.WriteLine(pc2.FirstName);

PeopleStructure ps1 = new PeopleStructure();Console.WriteLine(ps1.FirstName);
PeopleStructure ps2 = new PeopleStructure("Uaychai","Chotjaratwanich");Console.WriteLine(ps2.FirstName);