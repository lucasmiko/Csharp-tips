//ENGLISH - Article: Main Features of the C# Language and Its Use Cases

/*
C# is a modern, object-oriented, and strongly-typed programming language developed by Microsoft as part of the .NET platform. Since its inception, C# has been widely adopted for developing a variety of applications, from desktop to web and mobile. Below, we highlight some of the main features of the language and the scenarios where its use is advantageous.
*/

// 1. Simple and Clear Syntax
/*
C# has a syntax that is easy to read and write, especially for developers familiar with other C-like languages such as C++ and Java. This facilitates the learning curve and code maintenance.
*/

public class SyntaxExample {
    public void ShowMessage() {
        Console.WriteLine("Hello, World!");
    }
}

// 2. Object-Oriented
/*
C# is an object-oriented language, which means it supports concepts such as classes, objects, inheritance, polymorphism, and encapsulation. This allows for the creation of modular and reusable code.
*/

public class Animal {
    public string Name { get; set; }
    public void MakeSound() {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Woof Woof!");
    }
}

// 3. LINQ (Language Integrated Query) Support
/*
LINQ allows querying data collections in a direct and intuitive way, using a syntax similar to SQL. This greatly simplifies data manipulation.
*/

public class LINQExample {
    public void FilterNumbers() {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var num in evenNumbers) {
            Console.WriteLine(num);
        }
    }
}

// 4. .NET Platform
/*
C# is an integral part of the .NET platform, which offers a vast class library (Framework Class Library - FCL) and support for developing web, desktop, mobile, games, and other applications.
*/

public class NETExample {
    public void UseLibrary() {
        var currentDate = DateTime.Now;
        Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));
    }
}

// 5. Type Safety
/*
C# is a strongly-typed language, which means that the type of each variable must be declared and is checked at compile time. This helps avoid many common programming errors.
*/

public class TypeSafetyExample {
    public void DemonstrateTypes() {
        int number = 10;
        string text = "Hello";
        // Compilation error: cannot implicitly convert type 'string' to 'int'
        // number = text;
    }
}

// 6. Asynchronous Programming Support
/*
C# offers robust support for asynchronous programming with the async and await keywords, making it easier to write asynchronous code and improving the performance of applications that perform intensive I/O operations.
*/

public class AsyncExample {
    public async Task DownloadDataAsync() {
        using (HttpClient client = new HttpClient()) {
            string data = await client.GetStringAsync("https://api.example.com/data");
            Console.WriteLine(data);
        }
    }
}

// Advantageous Use Cases
/*
1. Web Development: With ASP.NET, C# is widely used to create robust and scalable web applications.
2. Desktop Development: Windows Forms and WPF allow the creation of rich desktop applications.
3. Mobile Development: With Xamarin, it is possible to develop mobile applications for iOS and Android using C#.
4. Games: Unity, one of the most popular game engines, uses C# as its scripting language.
5. Cloud Services: C# is ideal for developing services and APIs that run in the cloud, especially on Azure.
*/

public class Program {
    public static void Main() {
        // Examples of using the mentioned features
        var syntaxExample = new SyntaxExample();
        syntaxExample.ShowMessage();

        var dog = new Dog { Name = "Rex" };
        dog.MakeSound();
        dog.Bark();

        var linqExample = new LINQExample();
        linqExample.FilterNumbers();

        var netExample = new NETExample();
        netExample.UseLibrary();

        var typeSafetyExample = new TypeSafetyExample();
        typeSafetyExample.DemonstrateTypes();

        var asyncExample = new AsyncExample();
        asyncExample.DownloadDataAsync().Wait();
    }
}

/*------------------------------------------------------------------*/

// PORTUGUES - Artigo: Principais Características da Linguagem C# e Seus Cenários de Uso

/*
C# é uma linguagem de programação moderna, orientada a objetos e fortemente tipada, desenvolvida pela Microsoft como parte da plataforma .NET. Desde sua criação, C# tem sido amplamente adotada para o desenvolvimento de uma variedade de aplicações, desde desktop até web e mobile. Abaixo, destacamos algumas das principais características da linguagem e os cenários onde seu uso é vantajoso.
*/

