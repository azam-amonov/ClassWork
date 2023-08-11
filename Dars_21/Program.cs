// See https://aka.ms/new-console-template for more information

using Dars_21.Practic;
using Microsoft.VisualBasic;

#region Practice
// Console.WriteLine("Dars_12 >>> ");
// Practice p = new Practice();
// // p.GetArea(3, 5,  out var area, out var area2);
// // Console.WriteLine(area);
// // Console.WriteLine(area2);
//
// string nums = Console.ReadLine();
// string[] nums2 = nums.Split(' ');
// int[] hah = Array.ConvertAll(nums2, n => int.Parse(n));
//
// p.FindMinMax(out var min, out var max, hah);
// Console.WriteLine(min);
// Console.WriteLine(max);
#endregion

int value;
var nums = new int[3, 3];
var hah = new int[3][];

var guid = Guid.NewGuid();
Console.WriteLine(guid.ToString());
int son = 0;
string name = "";
// Conversion(son, out son);