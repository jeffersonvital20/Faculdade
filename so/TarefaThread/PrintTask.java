import java.util.Random;

public class PrintTask implements Runnable{
	private int sleepTime; // tempo de adormecimento aleat�rio para a // tempo de adormecimento aleat�rio para a tempo de adormecimento aleat�rio para a thread
	private String threadName; // nome da // nome da thread
	private static Random generator = new Random();

	// atribui nome � thread // atribui nome � thread atribui nome � thread
	public PrintTask(String name) {
		this.threadName = name; // configura nome d // configura nome d configura nome da thread a thread a thread
	// seleciona tempo de adormecimento aleat�rio // seleciona tempo de adormecimento aleat�rio entre 0 entre 0 e 5 segundos e 5 segundos e 5 segundos
		sleepTime = generator.nextInt(5000);
	} // fim do construtor PrintTask.

	public void run() {
		try {
			System.out.printf("%s Ir� dormir por %d milisegundos.\n", threadName, sleepTime);
			Thread.sleep(sleepTime);//Coloca a thread para dormir.
		}
		catch (InterruptedException exception) {
			exception.printStackTrace();
		}
		System.out.printf( "%s Terminou de dormir \n", threadName);
	}
}
