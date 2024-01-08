// See https://aka.ms/new-console-template for more information
//I am a comment

/*
I
Am
A
Comment
*/



// Console.Write("Line number one");

// Console.Write("Line number two");

// Console.WriteLine("Line number three");

// Console.Write("Line number four");


//Datatypes: int, float, string, bool
/*
int = helt tal (-5, 4, 6, 576 osv.)
float = decimaltal (5.6, 4.5, 6.7 osv.)
*/

/*
//Variables
int x; //declaration x
x = 4; //instantiation x

int y = 5; //declaration and instantiation y
*/







/*
Excersice 1

String name = "Emma";
Console.WriteLine("Hello!" + name);
*/



// Exersice 2
/*
int x = 5;
int y = 10;

Console.WriteLine("The sum of " + x + " and " + y + " is " + (x + y));
*/


// Exersice 3
/*
int x = 45;
int y = 5;

Console.WriteLine("The result of dividing " + x + " by " + y + " is " + (x / y));
*/


// Exersice 4



// Exersice 5



// Exersice 6
/*
int num1, num2, num3;

Console.WriteLine("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The result " + num1 + ", " + num2 + " and " + num3 + " is " + (num1 * num2 * num3));
*/






// Exersice 1
/*

int number1, number2;

Console.WriteLine("Enter first number: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2){
    Console.WriteLine(number1 + " and " + number2 + " are equal");
}else{
    Console.WriteLine(number1 + " and " + number2 + " are not equal");
}

*/


// Exersice 2
/*
int num1;

Console.WriteLine("Enter a whole number: ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0){
    Console.WriteLine(num1 + " is an even number");
}else{
    Console.WriteLine(num1 + " is an odd number");
}
*/


// Exersice 3
/*
int num1;

Console.WriteLine("Enter a number: ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0){
    Console.WriteLine(num1 + " is a positive number");
}else{
    Console.WriteLine(num1 + " is a negative number");
}
*/


// Exersice 4
/*
int year1;

Console.WriteLine("Enter your year: ");
year1 = Convert.ToInt32(Console.ReadLine());

if ((year1 % 400) == 0){
    Console.WriteLine(year1 + " is a leap year!");

}else if ((year1 % 100) == 0){
    Console.WriteLine(year1 + " is not a leap year!");

}else if ((year1 % 4) == 0){
    Console.WriteLine(year1 + " is a leap year!");

}else{
    Console.WriteLine(year1 + " is not a leap year!");
}
*/


// Exersice 5
/*
int age;

Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

if (age >= 21){
    Console.WriteLine("Your age of " + age + " is eligible to vote!");

}else{
    Console.WriteLine("Your age of " + age + " is NOT eligible to vote! ");
}
*/


// Exersice 6
/*

int m;
int n;

Console.WriteLine("Enter a number: ");
m = Convert.ToInt32(Console.ReadLine());

if (m > 0){
    n = 1;
    Console.WriteLine("n is " + n);

}else if(m == 0){
    n = 0;
    Console.WriteLine("n is " + n);

}else if(m < 0){
    n = -1;
    Console.WriteLine("n is " + n);

}
*/


// Exersice 7

/*
int height;

Console.WriteLine("Enter your height in cm: ");
height = Convert.ToInt32(Console.ReadLine());

if (height < 150){
    Console.WriteLine("Your height " + height + " HAHA! You are short!");

}else{
    Console.WriteLine(height + " That pretty okay ");

}
*/


// Exersice 8
/*

int num1, num2, num3;

Console.WriteLine("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3){
    Console.WriteLine(num1 + " is the largest number");

}else if (num2 > num1 && num2 > num3){
    Console.WriteLine(num2 + " is the largest number");

}else if (num3 > num1 && num3 > num2){
    Console.WriteLine(num3 + " is the largest number");

}
*/



