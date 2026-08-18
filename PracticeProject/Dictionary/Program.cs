using System.Globalization;

Dictionary<int ,string>dict=new Dictionary<int, string>();
dict.Add(101,"Yash");
dict.Add(102,"Aditya");
dict.Add(103,"Satwik");

Console.WriteLine(dict[101]);
dict[103]="Tarun";
Console.WriteLine(dict[103]);

if(dict.ContainsKey(101))Console.WriteLine("101 Exists");
else Console.WriteLine("101 does Not exists here ");

if(dict.ContainsValue("Tarun"))Console.WriteLine("Tarun Exists");
else Console.WriteLine("Tarun doesnot exist here");

foreach (var v in dict)
{
    Console.WriteLine(v.Key+" --> "+v.Value);
}


int[]nums={1,1,3,3,5,6,6,5,2,7,73,88};
Dictionary<int, int> freq = new Dictionary<int, int>();

foreach (int num in nums)
{
    if (freq.ContainsKey(num))
    {
        freq[num]++;
    }
    else freq[num] = 1;
}

foreach (var num in freq)
{
    Console.WriteLine(num.Key+" ---> "+num.Value);
}
