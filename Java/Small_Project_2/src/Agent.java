
public class Agent{
	
	//Mark Davidson
	//Day 4
	//agent with extends person. 
	
	private String firstname;
	private String lastname;
	private String middlein;
	private String phonenum;
	private String email;
	private String position;
	private int agencyid;
	private int agentid;

	public int getAgentid() {
		return agentid;
	}
	public void setAgentid(int agentid) {
		this.agentid = agentid;
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
	public String getMiddlein() {
		return middlein;
	}
	public void setMiddlein(String middlein) {
		this.middlein = middlein;
	}
	public String getPhonenum() {
		return phonenum;
	}
	public void setPhonenum(String phonenum) {
		this.phonenum = phonenum;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getPosition() {
		return position;
	}
	public void setPosition(String position) {
		this.position = position;
	}
	public int getAgencyid() {
		return agencyid;
	}
	public void setAgencyid(int agencyid) {
		this.agencyid = agencyid;
	}
	
	
	public Agent(int agtid, String fname, String mi, String lname, String pnum, String email, String pos, int aid)
	{	
		this.firstname = fname;
		this.lastname = lname;
		this.middlein = mi;
		this.phonenum = pnum;
		this.email = email;
		this.position = pos;
		this.agencyid = aid;
		this.agentid = agtid;
		
	}
	public Agent(int agtid, String fname, String lname, String pnum, String email, String pos, int aid)
	{	
		this.firstname = fname;
		this.lastname = lname;
		this.phonenum = pnum;
		this.email = email;
		this.position = pos;
		this.agencyid = aid;
		this.agentid = agtid;
	}
	public Agent()
	{	
		this.firstname = "fname";
		this.lastname = "lname";
		this.middlein = "min";
		this.phonenum = "111111111";
		this.email = "email";
		this.position = "pos";
		this.agencyid = 1;
	}
	public void Display()
	{
						
	}
	
}
