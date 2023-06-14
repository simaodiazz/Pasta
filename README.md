# 1a
Consiste em buscar o triplo de um número

# 1b
triplo

# 1c
O retorno da varíavel é a multiplicação de 3 * n

# 1d
A função recebe o número que vai ser triplicado

# 1e
```csharp
public static int triplo(int n)
```

# 1f
```csharp
int t;
t = 3 * n;
return t
```

# 2a
```csharp
public static int func01(int arg01) {
    return arg01 * 2;
}
```

# 2b
```csharp
public static int func02() {
    return 5 * 2;
}
```

# 2c
```csharp
public static void func03(float arg01) {
    Console.WriteLine("Função 3 foi executada com o argumento {0}" , arg01);
}
```

# 2d
```csharp
public static string func04(char arg01){
    return arg01 + "";
}
```

# 2e
```csharp
public static int func05(int arg01, int arg02) {
    return arg01 + arg02;
}
```

# 2f
```csharp
public static string func06(char arg01, int arg02) {
    return (int) arg01 == arg02 ? "É igual de acordo com a tabela ASCII" : "É diferente de acordo com a tabela ASCII";
}
```

# 3
```csharp
public static void Main(string[] args)
{
    Console.WriteLine(bom_dia());
}
    
public static void bom_dia() {
    return "Hello :)";
}
```

# 4
```csharp
public static void Main(string[] args)
{
    Console.Write("Digite que horas são: ");
    int hour = int.Parse(Console.ReadLine());

    if (hour > 5 && hour < 12) 
    {
        Console.WriteLine(bom_dia());
    } 
    else if (hour > 11 && hour < 20) 
    {
        Console.WriteLine(boa_tarde());
    } 
    else if ((hour >= 20 && hour <= 24) || (hour > 0 && hour <= 5)) 
    {
        Console.WriteLine(boa_noite());
    } 
    else 
    {
        Console.WriteLine("Indique um valor entre 0 e 24.");
    }
}

public static string bom_dia() 
{
    return "Bom dia.";
}

public static string boa_tarde() 
{
    return "Boa tarde.";
}

public static string boa_noite() 
{
    return "Boa noite.";
}
```
# 5
```csharp
public static void Main(string[] args)
{
    Console.Write("Digite que horas são: ");
    int hour = int.Parse(Console.ReadLine());
        
    boas_vindas(hour);
}

public static void boas_vindas(int hour) {
    if (hour > 5 && hour < 12) 
    {
        Console.WriteLine("Bom dia.");
    } 
    else if (hour > 11 && hour < 20) 
    {
        Console.WriteLine("Boa tarde.");
    } 
    else if ((hour >= 20 && hour <= 24) || (hour > 0 && hour <= 5)) 
    {
        Console.WriteLine("Boa noite.");
    } 
    else 
    {
        Console.WriteLine("Indique um valor entre 0 e 24.");
    }
}
```

# 6
```csharp
public static void Main(string[] args)
{
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
        
    Console.WriteLine("O resultado da soma entre {0} e {1} foi: {2}", num1, num2, sum(num1, num2));
}

public static int sum(int num1, int num2) {
    return num1 + num2;
}
```

# 7
```csharp
public static void Main(string[] args) {
    between(1, 10);
}

public static void between(int num1, int num2) {
    for (int i = num1 + 1; i < num2; i++) Console.WriteLine(i);
}
```

# 8
```csharp
public static void Main(string[] args) {
    Console.Write("Para descubrir os numeros entre dois numeros digite um valor máximo: ");
    int number = int.Parse(Console.ReadLine());
    between(1, number);
}

public static void between(int num1, int num2) {
    for (int i = num1 + 1; i < num2; i++) Console.WriteLine(i);
}
```

# 9
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    
    between(num1, num2);
}

public static void between(int num1, int num2) {
    for (int i = num1 + 1; i < num2; i++) Console.WriteLine(i);
}
```

# 10
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    
    average(num1, num2);
}

public static void average(int num1, int num2) {
    return (num1 + num2) / 2;
}
```

# 11
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    
    average(num1, num2);
}

public static float average(int num1, int num2) {
    if (num1 > 20 || num1 < 0 && num2 > 20 || num2 < 0) {
        return -1;
    }
    return (num1 + num2) / 2;
}
```

# 12
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    
    float aver = average(num1, num2);

    Console.Write(aver >= 10 ? "Aluno aprovado" : "Aluno repetente");

    Console.Write(" com média de {0}", aver);
}

public static float average(int num1, int num2) {
    if (num1 > 20 || num1 < 0 && num2 > 20 || num2 < 0) {
        return -1;
    }
    return (num1 + num2) / 2;
}
```

