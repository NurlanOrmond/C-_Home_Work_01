Console.WriteLine ("**********************************************************************************");
Console.WriteLine ("Give me a number then I'll show you all even numbers in range from 0 to your number");
Console.Write ("Your number:   ");
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= n; i++) {
        if (i%2==0) {
                Console.Write (i);
                Console.Write (" ");

        }
        
}

