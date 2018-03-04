
public class UnsynchronizedBuffer implements Buffer{
	private int buffer = -1;
	
	public void set(int value) {
		System.out.printf( "Produtor escreveu \t%2d", value);
		buffer = value;
	}
	
	public int get() {
		System.out.printf( "Consumidor escreveu\t%2d", buffer);
		return buffer;
	}
}
