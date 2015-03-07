import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;


public class AgentDB 
{

	//connection string
	
	//getallagents (id's, into array for on change do 
//	public 
	//public ResultSet rs;
	//public static 
	
	
	public static Agent getAgent(String sql)
	{	
		//ResultSet rs;	
		Agent a = new Agent();
		
		try {
			ResultSet rs;
			rs = MySQLDB.GetConnect(sql);
			
			
			if(rs.next()) 
			{
			
			if(rs.getString("AgtMiddleinitial") == null)
			{
			a = new Agent(rs.getInt("AgentId"), rs.getString("AgtFirstName"),
						rs.getString("AgtLastName"), rs.getString("AgtBusPhone"), rs.getString("AgtEmail"),
						rs.getString("AgtPosition"),rs.getInt("AgencyId")); 
			}
			else
			{
			a = new Agent(rs.getInt("AgentId"), rs.getString("AgtFirstName"),rs.getString("AgtMiddleinitial"),
						rs.getString("AgtLastName"), rs.getString("AgtBusPhone"), rs.getString("AgtEmail"),
						rs.getString("AgtPosition"),rs.getInt("AgencyId")); 
			}
			return a;
			}
			
			}
		catch(ClassNotFoundException | SQLException e)
		{
			e.printStackTrace();
		}
		return a;
	}
	
	public static int editAgent(Agent old, Agent now)
	{
		//boolean a = false;
		
		String sql = "update agents set " + 	
 				"AgtFirstName = '" + now.getFirstname() +
				"' , AgtLastName = '" + now.getLastname() + 
				"' , AgtPosition = '" + now.getPosition() +
				"' , AgtBusPhone = '" + now.getPhonenum() +
				"' , AgtMiddleInitial = '" + now.getMiddlein() +
				"' , AgencyId = '" + (Integer.toString(now.getAgencyid())) + 
				"' , AgtEmail = '" + now.getEmail() + 
				
				"' where" +
				" AgtFirstName = '" + old.getFirstname() +
				"' and AgtLastName = '" + old.getLastname() + 
				"' and AgtPosition = '" + old.getPosition() +
				"' and AgencyId = '" + (Integer.toString(old.getAgencyid())) + 
				"' and AgtEmail = '" + old.getEmail() + 
				"' and AgtBusPhone = '" + old.getPhonenum() +"'";
		//System.out.println(sql);
		
		int rs = 0;
		try {
			
			rs = MySQLDB.GetUpdate(sql);
			return rs;
			}
			
			
		catch(ClassNotFoundException | SQLException e)
		{
			e.printStackTrace();
			return rs;
		}
		
		//return rs;
		
	}
//	
//	
//	
//	public void newagent(Agent a)
//	{
//		//new agent? maybe
//	}
	
}

