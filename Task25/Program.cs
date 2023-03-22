// Task25
Console.Clear(); 
Console.WriteLine("Введите два числа: "); 
int A = int.Parse(Console.ReadLine()!); 
int B = int.Parse(Console.ReadLine()!); 
int result = 1; 
for (int i = 1; i <= B; i++) 
{ result = result * A; } 
 Console.WriteLine(result);