// 1. Sintaxe Simples e Clara
/*
C# possui uma sintaxe que é fácil de ler e escrever, especialmente para desenvolvedores familiarizados com outras linguagens C-like, como C++ e Java. Isso facilita a curva de aprendizado e a manutenção do código.
*/

public class ExemploSintaxe {
    public void ExibirMensagem() {
        Console.WriteLine("Olá, Mundo!");
    }
}

// 2. Orientação a Objetos
/*
C# é uma linguagem orientada a objetos, o que significa que ela suporta conceitos como classes, objetos, herança, polimorfismo e encapsulamento. Isso permite a criação de código modular e reutilizável.
*/

public class Animal {
    public string Nome { get; set; }
    public void FazerSom() {
        Console.WriteLine("Som de animal");
    }
}

public class Cachorro : Animal {
    public void Latir() {
        Console.WriteLine("Au Au!");
    }
}

// 3. Suporte a LINQ (Language Integrated Query)
/*
LINQ permite consultas a coleções de dados de forma direta e intuitiva, utilizando uma sintaxe semelhante a SQL. Isso simplifica muito a manipulação de dados.
*/

public class ExemploLINQ {
    public void FiltrarNumeros() {
        int[] numeros = { 1, 2, 3, 4, 5, 6 };
        var numerosPares = numeros.Where(n => n % 2 == 0);
        foreach (var num in numerosPares) {
            Console.WriteLine(num);
        }
    }
}

// 4. Plataforma .NET
/*
C# é parte integrante da plataforma .NET, que oferece uma vasta biblioteca de classes (Framework Class Library - FCL) e suporte para desenvolvimento de aplicações web, desktop, mobile, jogos, entre outros.
*/

public class ExemploNET {
    public void UsarBiblioteca() {
        var dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
    }
}

// 5. Segurança de Tipos
/*
C# é uma linguagem fortemente tipada, o que significa que o tipo de cada variável deve ser declarado e é verificado em tempo de compilação. Isso ajuda a evitar muitos erros comuns de programação.
*/

public class ExemploSegurancaTipos {
    public void DemonstrarTipos() {
        int numero = 10;
        string texto = "Olá";
        // Erro de compilação: não é possível converter implicitamente 'string' para 'int'
        // numero = texto;
    }
}

// 6. Suporte a Programação Assíncrona
/*
C# oferece suporte robusto para programação assíncrona com as palavras-chave async e await, facilitando a escrita de código assíncrono e melhorando a performance de aplicações que realizam operações I/O intensivas.
*/

public class ExemploAssincrono {
    public async Task BaixarDadosAsync() {
        using (HttpClient client = new HttpClient()) {
            string dados = await client.GetStringAsync("https://api.exemplo.com/dados");
            Console.WriteLine(dados);
        }
    }
}

// Cenários de Uso Vantajosos
/*
1. Desenvolvimento Web: Com ASP.NET, C# é amplamente utilizado para criar aplicações web robustas e escaláveis.
2. Desenvolvimento Desktop: Windows Forms e WPF permitem a criação de aplicações desktop ricas.
3. Desenvolvimento Mobile: Com Xamarin, é possível desenvolver aplicações móveis para iOS e Android usando C#.
4. Jogos: Unity, um dos motores de jogos mais populares, utiliza C# como linguagem de script.
5. Serviços em Nuvem: C# é ideal para desenvolver serviços e APIs que rodam na nuvem, especialmente no Azure.
*/

public class Program {
    public static void Main() {
        // Exemplos de uso das características mencionadas
        var exemploSintaxe = new ExemploSintaxe();
        exemploSintaxe.ExibirMensagem();

        var cachorro = new Cachorro { Nome = "Rex" };
        cachorro.FazerSom();
        cachorro.Latir();

        var exemploLINQ = new ExemploLINQ();
        exemploLINQ.FiltrarNumeros();

        var exemploNET = new ExemploNET();
        exemploNET.UsarBiblioteca();

        var exemploSegurancaTipos = new ExemploSegurancaTipos();
        exemploSegurancaTipos.DemonstrarTipos();

        var exemploAssincrono = new ExemploAssincrono();
        exemploAssincrono.BaixarDadosAsync().Wait();
    }
}
