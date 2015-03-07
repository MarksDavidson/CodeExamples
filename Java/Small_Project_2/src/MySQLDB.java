import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;


public class MySQLDB {
	
	public static ResultSet GetConnect(String sql) throws ClassNotFoundException, SQLException
	{
		try {
			Class.forName("com.mysql.jdbc.Driver");

		Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/TravelExperts", "root", "");
		Statement stmt = conn.createStatement();
		
		ResultSet rs = stmt.executeQuery(sql);
		
		
		return rs;
		
		} catch (ClassNotFoundException e) 
		{
		throw e;
		}
		catch(SQLException e)
		{
		 throw e;
		}
	}
	
	public static int GetUpdate(String sql) throws ClassNotFoundException, SQLException
	{
		try {
			Class.forName("com.mysql.jdbc.Driver");

		Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/TravelExperts", "root", "");
		Statement stmt = conn.createStatement();
		
		int rs = stmt.executeUpdate(sql);
		
		
		return rs;
		
		} catch (ClassNotFoundException e) 
		{
		throw e;
		}
		catch(SQLException e)
		{
		 throw e;
		}
	}
	
}
