/*
    John works at a clothing store. 
    He has a large pile of socks that he must pair by color for sale. 
    Given an array of integers representing the color of each sock, 
    determine how many pairs of socks with matching colors there are. 
    
    For example, there are n socks with colors ar=[1,2,1,2,1,3,2]. 
    There is one pair of color 1 and one of color 2. 
    There are three odd socks left, one of each color. 
    The number of pairs is 3. 
    
    Function Description
    Complete the sockMerchant function in the editor below. 
    It must return an integer representing the number of matching pairs of socks that are available.

    sockMerchant has the following parameter(s):
    n: the number of socks in the pile
    ar: the colors of each sock
    
    Input Format
    The first line contains an integer n, the number of socks represented in ar.
    The second line contains n space-separated integers describing the colors ar[i] of the socks in the pile.

    Output Format
    Return the total number of matching pairs of socks that John can sell.
*/
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

class SockMerchant
{

    //the sockMerchant function below is written by me
    //rest of the code is HackerRank's courtesy.
    static int sockMerchant(int n, int[] ar)
    {
        //The concept here is very simple
        //casting the input array into a hashset removes all duplicate values
        HashSet<int> hsh = new HashSet<int>();
        hsh = ar.ToHashSet();
        //setting initial count to 0, this will store the number of pairs of socks available
        int count = 0;
        //looping through all elements of the hashset i.e. all unique elements of the input array
        foreach (int x in hsh)
        {
            //ar.Count() function with the query(num => num==x) is counting the number of the unique elements one by one
            //the return value of this function is divided by 2 (divided by 2 because pairs means multiple of 2)
            //though both operands are integer, hence C# will discard and fractional value, result will be integer
            //this result will be added to count.
            count += (ar.Count(num => num == x) / 2);
        }
        //after looping through all elements of hashset, we have the total number of pairs of socks.
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
