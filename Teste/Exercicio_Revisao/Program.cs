using System.Collections.Generic;

/*• Paraná: 41, 42, 43, 44, 45 e 46
• Rio Grande do Sul: 51, 53, 54 e 55
• Brasília: 61
• Goiás: 62 e 64
• Mato Grosso: 65 e 66
• Mato Grosso do Sul: 67*/


List<int> parana = new List<int> { 41, 42, 43, 44, 45, 46};
List<int> rS = new List<int> {51,53,54,55};
List<int> br = new List<int> {61};
List<int> goias = new List<int> {62,64};
List<int> mt = new List<int>{65,66};
List<int> ms = new List<int>{67};

Console.WriteLine("Digite um DDD: ");
int ddd = Convert.ToInt32(Console.ReadLine());

switch (ddd)
{
    case int n when parana.Contains(n):
    Console.WriteLine($"DDD {n} é do Paraná");
    break;
    case int n when rS.Contains(n):
    Console.WriteLine($"DDD {n} é do Rio Grande do Sul");
    break;
    case int n when br.Contains(n):
    Console.WriteLine($"DDD {n} é de Brasília");
    break;
    case int n when goias.Contains(n):
    Console.WriteLine($"DDD {n} é de Goiás");
    break;
    case int n when mt.Contains(n):
    Console.WriteLine($"DDD {n} é do Mato Grosso");
    break;
    case int n when ms.Contains(n):
    Console.WriteLine($"DDD {n} é do Mato Grosso do Sul");
    break;
    default:
    Console.WriteLine("DDD não encontrado");
    break;
}