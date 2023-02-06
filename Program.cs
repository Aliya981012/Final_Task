void Final_Task()
{
    Console.WriteLine("Hello! First array:");
    string[] first = {"very","cool","lessons","can","not","decide","what","to","choose","next"};
    int size = first.Length;
    PrintArray(first);
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if (first[i].Length <= 3) count++;
    }
    string[] second = new string[count];
    for(int i = 0, j = 0; i < size; i++)
    {
        if (first[i].Length < 4)
        {
            second[j] = first[i];
            j++;
        } 
    }
    Console.WriteLine();
    Console.WriteLine("The second array is:");
    PrintArray(second);


}
void PrintArray(string[] array)
{
    int size = array.Length;
    Console.Write("[ ");
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}


Final_Task();
