// See https://aka.ms/new-console-template for more information


int[] numArray = {0,1,2,3,4,5,6,7,8,9};
string[] names = { "Tim", "Martin", "Nikki", "Sara"};
bool[] bools = {true,false,true,false,true,false,true,false,true,false};

List<string> cream = new List<string>();
cream.Add("Vanilla");
cream.Add("Chocolate");
cream.Add("Banana");
cream.Add("Strawberry");
cream.Add("Oreo");
Console.WriteLine(cream.Count);
Console.WriteLine(cream[2]);
cream.RemoveAt(2);
Console.WriteLine(cream.Count);

Random rndnames = new Random();
int namesind = rndnames. Next(names.Length);

Dictionary<string,string> profile = new Dictionary<string,string>();
Random rndcream = new Random();
int creamind = rndcream. Next(cream.Count);
profile.Add("Tim", $"Ice Cream: {cream[creamind]}");
rndcream = new Random();
creamind = rndcream. Next(cream.Count);
profile.Add("Martin", $"Ice Cream: {cream[creamind]}");
rndcream = new Random();
creamind = rndcream. Next(cream.Count);
profile.Add("Nikki", $"Ice Cream: {cream[creamind]}");
rndcream = new Random();
creamind = rndcream. Next(cream.Count);
profile.Add("Sara", $"Ice Cream: {cream[creamind]}");


foreach (var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
