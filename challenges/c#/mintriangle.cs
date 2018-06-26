/*# Given an integer b (the length of the base of a triangle) and an integer a (the )area of that triangle, find the height h 
#such that it is the smallest possible height

#Sample Input 1
#
#17 100
#
#Sample Output 1
#
#12
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int lowestTriangle(int base, int area){
        // Complete this function
    }

    static void Main(String[] args) {
        string[] tokens_base = Console.ReadLine().Split(' ');
        int base = Convert.ToInt32(tokens_base[0]);
        int area = Convert.ToInt32(tokens_base[1]);
        int height = lowestTriangle(base, area);
        Console.WriteLine(height);
    }
}