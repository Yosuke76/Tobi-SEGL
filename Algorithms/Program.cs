﻿
/*
int[] cards = [3, 5, 7, 8, 9];
 // int[] cards = {3, 5, 7, 8, 9};
 int[] cards2 = new int[50_000_000];
 // 50_000_000
 // 25_000_000
 // 12_500_000
 // 6_250_000
for (int i = 0; i < cards2.Length; i++)
 {
    cards2[i] = i + 1;
 }
 int query = 7;

 var result = Algorithms.FindCardLocationBinarySearch(cards, query);
 Console.WriteLine("Index von gesuchtem Element: " +result);
 //Console.WriteLine(cards2[10]);
 var result2 = Algorithms.FindCardLocationBinarySearch(cards: cards2, query: 40_942_069);
 Console.WriteLine(result2);//4_942_070
*/
//using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

 var summary = BenchmarkRunner.Run<Algorithms>();