// Exersice 9
/*

int coX, coY;

Console.WriteLine("Enter X coordinate: ");
coX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y coordinate: ");
coY = Convert.ToInt32(Console.ReadLine());

if (coX > 0 && coY > 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies in the First quadrant");

}else if (coX < 0 && coY > 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies in the Second quadrant");

}else if (coX < 0 && coY < 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies in the Third quadrant");

}else if (coX > 0 && coY < 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies in the Fourth quadrant");

}else if (coX == 0 && coY == 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies at the origin");

}else if (coX == 0 && coY != 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies at the Y axis");

}else if (coX != 0 && coY == 0){
    Console.WriteLine("The coordinate point (" + coX + "," + coY + ") lies at the X axis");

}
*/



// Exersice 10

/*
int math;
int phy;
int chem;

Console.WriteLine("Enter your math grade: ");
math = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your physics grade: ");
phy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your chemistry grade: ");
chem = Convert.ToInt32(Console.ReadLine());

if (math >= 65 && phy >= 55 && chem >= 50){
    if ((math + phy + chem) >= 180 || (math + phy) >= 140){
        Console.WriteLine("You are eligible for admission");
    }else{
        Console.WriteLine("You are not eligible for admission");

    }
}else{
    Console.WriteLine("You are not eligible for admission");

} 

*/



//19/12-23

// Exersice 11
/*

int a, b, c;
double d, x1, x2;

Console.WriteLine("Enter a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c: ");
c = Convert.ToInt32(Console.ReadLine());

d = b * b - 4 * a * c;

if (d == 0){
    Console.WriteLine("Both roots are equal");
    x1= -b /(2.0 * a);
    x2=x1;

    Console.WriteLine("The only root is: {0}", x1);

}else if(d>0){
    Console.WriteLine("There are two roots");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);

    Console.WriteLine("The first root is: {0}", x1);
    Console.WriteLine("The second root is: {0}", x2);

}else{
    Console.WriteLine("There is no solution");
}

*/



// Exersice 12
/*

using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

int RollNo, Phy, Chem, Comp, Total;
string Name, Division;
double Per;

Console.WriteLine("Enter your roll number: ");
RollNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your name: ");
Name = Console.ReadLine()!;

Console.WriteLine("Input the marks of Physics: ");
Phy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the marks of Chemistry: ");
Chem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the marks of computer application: ");
Comp = Convert.ToInt32(Console.ReadLine());

Total = Phy + Chem + Comp;
Per = Total / 3;

switch (Per){
    case > 60:
        Division = "First";
        break;
    case > 48:
        Division = "Second";
        break;
    case > 36:
        Division = "Pass";
        break;
    default:
        Division = "Fail";
        break;
}

Console.WriteLine("Roll No: {0}, Name of studen: {1}", RollNo, Name);
Console.WriteLine("Marks of Physics: {0} \n Marks in Chemisrty: {1} \n Marks in Computer Application: {2}", Phy, Chem, Comp);
Console.WriteLine("Total Marks = {0} \n Percentage = {1} \n Division = {2}", Total, Per, Division);
*/


// Exersice 13
/*
Temp < 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot
*/

/*
using System.Runtime.CompilerServices;

int temp;

Console.WriteLine("Enter the temperature in celsius: ");
temp = Convert.ToInt32(Console.ReadLine());

switch (temp){
    case < 0:
        Console.WriteLine("You butt be freezing, bring som vanter mit dem fluff ");
        break;
    case < 10:
        Console.WriteLine("It's cold, ask your grandma to knit a sweater and always bring some vanter mit dem fluff");
        break;
    case < 20:
        Console.WriteLine("It can be a bit chilled now, a good idea is to bring a jacket");
        break;
    case < 30:
        Console.WriteLine("It is normale tempearture, but if you are a dane, you would probably die from the heat");
        break;
    case < 40:
        Console.WriteLine("It's getting really hot now;)");
        break;
    default:
        Console.WriteLine("You are dead now, but it's okay, what is life anyway?");
        break;
}
*/


