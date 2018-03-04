import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import java.util.concurrent.locks.Condition;

public class SynchronizedBuffer implements Buffer {
   // Bloqueio para controlar sincroniza��o com esse buffer
   private Lock accessLock = new ReentrantLock();     

   // condi��es para controlar leitura e grava��o 
   private Condition canWrite = accessLock.newCondition();
   private Condition canRead = accessLock.newCondition();

   private int buffer = -1; // compartilhado pelas threads Produtor e Consumidor
   private boolean occupied = false; // se o buffer estiver ocupado
   
   // coloca o valor int no buffer
   public void set( int value )
   {
      accessLock.lock(); // bloqueia esse objeto

      // envia informa��es de thread e de buffer para a sa�da, ent�o espera
      try
      {
         // enquanto o buffer n�o estiver vazio, coloca thread no estado de espera
         while ( occupied )
         {
            System.out.println( "Producer tries to write." );
            displayState( "Buffer full. Producer waits." );
            canWrite.await(); // espera at� que o buffer esteja vazio
         } // fim do while

         buffer = value; // configura novo valor de buffer

         // indica que a produtora n�o pode armazenar outro valor
         // at� a consumidora recuperar valor atual de buffer
         occupied = true;
        
         displayState( "Producer writes " + buffer );

         // sinaliza a thread que est� esperando para ler a partir do buffer
         canRead.signal();                           
      } // fim do try
      catch ( InterruptedException exception )
      {
         exception.printStackTrace();
      } // fim do catch
      finally
      {
         accessLock.unlock(); // desbloqueia esse objeto
      } // fim de finally
   } // fim do m�todo set
    
   // retorna valor do buffer
   public int get()
   {
      int readValue = 0; // inicializa de valor lido a partir do buffer
      accessLock.lock(); // bloqueia esse objeto

      // envia informa��es de thread e de buffer para a sa�da, ent�o espera
      try
      {
         // enquanto os dados n�o s�o lidos, coloca thread em estado de espera
         while ( !occupied ) 
         {
            System.out.println( "Consumer tries to read." );
            displayState( "Buffer empty. Consumer waits." );
            canRead.await(); // espera at� o buffer tornar-se cheio
         } // fim do while

         // indica que a produtora pode armazenar outro valor
         // porque a consumidora acabou de recuperar o valor do buffer 
         occupied = false;

         readValue = buffer; // recupera o valor do buffer
         displayState( "Consumer reads " + readValue );

         // sinaliza a thread que est� esperando o buffer tornar-se vazio
         canWrite.signal();                             
      } // fim do try
      // se a thread na espera tiver sido interrompida, imprime o rastreamento de pilha
      catch ( InterruptedException exception ) 
      {
         exception.printStackTrace();
      } // fim do catch
      finally
      {
         accessLock.unlock(); // desbloqueia esse objeto
      } // fim de finally

      return readValue;
   } // fim do m�todo get
    
   // exibe a opera��o atual e o estado de buffer
   public void displayState( String operation )
   {
      System.out.printf( "%-40s%d\t\t%b\n\n", operation, buffer, 
         occupied );
   } // fim do m�todo displayState 
} // fim da classe SynchronizedBuffer