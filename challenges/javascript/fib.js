/*
The Fibonacci Sequence

The Fibonacci sequence appears in nature all around us, in the arrangement of seeds in a sunflower and the spiral of a nautilus for example.

The Fibonacci sequence begins with fib(0) = 0 and fib(1) = 1 as its first and second terms. After these first two elements, each subsequent element is equal to the sum of the previous two elements.

Programmatically:
fib(0) = 0
fib(1) = 1
fib(n) = fib(n-1) + fib(n-2)

Given N , return the Nth number in the sequence.

As an example, n = 5 . The Fibonacci sequence to 6 is fs[1,1,2,3,5,8] . With zero-based indexing, fs[5] =5 .

Function Description

Complete the recursive function fibonacci in the editor below. It must return the nth element in the Fibonacci sequence.

fibonacci has the following parameter(s):

    n: the integer index of the sequence to return

Input Format

The input line contains a single integer, .

Constraints 0 < n <= 30

Output Format

Locked stub code in the editor prints the integer value returned by the function.

Sample Input

3  

Sample Output

2


*/

function processData(input) {
    var n = parseInt(input);
    console.log(fibonacci(n));
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});

function fibonacci(n) {



}