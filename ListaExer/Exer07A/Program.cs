//Passos para resolver o bubble sort
//1- Criar array para receber 100 posições 
//2- Precisamos de um laço de repetição
// O vetor
//3- Preencher cada posições com um valor 
//Aleatorio
//4-Imprimir o vetor com valores aleatórios 

int[] vetor = new int[100];

Random random = new Random();
random.Next(100, 1000);
for (int i = 0; i < 100; i++)
{
    //Random 
    vetor[i] = random.Next(1000);
}

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(vetor[i]);
}