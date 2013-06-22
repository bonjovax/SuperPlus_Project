/*
 * 
 * Created on 6/19/2013 at 12:55 AM
 *
 * REVISION HISTORY
 *
 * Author		Date		changes
 * Armadix		6/19/2013 	Initial Revision
 * Used windows32 bit registry datasources
 * 
 */

//libraries
using System;
using Microsoft.Win32;

	/// <summary>
	/// Description of Registry using regedit.exe	
	/// </summary>
	public class Reg
	{
		private const string DNSKEY = "software\\BASEKE\\Datasources\\";
		public Reg() //constructor
		{
		}
		
		public static string ReadDsn()
		{
			string subkey = DNSKEY + "database";
			string dsn = (string)HKLM.ReadOption(subkey, "dsn", "");
			return dsn;
		}
		
		public static void WriteDsn(string dsn)
		{
			string subkey = DNSKEY + "database";				
			HKLM.WriteOption(subkey, "dsn", dsn);
		}
	}



	enum HKEY{ LocalMachine, CurrentUser}
	public class HKCU
	{
			
		public static object ReadOption(string subkey, string key, object defaultValue ) {
			RegistryKey Key = null;

			try
			{
				Key = Registry.CurrentUser.OpenSubKey( subkey );	
				return Key.GetValue( key, defaultValue );
			} catch ( Exception ) {
				return defaultValue;
			}
		}
		
		public static void WriteOption(string subkey, string key, object Value ) {
			RegistryKey Key = null;
			try
			{
				Key = Registry.CurrentUser.CreateSubKey( subkey ) ;
				Key.SetValue( key, Value); //Convert.ToString( Value ) );
			}			
			catch ( Exception )	{
			}
			finally	{
				if ( Key != null )
					Key.Close();
			}
		}
				
		public static string[] ValueNames(string subkey)
		{
			RegistryKey key = null;
			key = Registry.CurrentUser.OpenSubKey( subkey );	
			return key.GetValueNames();
		}
		
		public static int ValueCount(string subkey)
		{
			RegistryKey key = null;
			key = Registry.CurrentUser.OpenSubKey( subkey );	
			return key.ValueCount;	
		}

	}
	
	public class HKLM //Local Machine
	{
		public static object ReadOption(string subkey, string key, object defaultValue ) {
			RegistryKey Key = null;

			try
			{
				Key = Registry.LocalMachine.OpenSubKey( subkey );	
				return Key.GetValue( key, defaultValue );
			} catch ( Exception ) {
				return defaultValue;
			}
		}
		
		public static void WriteOption(string subkey, string key, object Value ) {
			RegistryKey Key = null;
			try
			{
				Key = Registry.LocalMachine.CreateSubKey( subkey ) ;
				Key.SetValue( key, Value); //Convert.ToString( Value ) );
			}			
			catch ( Exception )	{
			}
			finally	{
				if ( Key != null )
					Key.Close();
			}
		}		
				
		public static string[] ValueNames(string subkey)
		{
			RegistryKey key = null;
			key = Registry.LocalMachine.OpenSubKey( subkey );	
			return key.GetValueNames();
		}
		
		public static int ValueCount(string subkey)
		{
			RegistryKey key = null;
			key = Registry.LocalMachine.OpenSubKey( subkey );	
			return key.ValueCount;	
		}
	}
	
	class ODBCDSN //Locate all the Data Source
	{
		private const string ODBC_SOURCES = "Software\\ODBC\\ODBC.INI\\ODBC Data Sources";
		private const string ODBCREG = "Software\\ODBC\\ODBC.INI\\";
		
		public static string OdbcSourceSubkey
		{
			get { return ODBC_SOURCES;}
		}
		
		public static string GetConnectionStringFromDsn(string dsn, HKEY hkey)
		{
			string con;
			string source;
			string server = "localhost";
			string database = "Master";
			string subkey = ODBCREG + "\\" + dsn;
			
			con = 	"server={0};database={1};Trusted_Connection=true";
			if ( hkey == HKEY.CurrentUser)
				source = (string)HKLM.ReadOption(ODBC_SOURCES, dsn, dsn);
			else
				source = (string)HKCU.ReadOption(ODBC_SOURCES, dsn, dsn);
			
			if ( source == "SQL Server" )
			{
				if ( hkey == HKEY.CurrentUser)
				{
					server = (string)HKCU.ReadOption(subkey, "server", server);
					database = (string)HKCU.ReadOption(subkey, "database", database);
				}
				else
				{
					server = (string)HKLM.ReadOption(subkey, "server", server);
					database = (string)HKLM.ReadOption(subkey, "database", database);	
				}
				return string.Format(con, server, database);
			}
			return "dsn=" + dsn;
		}
				
		public static string Server(string dsn, HKEY hkey)
		{
			string source;
			string server = "";
			string subkey = ODBCREG + "\\" + dsn;
			
			if ( hkey == HKEY.CurrentUser)
				source = (string)HKCU.ReadOption(ODBC_SOURCES, dsn, dsn);
			else
				source = (string)HKLM.ReadOption(ODBC_SOURCES, dsn, dsn);
			
			if ( source != "Microsoft Access Driver (*.mdb)" )
			{
				if ( hkey == HKEY.CurrentUser)
					server = (string)HKCU.ReadOption(subkey, "server", server);
				else
					server = (string)HKLM.ReadOption(subkey, "server", server);
			}
			
			return server;
		}
		
		public static string [] DsnList(HKEY hkey) //List all values sources
		{
			string []odbcs;
			if ( hkey == HKEY.CurrentUser )
				odbcs = HKCU.ValueNames(ODBC_SOURCES);
			else
				odbcs = HKLM.ValueNames(ODBC_SOURCES);
			
			return odbcs;
		}
		
		public static string Database(string dsn, HKEY hkey)
		{
			string source;
			string database = "";
			string subkey = ODBCREG + "\\" + dsn;
			
			if ( hkey == HKEY.CurrentUser )
				source = (string)HKCU.ReadOption(ODBC_SOURCES, dsn, dsn);
			else
				source = (string)HKLM.ReadOption(ODBC_SOURCES, dsn, dsn);
			
			if ( source != "Microsoft Access Driver (*.mdb)" )
			{
				if ( hkey == HKEY.CurrentUser)
					database = (string)HKCU.ReadOption(subkey, "database", database);
				else
					database = (string)HKLM.ReadOption(subkey, "database", database);
			}
			else
			{
				if ( hkey == HKEY.CurrentUser)
					database = (string)HKCU.ReadOption(subkey, "DBQ", database);
				else
					database = (string)HKLM.ReadOption(subkey, "DBQ", database);
			}
			
			return database;
		}
		
		public static string provider(string dsn, HKEY hkey) //type of 
		{
			string source;
			if ( hkey == HKEY.CurrentUser)
				source = (string)HKCU.ReadOption(ODBC_SOURCES, dsn, dsn);
			else
				source = (string)HKLM.ReadOption(ODBC_SOURCES, dsn, dsn);
			return source;
		}
	}
