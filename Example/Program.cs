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
int number1, number2, number3;

Console.WriteLine("Enter first number: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The result of " + number1 + ", " + number2 + " and " + number3 + " is " + (number1 * number2 * number3));
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

