using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Random rand = new Random();
		List<int> lago = new List<int>();
		List<Player> jogadores = new List<Player>();

		// Definir qntos de peixes no lago
		Console.Write("Digite o número de peixes no lago (1-50): ");
		int numPeixes = int.Parse(Console.ReadLine());

		// peixes em posições aleatórias
		while (lago.Count < numPeixes)
		{
			int posicao = rand.Next(1, 51);
			if (!lago.Contains(posicao))
				lago.Add(posicao);
		}

		// Definir qntos de jogadores
		Console.Write("Digite o número de jogadores: ");
		int numJogadores = int.Parse(Console.ReadLine());

		for (int i = 0; i < numJogadores; i++)
		{
			Console.Write($"Digite o nome do jogador {i + 1}: ");
			string nome = Console.ReadLine();
			jogadores.Add(new Player(nome));
		}

		// Definir número de tentativas por jogador
		Console.Write("Digite o número de tentativas por jogador: ");
		int tentativas = int.Parse(Console.ReadLine());

		// Rodadas do jogo
		for (int t = 0; t < tentativas; t++)
		{
			foreach (var jogador in jogadores)
			{
				Console.Write($"{jogador.Nome}, escolha uma posição (1-50): ");
				int tentativa = int.Parse(Console.ReadLine());

				if (lago.Contains(tentativa))
				{
					Console.WriteLine("Você pescou um peixe!");
					jogador.PeixesPescados++;
					lago.Remove(tentativa);
				}
				else
				{
					Console.WriteLine("Nenhum peixe nesta posição.");
				}
			}
		}

		// vencedor
		jogadores.Sort((p1, p2) => p2.PeixesPescados.CompareTo(p1.PeixesPescados));
		if (jogadores[0].PeixesPescados > jogadores[1].PeixesPescados)
		{
			Console.WriteLine($"O vencedor é {jogadores[0].Nome} com {jogadores[0].PeixesPescados} peixes!");
		}
		else
		{
			Console.WriteLine("Empate ou vitória do pesqueiro!");
		}
	}
}

class Player
{
	public string Nome { get; }
	public int PeixesPescados { get; set; }

	public Player(string nome)
	{
		Nome = nome;
		PeixesPescados = 0;
	}
}
