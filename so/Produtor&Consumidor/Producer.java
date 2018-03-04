import java.util.Random;

public class Producer implements Runnable{
	private static Random generator = new Random();
	private Buffer localCompartilhado;
	
	public Producer(Buffer Compartilhado) {
		localCompartilhado = Compartilhado;
	}
	
	public void run() {
		int soma = 0;
		
		for(int i=1; i<=10; i++) {
			try {
				Thread.sleep(generator.nextInt(3000));// Faz a thread dormir de 0 a 3 segs.
				localCompartilhado.set(i);//Configura o valor no buffer.
				soma+=i;//Soma os valores de 1 a 10.
				System.out.printf("\t%2d\n", soma);
			}
			//se a thread adormecida é interrompida, imprime rast imprime rastreamento de pilha.
			
			catch (InterruptedException exception){
				exception.printStackTrace();
			}
		}
		
		System.out.printf("\n%s\n%s\n", "Produtor está produzindo.", "Terminando de produzir.");
	}
}
