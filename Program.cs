Console.WriteLine("Введите колличество элементов в последовательности:");
int n =int.Parse(Console.ReadLine());
int [] arr = new int[n];  
int count=0;
Random rand = new Random();
Console.WriteLine("исходная последовательность:");
for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(1, 100);     
        Console.Write(arr[i] + " ");
        if (arr[i]%2 == 0)
            count++;
    }

Console.WriteLine();
if (count == 0)
Console.WriteLine("Четные числа отсутствуют");
else
{
    int j = 0;
    int[] newArray = new int[count];
    Console.WriteLine("последовательность четных чисел:");
    for(int i=0; i<n; i++)
    {
        if (arr[i] % 2 == 0)
        {
            newArray[j]=arr[i];
            Console.Write(newArray[j]+" ");
            j++;
        }

       }
}