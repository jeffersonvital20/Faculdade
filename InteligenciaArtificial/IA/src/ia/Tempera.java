package ia;

public class Tempera {
	public static Rainhas tempera(Rainhas inicial, double limite, double taxa) {
		Rainhas atual = inicial;

		double temperatura = limite;

		for (int i = 0; i < limite; i++) {
			int index = (int) (Math.random() * 56);

			Rainhas vizinho = atual.getVizinhos()[index];

			int var = vizinho.getAtaques() - atual.getAtaques();

			if (var < 0 || ((double) (temperatura / (var * limite / 10))) > Math.random()) {
				atual = vizinho;

				if (var < 0)
					i--;
				else
					temperatura *= taxa;
			}

			if (atual.getAtaques() == 0)
				break;
		}

		return atual;
	}

	public static void testePorcentagem() {
		int total = 0;

		for (int i = 0; i < 10000; i++) {
			Rainhas estado = Rainhas.criarEstadoAleatorio();
			estado = tempera(estado, 1300, 0.9);

			if (estado.getAtaques() == 0)
				total++;
		}

		System.out.println(total / 100);
	}

	public static void run() {
		Rainhas estado = Rainhas.criarEstadoAleatorio();

		estado.printTabuleiro();
		System.out.println(estado.getAtaques());
		System.out.println();

		estado = tempera(estado, 1300, 0.9);

		estado.printTabuleiro();
		System.out.println(estado.getAtaques());
	}

	public static void main(String[] args) {
		// testePorcentagem();
		run();
	}
}