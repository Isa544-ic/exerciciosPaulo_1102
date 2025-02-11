////ex1
//static int[] GeraJogo()
//{
//    int[] mega = new int[6];
//    Random r = new Random();
//    for(int pos=0;pos<6;pos++)
//    {
//        int num = r.Next(1,61);
//        if(mega.Contains(num))
//        {
//            pos--;
//        }
//        else
//        {
//            mega[pos] = num;
//        }
//    }
//    return mega;
//}

////entradas
//int qtdjogos;
//int[,] jogos;

//Console.Write("Informe quantos jogos você deseja: ");
//qtdjogos = int.Parse(Console.ReadLine());

////processamento e saida
//Console.WriteLine("O total a ser pago é: R$" + qtdjogos * 5);
//jogos = new int[qtdjogos, 6];
//Console.WriteLine("JOGOS GERADOS:");
//for(int j=0;j<qtdjogos;j++)
//{
//    int[] jogo = GeraJogo();
//    for(int pos=0; pos<6;pos++)
//    {
//        Console.Write(jogo[pos] + "\t");
//        jogos[j,pos] = jogo[pos];
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Sorteio real:");
//int[] megasena = GeraJogo();
//for (int pos = 0; pos < 6; pos++)
//{
//    Console.Write(megasena[pos] + "\t");
//}

//for(int j=0;j<qtdjogos;j++)
//{
//    Console.Write("\nAcertos jogo " + (j + 1) + ": ");
//    int acertos = 0;
//    for(int pos=0; pos<6;pos++)
//    {
//        if (megasena.Contains(jogos[j,pos]))
//        {
//            acertos++;
//        }
//    }
//    Console.Write(acertos);
//}


//ex 2
//string[] nomes = new string[10];
//string buscar;

//for (int n = 0; n < 10; n++)
//{
//    Console.Write("Informe o nome " + (n+1) + ": ");
//    nomes[n] = Console.ReadLine();
//}

//Console.Write("Informe o nome que deseja verificar: ");
//buscar = Console.ReadLine();

//if(nomes.Contains(buscar))
//{
//    Console.WriteLine("Sim, esse foi um nome lido anteriormente!");
//}
//else
//{
//    Console.WriteLine("Não, não foi um nome lido.");
//}

//ex3
double[] precos = new double[30];
Random r = new Random();
for (int dia = 0; dia < 30; dia++)
{
	precos[dia] = Math.Round(r.NextDouble() * 25 + 25, 2);
}

//processamento e saida
double maior = precos[0], menor = precos[0], maiorAlta = 0;
int diaMaiorAlta = 0;
for (int dia = 1; dia < 30; dia++)
{
	if (precos[dia] > maior)
		maior = precos[dia];
	if (precos[dia] < menor)
		menor = precos[dia];
	double variacao = precos[dia] - precos[dia - 1];
	if (variacao > maiorAlta)
	{
		maiorAlta = variacao;
		diaMaiorAlta = dia;
	}
}

Console.WriteLine("Maior preço: " + maior +
	"\nMenor preço: " + menor +
	"\nMaior variação: " + maiorAlta + " no dia " +
	(diaMaiorAlta + 1) +
	"\nRentabilidade: " + (precos[29] - precos[0]));