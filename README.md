**README - Explorando Arrays e Listas em C#**

Este repositório contém códigos em C# que exploram o uso de Arrays e Listas. Vamos dar uma breve visão geral dos códigos e dos conceitos abordados.

### 1. Arrays

**Código: [Arrays.cs](Arrays.cs)**

```csharp
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 25;
arrayInteiros[1] = 13;
arrayInteiros[2] = 7;
arrayInteiros[3] = 11;

int[] arrayEmDobro = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayEmDobro, arrayInteiros.Length);

Console.WriteLine("RESULTADO COM FOR");
for (int i = 0; i < arrayEmDobro.Length; i++) {
    Console.WriteLine($"Array da posição {i} é: {arrayEmDobro[i]}");
}
```

**Métodos Utilizados:**
- `Array.Copy`: Copia elementos de um array para outro.
- `Array.Resize`: (Comentado) Redimensiona o array para um novo tamanho.

### 2. Listas

**Código: [Listas.cs](Listas.cs)**

```csharp
List<string> frutas = new List<string>();

frutas.Add("Maçã");
frutas.Add("UVA");
frutas.Add("Pera");
frutas.Add("Morango");

Console.WriteLine($"Itens na minha lista {frutas.Count} - capacidade {frutas.Capacity}");

frutas.Add("Laranja");

Console.WriteLine($"Itens na minha lista {frutas.Count} - capacidade {frutas.Capacity}");

frutas.Remove("UVA");

Console.WriteLine("RESULTADO COM FOR");
for (int count = 0; count < frutas.Count; count++) {
    Console.WriteLine($"Posição {count} é: {frutas[count]}");
}

Console.WriteLine("RESULTADO COM FOREACH");
int i = 0;
foreach (string item in frutas) {
    Console.WriteLine($"Item na posição {i} é: {item}");
    i++;
}
```

**Métodos Utilizados:**
- `List.Add`: Adiciona um item à lista.
- `List.Remove`: Remove o primeiro item encontrado na lista que corresponde ao valor especificado.
- `List.Count`: Retorna o número de elementos na lista.
- `List.Capacity`: Retorna a capacidade atual da lista.

### Como Executar os Códigos

1. Clone este repositório.
2. Abra o código desejado em um ambiente de desenvolvimento C#.
3. Compile e execute o código.

Espero que esses exemplos sirvam como uma introdução prática aos conceitos de Arrays e Listas em C#. Sinta-se à vontade para utilizar conforme sua necessidade!
