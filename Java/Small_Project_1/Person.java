
public abstract class Person {
	
	//Mark Davidson
	//Day 4
	//super for other classes
	
	private String firstname;
	private String lastname;
	private String address; 

	protected Person(String fname, String lname, String add) {
		this.firstname = fname;
		this.lastname = lname;
		this.address = add;
	}
	protected Person(String fname, String lname) {
		this.firstname = fname;
		this.lastname = lname;
	}
	public String getFirstname() {
		return firstname;
	}
	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}
	public String getLastname() {
		return lastname;
	}
	public void setLastname(String lastname) {
		this.lastname = lastname;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	
	public abstract void Display();
	
}