# 13
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    int number = int.Parse(Console.ReadLine());
    
    table(number);
}
    
public static void table(int num1 = 2) {
    for (int i = 1; int < 11; i++) {
        Console.WriteLine("{0}x{1} = {2}", num1, i, num1 * i);
    }
}
```
# 14
```csharp
public static void Main(string[] args) {
    Console.Write("Digite o primeiro número: ");
    var number = int.Parse(Console.ReadLine());
        
    Console.WriteLine(isPrime(number));
}
        
public static bool isPrime(int number) {
    return number % 2 != 0 && number % 3 != 0;
}
```

# 15
```csharp
public static void Main(string[] args) {
    Console.Write("Digite um número: ");
    var number = int.Parse(Console.ReadLine());

    Console.WriteLine("A resolução do problema é {0}", calculate(number));
}

public static float calculate(int number) {
    return (number + 1) / number;
}
```

# 16
```csharp
public static void Main(string[] args) {
    Console.Write("Digite um número: ");
    char character = char.Parse(Console.ReadLine());

    Console.WriteLine("O número ascii é ", ascii(character));
}

public static float ascii(char letter) {
    return (int) letter;
}
```

# 17
```csharp
public static void Main(string[] args) {
    Console.Write("Digite um caracter: ");
    
    Console.WriteLine("A letra em maiscula é {0}", maiuscula(Console.ReadLine()));
}
    
public static char maiuscula(string letter) {
    try {
        char character = char.Parse(letter);    
        return char.ToUpper(character);
    } catch (Exception exception) {
        return '*';
    }
    return '*';
}
```

# 18
```csharp
public static void Main(string[] args) {
    Console.Write("Digite um caracter: ");
    
    Console.WriteLine("A letra em maiscula é {0}", maiuscula(Console.ReadLine()));
}
    
public static char minuscula(string letter) {
    try {
        char character = char.Parse(letter);    
        return char.ToLower(character);
    } catch (Exception exception) {
        return '*';
    }
    return '*';
}
```

# 19
```csharp
public static void Main(string[] args) {
    Console.Write("Digite um caracter: ");
    char character = char.Parse(Console.ReadLine());
    
    validate(character);
}
    
public static void validate(char letter) {
    int value = (int) letter;
    if (value >= 48 && value <= 57) {
        Console.WriteLine("Resposta 1");
    } else if (value >= 97 && value <= 122) {
        Console.WriteLine("Resposta 2");
    } else if (value >= 65 && value <= 90) {
        Console.WriteLine("Resposta 3");
    } else {
        Console.WriteLine("Resposta 4");
    }
}
```

# 20
```csharp
public static void Main(string[] args) {
    Console.Write("Digite a quantidades de * que deseja gerar: ");
    int value = int.Parse(Console.ReadLine());

    generate(value);
}

public static void generate(int lenght) {
    for (int i = 0; i < lenght; i++) {
       Console.Write("*"); 
    }
}
```

# 21
```csharp
public static void Main(string[] args) {
    Console.Write("Digite a quantidades de * que deseja gerar: ");
    int value = int.Parse(Console.ReadLine());

    generate(value);
}

public static void generate(int lenght) {
    for (int i = 0; i < lenght; i++) {
       Console.WriteLine("*"); 
    }
}
```

# 22
```csharp
public static void Main(string[] args) {
    Console.Write('Digite a quantidades de simbolos que deseja gerar: ');
    int value = int.Parse(Console.ReadLine());

    Console.Write('Digite o simbolo que deseja gerar: ');
    char hideChar = char.Parse(Console.ReadLine());

    generate(value, hideChar);
}

public static string generate(int lenght, char hideChar = '*') {
    for (int = 0; i < lenght; i++) {
       Console.Write(hideChar); 
    }
}
```

# 23
```csharp
public static void Main(string[] args)
{
    margem(5);
}
    
public static void margem(int n) {
    Console.Write("*");
    for (int i = 0; i < n; i++) Console.Write(" ");
    Console.Write("*");
}
```

# 24
```csharp
public static void Main(string[] args)
{
    Console.Write("Dimensão: ");
    int value = int.Parse(Console.ReadLine());
        
    dimension(value, value);
}
    
public static void dimension(int x, int y) {
    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}
```

# 25
```csharp
public static void Main(string[] args)
{
    Console.Write("Qual o tamanho de seu triangulo: ");
    int value = int.Parse(Console.ReadLine());

    draw(value);
}
        
