# Given an integer b (the length of the base of a triangle) and an integer a (the )area of that triangle, find the height h 
#such that it is the smallest possible height

#Sample Input 1
#
#17 100
#
#Sample Output 1
#
#12

#!/bin/ruby

def lowestTriangle(base, area)
    # Complete this function
end

base, area = gets.strip.split(' ')
base = base.to_i
area = area.to_i
height = lowestTriangle(base, area)
puts height;