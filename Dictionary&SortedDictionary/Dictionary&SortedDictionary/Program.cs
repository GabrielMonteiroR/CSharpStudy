Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "5454456546";
cookies["phone"] = "sobrescreve o valor repetido";

Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key.");
}

Console.WriteLine("Size: " + cookies.Count);

foreach (KeyValuePair<string, string> kvp in cookies)
{
    Console.WriteLine(kvp.Value);
}
