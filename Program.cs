

int[] arrayInteiros= new int[4];

arrayInteiros[0]=25;
arrayInteiros[1]=13;
arrayInteiros[2]=7;
arrayInteiros[3]=11;




// List<String> frutas = new List<string>();

// frutas.Add("Maçã");
// frutas.Add("UVA");
// frutas.Add("Pera");
// frutas.Add("Morango");


// Console.WriteLine($"Itens na minha lista {frutas.Count} - capacidade {frutas.Capacity}");

// frutas.Add("Laranja");

// Console.WriteLine($"Itens na minha lista {frutas.Count} - capacidade {frutas.Capacity}");

// frutas.Remove("UVA");



















//  Console.WriteLine("RESULTADO COM FOR");
//  for(int count=0; count<frutas.Count;count++){
//      Console.WriteLine($"Posição {count} é : {frutas[count]}");
//  }

//  Console.WriteLine("RESULTADO COM FOREACH");
//  int i=0;
//  foreach(string item in frutas){
//      Console.WriteLine($"Item na posição {i} é: {item}");
//      i++;
// }














int[] arrayEmDobro = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayEmDobro, arrayInteiros.Length);

//Array.Resize(ref arrayInteiros, arrayInteiros.Length*3);

Console.WriteLine("RESULTADO COM FOR");
for (int i = 0; i < arrayEmDobro.Length; i++) {
    Console.WriteLine($"Array da posição {i} é: {arrayEmDobro[i]}");
}












// Console.WriteLine("RESULTADO COM FOREACH");
// int count=0;
// foreach(int valores in arrayInteiros){
//     Console.WriteLine($"Posição {count} é: {valores}");
//     count++;
// }