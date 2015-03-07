import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;


public class AgentMain extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtem;
	private JTextField txtbp;
	private JTextField txtln;
	private JTextField txtmi;
	private JTextField txtfn;
	private JComboBox<Integer> cbID = new JComboBox<Integer>();
	private JComboBox<String> cbpos = new JComboBox<String>();
	private JComboBox<Integer> cbai = new JComboBox<Integer>();
	private Agent a = new Agent();
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AgentMain frame = new AgentMain();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public AgentMain() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		
		cbID.setBounds(238, 14, 82, 20);
		contentPane.add(cbID);
		fillAId();
		
		
		cbID.addActionListener(new ActionListener () {
		    public void actionPerformed(ActionEvent e) {
		    	String s = cbID.getSelectedItem().toString();
		    	cbAction(s);
		    }
		});
			
		
		
		
		JLabel lblAgtId = new JLabel("Agent Id");
		lblAgtId.setBounds(49, 17, 53, 14);
		contentPane.add(lblAgtId);
		
		JLabel lblFirstName = new JLabel("First Name*");
		lblFirstName.setBounds(49, 39, 139, 14);
		contentPane.add(lblFirstName);
		
		JLabel lblLastName = new JLabel("Last Name*");
		lblLastName.setBounds(49, 89, 126, 14);
		contentPane.add(lblLastName);
		
		JLabel lblMiddleInitial = new JLabel("Middle initial");
		lblMiddleInitial.setBounds(49, 64, 88, 14);
		contentPane.add(lblMiddleInitial);
		
		JLabel lblBusinessPhone = new JLabel("Business Phone*");
		lblBusinessPhone.setBounds(49, 114, 139, 14);
		contentPane.add(lblBusinessPhone);
		
		JLabel lblEmail = new JLabel("Email*");
		lblEmail.setBounds(49, 139, 46, 14);
		contentPane.add(lblEmail);
		
		JLabel lblPosition = new JLabel("Position*");
		lblPosition.setBounds(49, 164, 103, 14);
		contentPane.add(lblPosition);
		
		JLabel lblAgencyId = new JLabel("Agency Id*");
		lblAgencyId.setBounds(49, 189, 62, 14);
		contentPane.add(lblAgencyId);
		
		
		
		//JComboBox<String> cbpos = new JComboBox<String>();
		cbpos.setBounds(238, 161, 132, 20);
		contentPane.add(cbpos);
		fillpos();
		
		
	//	JComboBox<String> cbai = new JComboBox<String>();
		cbai.setBounds(238, 186, 82, 20);
		contentPane.add(cbai);
		fillai();
		
		
		txtem = new JTextField();
		txtem.setBounds(238, 136, 132, 20);
		contentPane.add(txtem);
		txtem.setColumns(10);
		
		txtbp = new JTextField();
		txtbp.setBounds(238, 111, 132, 20);
		contentPane.add(txtbp);
		txtbp.setColumns(10);
		
		txtln = new JTextField();
		txtln.setBounds(238, 86, 132, 20);
		contentPane.add(txtln);
		txtln.setColumns(10);
		
		txtmi = new JTextField();
		txtmi.setBounds(238, 61, 132, 20);
		contentPane.add(txtmi);
		txtmi.setColumns(10);
		
		txtfn = new JTextField();
		txtfn.setBounds(238, 36, 132, 20);
		contentPane.add(txtfn);
		txtfn.setColumns(10);
		
		JButton btnEdit = new JButton("Edit");
		btnEdit.setBounds(229, 217, 91, 23);
		contentPane.add(btnEdit);
		btnEdit.addActionListener(new ActionListener () {
		    public void actionPerformed(ActionEvent e) {
		    	String s = cbID.getSelectedItem().toString();
		    	cbEdit(s);
		    }
		});

	}

	protected void cbEdit(String s) {
		int c;
		
		
		Agent b = new Agent( (int) cbID.getSelectedItem() , txtfn.getText(), txtmi.getText(), txtln.getText(), txtbp.getText(),  
					 txtem.getText(), (String)cbpos.getSelectedItem(), (int) cbai.getSelectedItem());
		
				
		c = AgentDB.editAgent(a, b);
		System.out.print(c);
		if(c!=0)
		{
			main(null);
			System.out.println("We did IT!");
		}
	
		
	}

	private void fillai() {
		
		String sql = "select distinct AgencyId  from Agents";

	
		try {
			
			ResultSet rs = MySQLDB.GetConnect(sql);
			
			Agent a = new Agent();
			
			while(rs.next())
				{
					a.setAgencyid(rs.getInt("AgencyId"));
					cbai.addItem(a.getAgencyid());
				}
			
			//System.out.println();
			
				} 
		catch (SQLException e)
		{
			e.printStackTrace();
		}
		catch (ClassNotFoundException b)
		{
			b.printStackTrace();
		}
		
		
	}

	private void fillpos() {
		
		String sql = "select distinct AgtPosition  from Agents";

		
		try {
			ResultSet rs = MySQLDB.GetConnect(sql);
		
			Agent a = new Agent();
			
			while(rs.next())
				{
					a.setPosition(rs.getString("Agtposition"));
					
					//needs unique - pop array
					cbpos.addItem(a.getPosition());
				}
			
			//System.out.println();
			
				} 
		catch (SQLException e)
		{
			e.printStackTrace();
		}
		catch (ClassNotFoundException b)
		{
			b.printStackTrace();
		}
		
		
	}

	private void cbAction(String selectedItem) {
		
		//Agent a = new Agent();
		//String s = .toString();
		String sql = "select * from agents where AgentID =" + selectedItem;
		a = AgentDB.getAgent(sql);
		
		//System.out.print(b);
//		
//		 System.out.print(a.getPhonenum());
//		 System.out.print(a.getLastname());
//		 System.out.print(a.getMiddlein());
//		 System.out.print(a.getFirstname());
//		 System.out.print(a.getEmail());

		 String phone = a.getPhonenum();
		 String fname = a.getFirstname();
		 String lname = a.getLastname();
		 String min = a.getMiddlein();
		 String email = a.getEmail();
	
		 txtbp.setText(phone);
		 txtln.setText(lname);
		 txtmi.setText(min);
		 txtfn.setText(fname);
		 txtem.setText(email);
		 
		 cbpos.setSelectedItem(a.getPosition());
		 cbai.setSelectedItem(a.getAgencyid());
		 
		 
		
	}

	private void fillAId() 
	{	
		
		String sql = "select AgentId  from Agents";

	
		try {
			ResultSet rs = MySQLDB.GetConnect(sql);
			
			Agent a = new Agent();
			
			while(rs.next())
				{
					a.setAgentid(rs.getInt("AgentId"));
					cbID.addItem(a.getAgentid());
				}
			
			//System.out.println();
			
				} 
		catch (SQLException e)
		{
			e.printStackTrace();
		}
		catch (ClassNotFoundException b)
		{
			b.printStackTrace();
		}
		
	}
}
	

