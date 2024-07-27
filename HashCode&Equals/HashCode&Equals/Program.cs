//string a = "Name one";
//string b = "Name one";

//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());

using HashCode_Equals.Entities;

Client a = new Client { Name = "Maria", Email = "maria@example.com"};
Client b = new Client { Name = "Alex", Email = "maria@example.com" };

//comparar o hashcode com regra especificada no Entites/Client
Console.WriteLine(a.Equals(b));
//compara a referência do ponteiro de memória do objeto
Console.WriteLine(a == b);

