/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2022-12-30
*/
//Arithmetic operators
var a1 = 7.5; 
var a2 = 5.2;
var a3 = a1+a2; Console.WriteLine(a3);
var a4 = a1-a2; Console.WriteLine(a4);
var a5 = a1*a2; Console.WriteLine(a5);
var a6 = a1/a2; Console.WriteLine(a6);
var a7 = a1%a2; Console.WriteLine(a7);
var a8 = a1++; Console.WriteLine(a8);
var a9 = a1--; Console.WriteLine(a9);
a1 = 7.5;
var a10 = ++a1; Console.WriteLine(a10);
var a11 = --a1; Console.WriteLine(a11);
a1 = 7.5;
a1 += 5; Console.WriteLine(a1);

//Concat operators
var b1 = "Uaychai";
var b2 = "Chotjaratwanich";
var b3 = b1 + b2; Console.WriteLine(b3);

//Compare operators
var c1 = 5==3; Console.WriteLine(c1);
var c2 = "Uay"=="uay"; Console.WriteLine(c2);
var c3 = 5!=3; Console.WriteLine(c3);
var c4 = 5>3; Console.WriteLine(c4);
var c5 = 5>=3; Console.WriteLine(c5);

//Logical operators
var d1 = true;
var d2 = false;
var d3 = d1 && d2; Console.WriteLine(d3);
var d4 = d1 || d2; Console.WriteLine(d4);
var d5 = !d1; Console.WriteLine(d5);