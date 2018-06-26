# Given an integer b (the length of the base of a triangle) and an integer a (the )area of that triangle, find the height h 
#such that it is the smallest possible height

#Sample Input 1
#
#17 100
#
#Sample Output 1
#
#12

#!/bin/python3

import sys

def lowestTriangle(base, area):
    # Complete this function

base, area = input().strip().split(' ')
base, area = [int(base), int(area)]
height = lowestTriangle(base, area)
print(height)
