package ia;

public class Escalada {
	public static Rainhas escalada(Rainhas inicial) {
		Rainhas atual = inicial;

		boolean mudou = true;

		while (mudou) {
			int old = atual.getValor();
			int n = 0;

			Rainhas[] vizinhos = atual.getVizinhos();

			for (int i = 1; i < vizinhos.length; i++) {
				if (vizinhos[i].getValor() > vizinhos[n].getValor())
					n = i;
			}

			if (vizinhos[n].getValor() > old) {
				atual = vizinhos[n];
				mudou = true;
			} else
				mudou = false;
		}

		return atual;
	}

	public static void forcaBruta() {
		Rainhas estado = Rainhas.criarEstadoAleatorio();

		while (escalada(estado).getValor() != 28) {
			estado = Rainhas.criarEstadoAleatorio();
		}

		estado.printTabuleiro();
		System.out.println(estado.getValor());
		System.out.println();

		estado = escalada(estado);

		estado.printTabuleiro();
		System.out.println(estado.getValor());
	}

	public static void run() {
		Rainhas estado = Rainhas.criarEstadoAleatorio();

		estado.printTabuleiro();
		System.out.println(estado.getValor());
		System.out.println();

		estado = escalada(estado);

		estado.printTabuleiro();
		System.out.println(estado.getValor());
	}

	public static void main(String[] args) {
		// forcaBruta();
		run();
	}
}
