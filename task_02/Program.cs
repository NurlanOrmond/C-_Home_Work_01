Console.WriteLine ("Hello, provide three number to know which is max!");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max =a;

if (b>a) {
    max = b;

}

if (c>b) {
    max = c;
}

Console.WriteLine("The greatest number is:  " +max);