using System;
using System.Collections.Generic;
using System.IO;

class Program{

// lists to store game info
static List<string> names = new List<string>();
static List<int> hours = new List<int>();
static List<int> ratings = new List<int>();
static void Main(){

while(true){

Console.WriteLine("type 1 add game");
Console.WriteLine("type 2 view games");
Console.WriteLine("type 3 save");
Console.WriteLine("type 4 load");
Console.WriteLine("type 5 search");
Console.WriteLine("type 6 exit");

int c = int.Parse(Console.ReadLine());

if(c==1) AddGame();
else if(c==2) ViewGames();
else if(c==3) Save();
else if(c==4) Load();
else if(c==5) Search();
else if(c==6) break;

}
}

// add a new game
static void AddGame(){
Console.WriteLine("name:");
string n = Console.ReadLine();
Console.WriteLine("hours:");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("rating 1-10:");
int r = int.Parse(Console.ReadLine());

names.Add(n);
hours.Add(h);
ratings.Add(r);
}

// show all games
static void ViewGames(){
for(int i=0;i<names.Count;i++){
Console.WriteLine(names[i]+" "+hours[i]+"hrs rating: "+ratings[i]);
}
}
// save to file
static void Save(){

List<string> lines = new List<string>();

for(int i=0;i<names.Count;i++){
lines.Add(names[i]+","+hours[i]+","+ratings[i]);
}
File.WriteAllLines("games.txt",lines);
Console.WriteLine("saved");
}

// load from file
static void Load(){

if(File.Exists("games.txt")){
string[] lines = File.ReadAllLines("games.txt");

names.Clear();
hours.Clear();
ratings.Clear();

for(int i=0;i<lines.Length;i++){
string[] p = lines[i].Split(',');
names.Add(p[0]);
hours.Add(int.Parse(p[1]));
ratings.Add(int.Parse(p[2]));
}
Console.WriteLine("loaded");
}
else{
Console.WriteLine("no file");
}
}
// search for a game
static void Search(){
Console.WriteLine("type a game name that is in the library:");
string s = Console.ReadLine();
for(int i=0;i<names.Count;i++){
if(names[i].ToLower()==s.ToLower()){
Console.WriteLine(names[i]+" "+hours[i]+"hrs rating:"+ratings[i]);
}
}
}
}