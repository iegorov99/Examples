﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

/*int a1 = 19;
int b1 = 32;
int c1 = 73;
int a2 = 494;
int b2 = 65;
int c2 = 46;
int a3 = 71;
int b3 = 82;
int c3 = 19;
*/
//               0   1   2   3   4   5   6   7   8
int[] array = { 19, 62, 35, 49, 55, 76, 73, 82, 19 };
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);
/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max (max1, max2, max3);
*/
/*int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
*/