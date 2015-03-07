
public class Agent extends Person{
	
	//Mark Davidson
	//Day 4
	//agent with extends person. 
	
	private String phonenum;
	private Double commision;
	
	
	
	
	public String getPhonenum() {
		return phonenum;
	}
	public void setPhonenum(String phonenum) {
		this.phonenum = phonenum;
	}
	public Double getCommision() {
		return commision;
	}
	public void setCommision(Double commision) {
		this.commision = commision;
	}
	
	public Agent(String fname, String lname, String pnum, Double com)
	{	
		super(fname, lname);
		this.commision = com;
		this.phonenum = pnum;
	}
	
	public void Display()
	{
		System.out.println(this.getFirstname() + " " + this.getLastname() + " " +  this.phonenum
				+ " " + this.commision);	
				
	}
	
}
