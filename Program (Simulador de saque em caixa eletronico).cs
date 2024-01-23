string simNao;
double saque, saldo;

Console.WriteLine("Bem vindo, por favor insira o cartão");
Console.WriteLine("Digite o número da sua conta corrente");
Console.ReadLine();
Console.WriteLine("Digite o número da sua agência");
Console.ReadLine();
Console.WriteLine("Você deseja realizar um saque?");
simNao = Console.ReadLine();
saldo = 800;

if (simNao == "S")
{
    Console.WriteLine("Qual valor você deseja sacar?");
    saque = double.Parse(Console.ReadLine());
    saldo = saldo - saque;
    Console.WriteLine(saldo);
    {
        if (saque > saldo)
        {
            Console.WriteLine("Saldo insuficiente, retire seu cartão");
        }

    }
}