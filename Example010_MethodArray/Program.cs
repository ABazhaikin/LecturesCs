﻿int[] array = { 12, 24, 32, 44, 55, 86, 74, 38, 44};

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}