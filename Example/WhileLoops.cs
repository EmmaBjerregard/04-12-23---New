class WhileLoops
{ 
    static void Main(){

        //Exercise 1
        //Write a program that reads a set of intergers, and then finds and prints the sum of the even and odd intergers.


        int Input;
        int sumEven = 0, sumOdd = 0;

        while (true){

            Console.WriteLine("Enter a number: ");
            Input = Convert.ToInt32(Console.ReadLine());

                if (Input % 2 == 0){
                Console.WriteLine("The number is even!");
                sumEven = Input + sumEven;

                }else{
                Console.WriteLine("The number is odd!");
                sumOdd = Input + sumOdd;

                }

            Console.WriteLine("Even number {0} and odd number {1}", sumEven, sumOdd);
        }


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





    }
}

