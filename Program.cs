//Stefeson
Console.Clear();

Console.WriteLine("Bem vindo ao Hotel Soul Pet");
Thread.Sleep(3000);

Console.Clear();

Console.WriteLine("Por favor preencha a ficha");
Console.WriteLine("");

Console.Write("Especie: ");
string especie = Console.ReadLine();

Console.Write("Raça: ");
string raca = Console.ReadLine();

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
string idade = Console.ReadLine();

Console.Write("Cor: ");
string cor = Console.ReadLine();

Console.Clear();

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                     Hotel SOUL PET                      |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Especie: {especie}          | Raça: {raca}              |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Nome: {nome}                                            |");
Console.WriteLine($"| Idade: {idade}                                          |");
Console.WriteLine($"| Pelugem\\Cor: {cor}                                     |");
Console.WriteLine("+=========================================================+");