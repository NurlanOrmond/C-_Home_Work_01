Console.WriteLine ("Hello, provide three number to know which is max!");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max =a;

if (b>max) {
    max = b;
}

if (c>max) {
    max = c;
}

Console.WriteLine("The greatest number is:  " +max +"!");