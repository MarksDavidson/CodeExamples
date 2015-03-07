import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.*;


public class day7ex1 
{
	public static void main(String[] args)
	{
	try {
//		Class.forName("com.mysql.jdbc.Driver");
//		Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/TravelExperts", "root", "");
//		Statement stmt = conn.createStatement();
//		
		String sql = "select *from agents";
//		
//		ResultSet rs = stmt.executeQuery(sql);
//		ResultSetMetaData rsmd = rs.getMetaData();
//		int numCols = rsmd.getColumnCount();
		
		ResultSet rs = MySQLDB.GetConnect(sql);
		ResultSetMetaData rsmd =  rs.getMetaData();
		int numCols = rsmd.getColumnCount();
		
		while(rs.next())
			{
				for (int i = 1; i<=numCols; i++)
					{
						System.out.print(rs.getString(i));
					}
			}
		}
	
	catch(ClassNotFoundException e)
		{
		e.printStackTrace();
		}
	catch(SQLException e)
		{
		e.printStackTrace();
		}
	}
}

