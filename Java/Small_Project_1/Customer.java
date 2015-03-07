
public class Customer extends Person{
	
	//Mark Davidson
	//Day 4
	//Customer 

	private String phonenm;
	private String city;
	private String prov;
	

	public String getPhonenm() {
		return phonenm;
	}
	public void setPhonenm(String phonenum) {
		this.phonenm = phonenum;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getProv() {
		return prov;
	}
	public void setProv(String prov) {
		this.prov = prov;
	}
	
	public Customer(String fname, String lname, String pho, String ad, String ct, String pv)
	{
		super(fname, lname, ad);
		this.phonenm = pho;
		this.city = ct;
		this.prov = pv;
	}
	public Customer(String fname, String lname)
	{
		super(fname, lname);
		phonenm = "TBD";
		city = "TBD";
		prov = "TBD";
	}
	
	public String makePhonebookName(Customer cust)
	{	
		String phrcd = cust.getFirstname() + ", "+ cust.getLastname() +"\t"+ cust.phonenm;
		return phrcd;
	}
	
	
	public void Display()
	{
		System.out.println(this.getFirstname() + " " + this.getLastname() + " " +  this.phonenm
				+ " " + this.city + " " + this.prov);	
	}
	
}
