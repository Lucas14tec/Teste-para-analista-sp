    
    
internal class Program{
    private static void Main (string[] args){

        Console.WriteLine("Questão da Sequência de Fibonacci:");

        QuestionFibo();


        static void QuestionFibo(){
        //Variáveis para o laço de repetição
                int num1 = 0;
                int num2 = 1;
                int soma = 1;
                int cont = 0;
                //--------------------------------------//

                //Variáveis para o usuário digitar os números de entrada
                Console.WriteLine("Digite quantos números da sequência quer mostrar");
                int indice = int.Parse(Console.ReadLine());
                Console.WriteLine($"Serão {indice} números na sequência! ");

                Console.WriteLine("Digite o número que quer conferir dentro da sequência!");
                int usuNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Esses são os primeiros {indice} números da sequência de Fibonacci");
                //--------------------------------------//

                //Array que armazena os primeiros números da sequência de Fibonacci
                int[] fibosequel = new int [indice];
                //--------------------------------------//

                //Laço de repetição da sequência de Fibonacci
                while ( cont < indice)
                {   
                    
                    Console.WriteLine(num1);
                    fibosequel[cont] = num1;
                    soma = num2 + num1;
                    num1 = num2;
                    num2 = soma;
                    cont++;
                    
                    

                }
                //--------------------------------------//

                //Método de verificação para saber se o número está dentro da sequência de Fibonacci(Array)
                

                for(int j = 0; j <= fibosequel.Length; j++){


                    if(fibosequel.Contains(usuNumber)){
                        Console.WriteLine($"Seu número '{usuNumber}' está na sequência!!!");
                        break;
                    }
                    else{
                        Console.WriteLine($"Infelizmente seu número '{usuNumber}' não está na sequência.");
                        break;
                    }


                }
                //--------------------------------------//   
        }
    }
}