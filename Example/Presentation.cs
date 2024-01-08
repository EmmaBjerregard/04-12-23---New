class Presentation

{ 
    static void Main(){

        int triangle;

        Console.WriteLine("Enter a number from 1-10: ");
        triangle = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= triangle; i++){

            for (int j = 1; j <= i; j++){

                Console.Write(" * ");
            }



        }


    }
}