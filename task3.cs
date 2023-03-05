bool flag = true;
int increment = 0;
Console.WriteLine("Please enter the size of the array");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
do
{
    Console.WriteLine("Do you want to continue? ");
    string answer = Console.ReadLine();
    if (answer == "y" || answer == "Y")
    {
        increment++;
        Array.Resize(ref numbers, numbers.Length + 1);
        Console.WriteLine("Enter element ");
        numbers[increment] = Convert.ToInt32(Console.ReadLine());
    }
    else if(answer=="no")
    {
        flag = false;
        Console.WriteLine("........exiting");
        break;
    }
}
while (flag);
for (int i = 0; i < increment; i++) 
{
    Console.WriteLine(numbers[i]);
}

        
       

      