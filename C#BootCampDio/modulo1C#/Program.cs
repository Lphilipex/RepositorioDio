// See https://aka.ms/new-console-template for more information


































// int[] arrayInterios = new int[4];//dentro da variavel posso por 3 valores 

// arrayInterios[0] = 72;// colocando valores no array
// arrayInterios[1] = 64;
// arrayInterios[2] = 50;
// arrayInterios[3] = 42;

// int[] arrayInteirosDobrados = new int[arrayInterios.Length * 2];
// Array.Copy(arrayInterios, arrayInteirosDobrados, arrayInterios.Length);//copiando um arai para outro maior

// Array.Resize(ref arrayInterios, arrayInterios.Length * 2 );//aumetar o tamanho do array Array.Resize

// for (int contador = 0; contador < arrayInterios.Length; contador++)//.length a capacidade maxima do array 
// {
//         Console.WriteLine($"posição {contador} - {arrayInterios[contador]}");
        

// }


















//[]arrays estrutura e dados que armazena valores do mesmo tipo, com um tamanho fixo 
//int[] nomeDoArra = new int[4] tamanho do array definido e 4 
//int[] nomeDoArra = new int[]{42, 75, 74 ,61};
//string[] nomes = {"jan, Fev"};



// int[] arrayInterios = new int[3];//dentro da variavel posso por 3 valores 

// arrayInterios[0] = 72;// colocando valores no array
// arrayInterios[1] = 64;
// arrayInterios[2] = 50;

// Array.Resize(ref arrayInterios, arrayInterios.Length * 2 );//aumetar o tamanho do array Array.Resize

// for (int contador = 0; contador < arrayInterios.Length; contador++)//.length a capacidade maxima do array 
// {
//         Console.WriteLine($"posição {contador} - {arrayInterios[contador]}");
// }

// int contadorForeach = 0;// serve para por 
// //FOREACH insdicados apra arrays e listas 
// foreach(int valor in arrayInterios)//FOREACH percorer array sem depender de contador para cda elemento no array de inteiros ele joga o valor para variavel valor
// {
//        Console.WriteLine($"posição {contadorForeach} - {valor}");
//        contadorForeach++;
// }
   
   
   
   


















   
   
        //criação de menu
// string opcao;
// bool exibirMenu = true;// variavel para finalizar loop
// while(exibirMenu)
// {       
//         Console.Clear();//limpa o menu quando executa a opção 
//         Console.WriteLine("digite a sua opção:");
//         Console.WriteLine("1- cadastra cliente:");
//         Console.WriteLine("2- buscar cliente:");
//         Console.WriteLine("3- apagar cliente:");
//         Console.WriteLine("4- Encerrar");
//         opcao = Console.ReadLine();
//         switch(opcao)
//         {
                
//                 case "1":
//                 Console.WriteLine("cadasto de cliente: ");
//                 break;

//                 case "2":
//                 Console.WriteLine("buscar de cliente: ");
//                 break;

//                 case "3":
//                 Console.WriteLine("apagar cliente: ");
//                 break;

//                 case "4":
//                 Console.WriteLine("encerrar "); 
//                 exibirMenu = false;// opção para finalizar so o loop 
//                 //Environment.Exit(0);//comando para finalizar o programa todo 
//                 break;

//                 default:// qundo n for nrnhuma das opçoes ele faz isso 
//                 Console.WriteLine("opção invalida");
//                 break;

//         }
// }

// Console.WriteLine("o programa se encerrou ");
   
   
   
   
        //DO WHILE 
// int soma = 0, numero =0;



// do // sintaxe DO WHILE execuata o código independente da condição
// {
//         Console.WriteLine("digite um numero ou 0 para parar");
//         numero = Convert.ToInt32(Console.ReadLine());

//         soma += numero;//condição para somar os numeros 


// }while(numero != 0);//quando digita 0 faz a soma de todos os numeros 

// Console.Write($"total dos numeros somados é {soma}");
        
        
     
        
        
        //interromper laço 
// int numero = 5;
// int contador = 0;// declara a variavel antes do laço 


// while (contador <= 10)
// {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador} ");
//         contador++;//encrementa a variavel depois do laço
//         if (contador == 6)
//         {
//                 break;// interrompe o laço
//         }
// }       
                

        //while
// int numero = 5;
// int contador = 0;// declara a variavel antes do laço 


// while (contador <= 10)
// {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador} ");
//         contador++;//encrementa a variavel depois do laço
// }


           //FOR C#
// int numero = 2;
// for(int contador = 0; contador <= 10; contador++) // declarar a variavel  com int, condição de parada contador <=10 da variavel, e como a contagem vai ser feita de 1 por 1 incremento contador++ da variavel 
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }// contador com for 
   
      

       // NOT ! INVERSAO DE VALOR BOLEANO SE AS OPÇÕES FOREM FALSE ELE EXECUTA 

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde) // esse e o formato para logica not 
// {
//     Console.WriteLine("vou pedalar ");
// }
// else
// {
//     Console.WriteLine("vou pedalar outo dia ");
// }
   
    
   
        // AND && EXCEÇÃO ONDE TODAS EXCEÇÕES FOREM VERDADEIRAS SE UMA FOR FALSA NEM EXECUTA AS OUTRAS
// bool possuPresencaMinima = true;
// double media = 7.5;

// if (possuPresencaMinima && media >= 7)
// {
//     Console.WriteLine("aprovado!");    
// }
// else 
// {
//     Console.WriteLine("Reprovado!");
// }


 
 
        // PIPE || SO PRECISA QUE UMA EXCEÇÃO SEJA VERDADEIRA PARA SER VERDADEIRO MESMO QUE UMA SEJA FALSA ELE PROCURA TE UMA SER VERDADEIRA 
// bool ehMaiorDeIdade = true ;
// bool possuiAutirização = false;

// if(ehMaiorDeIdade || possuiAutirização ) // se uma for verdadeiro n precisa saber se a outra exceção vai ser 
// {
//     Console.WriteLine("entrada liberada!");
// }  
// else
// {
//     Console.WriteLine("entrada não liberada!");
// }
     
   
   
    
    //switch case
// Console.WriteLine("digite uma letra");
// string letra = Console.ReadLine();

// switch (letra) // usa o switch dentro dos () usa sua variavel que quer que o switch observe  
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal"); // caso seja algumas das letras ele imprimir na tela 
//         break; // parada de execução se tiver algum dos casos 
//     default: // caso n seja nenhum casos anterior  
//         Console.WriteLine("não e vogal");// executa essa exceção 
//         break;
// }


        // 2 metodo

// Console.WriteLine("digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a" || // or || e o pipe tem significado como de ou 
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else
// {
//     Console.WriteLine("nao e vogal ");
// }

                //1 metodo 

// Console.WriteLine("digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else
// {
//     Console.WriteLine("nao e vogal");
// }