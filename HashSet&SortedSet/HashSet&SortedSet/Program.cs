//HashSet<string> strings = new HashSet<string>();

//strings.Add("TV");
//strings.Add("Laptop");
//strings.Add("Tablet");

//Console.WriteLine(strings.Contains("Laptop"));

//foreach (string item in strings)
//{
//    Console.WriteLine(item);
//}

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}



SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 7, 7, 9};
SortedSet<int> b = new SortedSet<int>() { 0, 2, 4, 6, 14, 89, 65 };

//UNION
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

//INTERSECTION
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

// DIFERENCE

SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);
