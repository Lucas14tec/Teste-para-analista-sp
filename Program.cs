    
    
internal class Program{
    private static void Main (string[] args){

        Console.WriteLine("Questão da Sequência de Fibonacci:");
        QuestionFibo();

        Console.WriteLine("Questão sobre faturamento mensal:");
        QuestionFaturamento();

        Console.WriteLine("Questão do carro e do caminhão:");
        QuestionTruck();




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
     static void QuestionFaturamento(){
            //Dados da questão em variáveis
            float porcSP = 67836.43f;
            float porcRJ = 36678.66f;
            float porcMG = 29229.88f;
            float porcES = 27165.48f;
            float porcOU = 19849.53f;
            //--------------------------------------//

            //Variáveis para o laço de repetição
            float[] empMensal = {porcSP, porcRJ, porcMG, porcES, porcOU};

            float perc100 = empMensal.Sum();

            float[] emptotal = new float[5];
            //--------------------------------------//
            
            //Laço de repetição para calcular a porcentagem
            for (int cont = 0; cont < empMensal.Length; cont++){
                float porcentagem = (100 * empMensal[cont]) / perc100;
                emptotal[cont] =  porcentagem;
                Console.WriteLine($"A porcentagem do {cont+1}° é: {emptotal[cont]} % ");
            }
            //--------------------------------------//    
    }

    }
            static void QuestionTruck(){
            int car = 110;
            int truck = 80;
            int ribeirao = 100;
            float carPass = ribeirao / car;
            float truckPass = ribeirao - truck;
            float truckPassNoPed = ribeirao / 80;
            float pedTruck = 0.17f;
            float truckTravel = 1.25f;
            float timeTravelWithPed = pedTruck + truckTravel;
            float speedTruck = ribeirao / timeTravelWithPed;

            float calc = (car * ribeirao)/(car + speedTruck);
            Console.WriteLine(calc);
        }
}