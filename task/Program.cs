string[] mas = { "Hello", "2", "world", ":-)", "1234", "1567", "-2" };
Sort(mas);

void Sort(string[] array)
{
    for (int i = 0; i < mas.Length; i++)
        if (mas[i].Length <= 3)
            Console.Write(mas[i] + ", ");
}
