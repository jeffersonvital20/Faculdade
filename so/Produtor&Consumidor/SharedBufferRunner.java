import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors; 

public class SharedBufferRunner {
	public static void main( String[] args ) {
		ExecutorService application = Executors.newFixedThreadPool(2);
		//Buffer localCompartilhado = new BufferSincronizado(); CASO QUEIRA O EXEMPLO DE BUFFER SINCRONIZADO UTILIZAR ESSE.
		Buffer localCompartilhado = new UnsynchronizedBuffer(); //CASO QUEIRA O EXEMPLO DE BUFFER DESINCRONIZADO UTILIZAR ESSE.
		
		System.out.println("Action\t\tValue\t\tProduced\tConsumed");
		System.out.println("-------\t\t-----\t\t-------\t\t-------\n");
		
		try {
			application.execute(new Producer(localCompartilhado));
			application.execute(new Consumer(localCompartilhado));
		}
		catch (Exception exception) {
			exception.printStackTrace();
			application.shutdown();// termina aplicativo quando as threads terminam.
		}
	}
}
