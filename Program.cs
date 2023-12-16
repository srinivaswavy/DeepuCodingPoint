

int moneyAtDeepu = 370;
int moneyAtSrini = 558;
int totalMoney = moneyAtDeepu + moneyAtSrini;


Console.WriteLine("Deepu has " + moneyAtDeepu + " rupees.");
Console.WriteLine("Srini has " + moneyAtSrini + " rupees.");
Console.WriteLine("Total money is " + totalMoney + " rupees");

if (moneyAtDeepu > moneyAtSrini)
{
    Console.WriteLine("Deepu smiles...");
    Console.WriteLine("Srini Cries");
}
else
{
    Console.WriteLine("Srini smiles..");
    Console.WriteLine("Deepu cries");
}
