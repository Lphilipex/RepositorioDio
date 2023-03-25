using introduçaoATiposInteiros.models;


// string apresentacao = "ola!"; // string = tipo de variavel; apresentacao = o nome da variavel 

// int qunatidade = 10; // declarando uma variavel interira 

// qunatidade = 1; // qunado nao se coloca o tipo so esta alterando o valor de uma variavel exixtente

// double altura = 1.80;  //declarando uma variavel double 


// decimal preco = 1.80M; // declarando uma variavel decimal


// bool condicao = true; // declarando uma variavel boleana 





// Console.WriteLine(apresentacao);
// Console.WriteLine(qunatidade);
// Console.WriteLine(altura.ToString("0.00"));// ToString para usar 2 casa deciimais depois do ponto
// Console.WriteLine(preco);
// Console.WriteLine(condicao);



DateTime dataAtual = DateTime.Now.AddDays(5); // DaeTime.Now para adicionar a datda atual .AddDays(5) para adicionar mais dais dentro dos parenteses no exemplo foi adicionado mais 5 


Console.WriteLine(dataAtual); // imprimir de forma normal 
Console.WriteLine(dataAtual.ToString("dd/mm/yyy hh:mm")); // especificar como sera impresso 

Calculadora calc = new Calculadora();

calc.Somar(5, 6);
calc.Subtrair(1, 6);
calc.Dividir(5, 10);
calc.Multiplicar(50, 90);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);


int numero = 10;
Console.WriteLine(numero);
Console.WriteLine("incrementar 10");
numero = numero + 2; // incrementar mais de 1 numero 
numero++; // incrementar so mais 1 numero 
numero--; //decremtar numero
Console.WriteLine(numero);

calc.RaizQuadrada(50);