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

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int lowestTriangle(int base, int area){
        // Complete this function
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int base = in.nextInt();
        int area = in.nextInt();
        int height = lowestTriangle(base, area);
        System.out.println(height);
    }
}