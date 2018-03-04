import java.util.concurrent.Executors;

import java.util.concurrent.ExecutorService;
public class RunnableTeste {

	public static void main(String[] args) {
		
		PrintTask task1 = new PrintTask("Thread 1");
		PrintTask task2 = new PrintTask("Thread 2");
		PrintTask task3 = new PrintTask("Thread 3");
		System.out.println("Iniciando as threads!!!");
		
		//Criando ExecutorService para gerenciar threads.
		ExecutorService threadExecutor = Executors.newFixedThreadPool(2);
		
		//Inicia threads e as coloca para executar.
		threadExecutor.execute(task1);
		threadExecutor.execute(task2);
		threadExecutor.execute(task3);
		
		threadExecutor.shutdown();// Encerra a execução das threads.
		
		System.out.println("Threads Iniciadas!");
	}

}