public static void draw(int size) {
        
    for (int i = 1; i <= size; i++) {

        for (int j = 1; j <= size - i; j++) {
            Console.Write("*");
        }
                    
        for (int k = 1; k <= (2 * i) - 1; k++) {
            Console.Write("o");
        }
                    
        Console.WriteLine("");
    }
}
```

# 26
```csharp
public static void Main(string[] args) {

    Console.Write("Escreva uma avaliação que deseja classificar: ");
    string input = Console.ReadLine();

    if (Double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
    {
        Console.WriteLine("A avaliação do aluno é {0}", avaluate(value));
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite um número válido.");
    }
}

public static String avaluate(double value) {
    if (value < 0.0 || value > 20.0) {
        return null;
    }

    if (value >= 0.0 && value <= 9.4) {
        return "Insuficiente";
    }

    if (value >= 9.5 && value <= 13.4) {
        return "Suficiente";
    }

    if (value >= 13.5 && value <= 17.4) {
        return "Bom";
    } else {
        return "Muito bom";
    }
}
```

```csharp
public static void Main(String[] args) {

    Console.Write("Digite seu altura: ");
    var input01 = Console.ReadLine();

    Console.Write("Digite seu peso: ");
    var input02 = Console.ReadLine();

    if (Double.TryParse(input01, NumberStyles.Float, CultureInfo.InvariantCulture, out double height) && 
        Double.TryParse(input02, NumberStyles.Float, CultureInfo.InvariantCulture, out double weight)) 
    {
            Console.WriteLine(IMC(height, weight));
    }
}

public static string IMC(double height, double weight) {
    
    double value = weight / (height * height);

    if (value < 16.0) {
        return "Magreza Grave";
    } else if (value >= 16.1 && value <= 17.0) {
        return "Magreza Moderada";
    } else if (value >= 17.1 && value <= 18.5) {
        return "Magreza Leve";
    } else if (value >= 18.6 && value <= 25.0) {
        return "Saudável";
    } else if (value >= 25.1 && value <= 30.0) {
        return "Sobrepeso";
    } else if (value >= 30.1 && value <= 35.0) {
        return "Obesidade (1º Grau)";
    } else if (value >= 35.1 && value <= 40.0) {
        return "Obesidade (2º Grau)";
    } else if (value >= 40.0) {
        return "Obesidade (3º Grau)";
    } else {
        return "Não foi possível identificar.";
    }
}
```

# 28
```csharp
public static void Main(String[] args) {

    Console.Write("Digite uma palavra: ");
    var text = Console.ReadLine();

    Console.Write("A palavra têm um comprimento de {0} caracteres", Lenght(text));
}

public static int Lenght(string text) {
    return text.ToCharArray().Length;
}
```

# 29
```csharp
public static void Main(String[] args) {

    Console.Write("Digite um texto: ");
    var input01 = Console.ReadLine();

    Console.Write("Digite outro texto: ");
    var input02 = Console.ReadLine();

    Console.Write("As duas strings {0}", EqualsIgnoreCase(input01, input02) ? "são iguais" : "não são iguais");
}

public static bool EqualsIgnoreCase(String first, String second) {
    return first.ToLower().Equals(second.ToLower());
}
```

# 30

```csharp
public static void Main(String[] args) {

    Console.Write("Digite um texto: ");
    var input01 = Console.ReadLine();

    Console.Write("Digite outro texto: ");
    var input02 = Console.ReadLine();

    Console.Write("Resultado do texto juntado: {0}", Merge(input01, input02));
}

public static string Merge(String first, String second) {
    return first + second;
}
```

# 31
```csharp
public static void Main(String[] args) {

    Console.Write("Digite um texto: ");
    var input01 = Console.ReadLine();

    Console.Write("A primeira palavra do texto é: {0}", Split(input01));
}

public static string Split(string text) {
    return text.Split(' ')[0];
}
```

# 32
```csharp
public static void Main(String[] args) {

    Console.Write("Digite um texto: ");
    var input01 = Console.ReadLine();

    Console.Write("A última palavra do texto é: {0}", Split(input01));
}

public static string Split(string text) {
    String[] parts = text.Split(' ');
    return parts[parts.Length - 1];
}
```

# 33
```csharp
public static void Main(String[] args) {

    Console.Write("Digite um texto: ");
    var input01 = Console.ReadLine();

    Console.Write("Esta frase têm {0} palavras.", Length(input01));
}

public static int Length(string text) {
    String[] parts = text.Split(' ');
    return parts.Length;
}
```
