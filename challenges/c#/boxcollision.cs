/*
given the top left point and bottom right point of two boxes
write a function that prints Yes if there is a collision, or No if there is none

 */
 //You may try to convert to another language

 using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the checkMagazine function below.
    static void checkCollision(int Ax1, int Ay1, int Ax2, int Ay2, int Bx1, int By1, int Bx2, int By2) {


    }

    static void Main(string[] args) {
        string[] boxpoints = Console.ReadLine().Split(' ');

        int Ax1 = Convert.ToInt32(mn[0]);

        int Ay1 = Convert.ToInt32(mn[1]);

        int Ax2 = Convert.ToInt32(mn[2]);

        int Ay2 = Convert.ToInt32(mn[3]);

        int Bx1 = Convert.ToInt32(mn[4]);

        int By1 = Convert.ToInt32(mn[5]);

        int Bx2 = Convert.ToInt32(mn[6]);

        int Ay2 = Convert.ToInt32(mn[7]);

        checkCollision(Ax1, Ay1, Ax2, Ay2, Bx1, By1, Bx2, By2);
    }
}