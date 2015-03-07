
public class Main {
	
	//Mark Davidson
	//Day 4
	//Tester app create and show /w display 

	public static void main(String[] args) {
		
		Customer c1 = new Customer("mark", "davidson", "123456", "123 fake st", "calgary", "ab");
		Agent a1 = new Agent("mark", "davidson", "123456", Double.valueOf("22.00"));
		c1.Display();
		a1.Display();
		
	}

}
