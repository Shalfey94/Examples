﻿int[] array = {11, 33, 2, 43, 12, 9, 24, 12};

int n = array.Length;
int find = 12;
int index = 0;

while(index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}