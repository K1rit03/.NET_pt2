    
 using dotNet_estudos.Models;





//EXEMPLO ARRAY
int[] arrayInteiros = new int[3];


arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;


for (int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine($"Posição N{contador} - {arrayInteiros[contador]}");
}
























//EXERCICIO SISTEMA CADASTRO

// string opcao;
// bool exibirMenu = true;







// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente:");
//     Console.WriteLine("2 - Buscar cliente:");
//     Console.WriteLine("3 - Apagar cliente:");
//     Console.WriteLine("4 - Encerrar:");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();  // Pausa para o usuário ver a mensagem
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//             break;  

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//             break; 

//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break; 

//         default:
//             Console.WriteLine("Opção inválida");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//             break;
//     }
// }


















//EXEMPLO DO WHILE


// int soma = 0, numero = 0;


// do{
//     Console.WriteLine("Digite um numero(Digite zero para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// }while(numero != 0);


// Console.WriteLine($"Total da soma dos numeros digitados é {soma}");


















//EXEMPLO WHILE

// int numero = 5;
// int contador = 0;

// while (contador <= 10){
//     Console.WriteLine($"{contador + 1} execução   {numero} x {contador} = {numero * contador}");
//     contador ++;


//     if (contador == 6){
//         break;
//     }
    
// }

















//EXEMPLO FOR


//    int numero = 5;
   
   
//    for(int contador = 0; contador <= 10; contador++){
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//    }
   
   
   
   
   
   
   
   
   
   
   
    
    
    
    
    
    
    
    //EXERCICIO CALCULADORA
    
    
    //  Calculadora calc = new Calculadora();

    // calc.Somar(10,5);
    // calc.Dividir(20,4);
    // calc.Potencia(3,3);
    // calc.Seno(30);
    // calc.Coseno(30);
    // calc.Tangente(30);
    
    // int numero = 10;
    // int numero2 = 20;
    // Console.WriteLine(numero);
    // Console.WriteLine("Incremetnado o 10");
    // numero ++;
    // Console.WriteLine(numero);

    // Console.WriteLine(numero2);
    // Console.WriteLine("Decrementando o 10");
    // numero2 --;
    // Console.WriteLine(numero2);
    // calc.RaizQuadrada(9);











//EXEMPLO IF ELSE


    // bool choveu = false;
    // bool estaTarde = false;

    // if(!choveu && !estaTarde )
    // {
    //     Console.WriteLine("Vou pedalar");
    // }
    // else{
    //     Console.WriteLine("Vou pedalar outro dia");
    // }
    
    
    
    
    
    
    
    
    // bool  presençaMin = false;
    // double media = 7.5;
    
    // if (presençaMin && media >= 7){
    //     Console.WriteLine("Aluno Aprovado");
    // }
    // else{
    //     Console.WriteLine("Aluno reprovado");
    // }
    
    
    
    
    
    
     // bool maiorDeIdade = false;
    // bool permissao = false;

    // if (maiorDeIdade || permissao){
    //     Console.WriteLine("entrada liberada");
        
    // }
    // else{
    //     Console.WriteLine("Entrada não liberada");
    // }
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
    // Console.WriteLine("Digite uma letra");
    // string letra = Console.ReadLine();

    
    // switch (letra){
    //     case "a":
    //     case "e":
    //     case "i":
    //     case "o":
    //     case "u":
    //         Console.WriteLine("vogal");
    //         break;
        
    //     default:
    //         Console.WriteLine("Não é uma vogal");
    //         break;
    // }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // if (letra == "a" ||
    //     letra == "e" ||
    //     letra == "i" ||
    //     letra == "o" ||
    //     letra == "u"){
    //         Console.WriteLine("É uma vogal");
    //     }
    // else
    // {
    //     Console.WriteLine("Não é uma vogal");
    // }
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    // int quantidade = 3;
    // int quantidadeCompra = 0;
    // bool quantidadeCompra > 0 && quantidade >= quantidadeCompra;
    
    
    // Console.WriteLine($"quantidade em estoque: {quantidade}");
    // Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
    // Console.WriteLine($"É possivel realizar a venda? {(possivelVenda)}");


    // if (quantidadeCompra == 0){
    //     Console.WriteLine("Venda invalida");
    // }



    // else if (possivelVenda)
    // {
    //     Console.WriteLine("venda realizada");
    // }else{
    //     Console.WriteLine("Quantidade suficiente");
    // }

    
    
    
    
    
    
    
    
    
    
    
    
    
    // string a = "15-";
    // int b = 0;
    // int.TryParse(a,out b);
    // Console.WriteLine(b);
    // Console.WriteLine("Conversão realizada com sucesso");
   
   
   
   
   
   
   
    // int a = 5;
    // double b = a;
    // Console.WriteLine(b);
    
    
    
    
    
    
    
    
    
    
    
    
    
    // int inteiro = 5;
    // string a = inteiro.ToString();
    
    // Console.WriteLine(a);
    
    
    
    
    
    
    
    
    
    
    // int a = 10;
    // int b = 20;

    // int c = a + b;
    // c += 5;

    // Console.WriteLine(c);









    // // Pessoa pessoa1 = new Pessoa();

    // // pessoa1.Nome = "Thiago";
    // // pessoa1.Idade = 18;
    // // pessoa1.Apresentar();

    // DateTime dataAtual1 = DateTime.Now;

    // Console.WriteLine(dataAtual1);
    