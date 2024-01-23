string nome;
double nota1, nota2, nota3, nota4, MF;


Console.WriteLine("qual o seu nome? ");
nome = Console.ReadLine();
Console.WriteLine("Olá " + nome + " seja bem vindo");
Console.WriteLine("Entre com sua nota de nota1: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entre com sua nota de nota2: ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entre com sua nota de nota3: ");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entre com sua nota de nota4: ");
nota4 = Convert.ToDouble(Console.ReadLine());

MF = (nota1 + nota2 + nota3 + nota4) / 4;
if (MF >= 6)
{
    Console.WriteLine("Parabéns, você foi aprovado! Sua média é de: " + MF);

}
else if (MF == 5 || MF == 4)
{
    Console.WriteLine("Infelizmente sua média final não foi suficiente, você está de exame");
    Console.WriteLine("Você precisa atingir uma média final mínima de 6.0");
}

else if (MF <= 3)
{
    Console.WriteLine("Infelizmente sua média final não foi suficiente, você está reprovado");
}