// Exersice 14
/*

int side1, side2, side3;

Console.WriteLine("Enter the leangth of side 1: ");
side1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the leangth of side 2: ");
side2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the leangth of side 3: ");
side3 = Convert.ToInt32(Console.ReadLine());

if (side1 == side2 && side2 == side3){
    Console.WriteLine("This is an equilateral triangle");

}else if(side1 == side2 || side1 == side2 || side2 == side3){
    Console.WriteLine("This is an isosceles triangle");

}else{
    Console.WriteLine("This is a scalene triangle");
}

*/


// Exersice 15
/*

int angle1, angle2, angle3, sumangle;

Console.WriteLine("Enter the first angle: ");
angle1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second angle: ");
angle2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third angle: ");
angle3 = Convert.ToInt32(Console.ReadLine());

sumangle = angle1 + angle2 + angle3;

switch (sumangle){
    case 180:
        Console.WriteLine("This is a valid triangle");
        break;
    case > 180:
        Console.WriteLine("This is not a valid triangle");
        break;
    case < 180:
        Console.WriteLine("Thid is not a valid triangle");
        break;

}
*/


// Exersice 16
/*

char ch;

Console.WriteLine("Enter a letter: ");
ch = Convert.ToChar(Console.ReadLine()!);

switch (ch){
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    case 'y':
        Console.WriteLine("This is a vowel");
        break;
    default:
        Console.WriteLine("This is a consonant");
        break;

}
*/


// Exersice 17
/*

int Balance, Withdrwal, Deposit, Newbalance;

Console.WriteLine("Enter your balance: ");
Balance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your withdrwal: ");
Withdrwal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your deposit: ");
Deposit = Convert.ToInt32(Console.ReadLine());

Newbalance = Balance - Withdrwal + Deposit;

switch (Newbalance){
    case < 0:
        Console.WriteLine("Your new balance is: " + Newbalance);
        break;
    case > 0:
        Console.WriteLine("Your new balance is: " + Newbalance);
        break;
    default:
        Console.WriteLine("Your new balance is: " + Newbalance);
        break;
}

*/



// Exersice 18
/*

String customerName;
int UnitConsumed, customerID;
double TotalAmount, charge;

Console.WriteLine("Enter your name: ");
customerName = Console.ReadLine()!;

Console.WriteLine("Enter your ID: ");
customerID = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the amount of units consumed: ");
UnitConsumed = Convert.ToInt32(Console.ReadLine());

switch (UnitConsumed){
    case < 199:
        charge = (UnitConsumed * 1.20);
        Console.WriteLine("ID: " + customerID + " Amount charged [0]", charge);
        break;
    case < 400:
        charge = (UnitConsumed * 1.50);
        Console.WriteLine("ID: " + customerID + " Amount charged [0]", charge);
        break;

}

*/



// Exersice 20
/*

int day;

Console.WriteLine("Enter the the day number (1-7, mon-sun):");
day = Convert.ToInt32(Console.ReadLine());

switch (day){
    case 1:
        Console.WriteLine("Day number {0} is monday", day);
        break;

    case 2:
        Console.WriteLine("Day number {0} is tuesday", day);
        break;  
    
    case 3:
        Console.WriteLine("Day number {0} is wednesday", day);
        break;

    case 4:
        Console.WriteLine("Day number {0} is thursday", day);
        break;
    
    case 5:
        Console.WriteLine("Day number {0} is friday", day);
        break;

    case 6:
        Console.WriteLine("Day number {0} is saturday", day);
        break;

    case 7: 
        Console.WriteLine("Day number {0} is sunday", day);
        break;
}
*/


//Excersice: 





//Exersice: Presentation
/*

int t;
int j, i;

    Console.WriteLine("Enter a number between 1-10: ");
    t = Convert.ToInt32(Console.ReadLine());

    if (t<=10){

        for (i = 1; i <= t; i++){
            for (j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }else{
        Console.WriteLine("The number is not valid");
    }

*/