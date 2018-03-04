package ia;

public class Rainhas {
	private short[] posicoes;

	private Rainhas() {
		posicoes = new short[8];

		for (int i = 0; i < 8; i++) {
			posicoes[i] = 0;
		}
	}

	public int getAtaques() {
		int c = 0;

		for (int i = 0; i < 7; i++) {
			for (int j = i + 1; j < 8; j++) {
				int q = j - i;

				if (posicoes[i] == posicoes[j] - q)
					c++;

				if (posicoes[i] == posicoes[j])
					c++;

				if (posicoes[i] == posicoes[j] + q)
					c++;
			}
		}

		return c;
	}

	public int getValor() {
		return 28 - getAtaques();
	}

	public Rainhas[] getVizinhos() {
		Rainhas[] vizinhos = new Rainhas[56];

		short k = 0;

		for (short i = 0; i < 8; i++) {
			for (short j = 1; j <= 8; j++) {
				if (j != posicoes[i]) {
					Rainhas vizinho = new Rainhas();
					vizinho.posicoes = posicoes.clone();

					vizinho.posicoes[i] = j;

					vizinhos[k] = vizinho;
					k++;
				}
			}
		}

		return vizinhos;
	}

	public void print() {
		for (int i = 0; i < 8; i++) {
			System.out.print(posicoes[i] + (i < 7 ? " " : ""));
		}

		System.out.println();
	}

	public void printTabuleiro() {
		for (int i = 0; i < 8; i++) {
			String s1 = posicoes[0] == (i + 1) ? "X " : "O ";
			String s2 = posicoes[1] == (i + 1) ? "X " : "O ";
			String s3 = posicoes[2] == (i + 1) ? "X " : "O ";
			String s4 = posicoes[3] == (i + 1) ? "X " : "O ";
			String s5 = posicoes[4] == (i + 1) ? "X " : "O ";
			String s6 = posicoes[5] == (i + 1) ? "X " : "O ";
			String s7 = posicoes[6] == (i + 1) ? "X " : "O ";
			String s8 = posicoes[7] == (i + 1) ? "X " : "O";

			System.out.println(s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8);
		}
	}

	public static Rainhas criarEstadoAleatorio() {
		Rainhas estado = new Rainhas();

		for (int i = 0; i < 8; i++) {
			short valor = (short) (Math.random() * 8 + 1);

			estado.posicoes[i] = valor;
		}

		return estado;
	}
}
