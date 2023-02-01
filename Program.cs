//--------------------------------------1---------------------------------------

Console.Write("Numbers from range: ");
//Numbers from range
var arr = new int[] { 67, 92, 153, 15 };
var selectRange = (from a in arr
    where a > 30 && a < 100
    select a).ToList();
selectRange.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();
//Console.WriteLine(string.Join(" ",selectRange));

//-------------------------------------2----------------------------------------

Console.Write("Minimum length: ");
//Minimum length
var arr2 = new string[] { "Anushervon", "Sam", "Ardasher","Max","Muhammad" };
var get = (from s in arr2
    where s.Length >= 5
    select s).ToList();
get.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();

//---------------------------------------3--------------------------------------

Console.Write("Select words: ");
//Select words
var arr3 = new string[] { "Anushervonm", "Sam", "Ardasherm","Max","Muhammad" };
var words = (from a in arr3
    where a.ToUpper().StartsWith("A") && a.ToUpper().EndsWith("M")
    select a).ToList();
words.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();


//-----------------------------------4------------------------------------------

Console.Write("Top 5 numbers: ");
//Top 5 numbers
var arr4 = new int[] {78, -9, 0, 23, 54, 21, 7, 86};
var top5 = (from a in arr4
    orderby a descending
    select a).Take(5).ToList();
top5.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();


//------------------------------------5-----------------------------------------

Console.Write("Square greater than 20: ");
//Square greater than 20
var arr5 = new int[] {2,5,9,7,3,12,25,4,48};
var square = (from a in arr5
    where a*a>20
    select a).ToList();
square.ForEach(x=>Console.Write(x+"-"+x*x+" "));
Console.WriteLine();


//-----------------------------------6------------------------------------------

//?????????????????????????????????????????????????????????????????????????????????
//Replace substring
 // var arr6 = new string[] { "learn", "current", "deal" };
 // var replace = (from a in arr6
 //     where a.Contains("ea")==true ? a.Replace("ea", "*")
 //     select a).ToList();
 // words.ForEach(x=>Console.Write(x+"-"));
 // Console.WriteLine();


//---------------------------------7--------------------------------------------

Console.Write("Last word containing letter: ");
//Last word containing letter 
var arr7 = new string[] { "Anushervon", "Sam", "Ardashere","Maxe","Muhammad" };
var ends = (from s in arr7
    orderby s descending 
    
    
    
    
    
    
    where s.Contains("e")
    select s).Take(1).ToList();
ends.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();


//-------------------------------------8----------------------------------------

Console.Write("Shuffle an array: ");
//Shuffle an array
var rnd = new Random();
var arr8 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var shuffle = (from a in arr8
    orderby  Guid.NewGuid()
    select a).ToList();
shuffle.ForEach(x=>Console.Write(x+" "));
Console.WriteLine();

    






