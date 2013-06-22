/*
* 
* Created on 6/20/2013 at 12:55 AM
*
* REVISION HISTORY
*
* Author		Date		changes
* Armadix		6/20/2013 	Initial Revision
* Used INI Read and Write Files
* Create a New INI file to store or load data
*
*usage pattern
*[Section0]
*Key0=KeyValue
*Key1=KeyValue
*Key2=KeyValue
*...
*[Section1]
*Key0=KeyValue
*Key1=KeyValue
*Key2=KeyValue
*...
*/

//libraries
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class IniFile
	{
		public string path;
        //Dynamic Link Library kernel writing inside ini file
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
        //Dynamic Link Library kernel reading inside ini file
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section,string key,string def,StringBuilder retVal,int size,string filePath);

		public IniFile(string INIPath) //constructor
		{
			path = INIPath;
		}		
		public void IniWriteValue(string Section,string Key,string Value) //Write Key Value
		{
			WritePrivateProfileString(Section,Key,Value,this.path);
		}		
		public string IniReadValue(string Section,string Key) // Read Key Value
		{
			StringBuilder temp = new StringBuilder(255);
			int i = GetPrivateProfileString(Section,Key,"",temp,255,this.path);
			return temp.ToString();

		}
		public string IniDeleteValue(string Section, string Key)// Delete Key Value
		{
			StringBuilder  temp = new StringBuilder(255);
			int i = GetPrivateProfileString(Section, Key,"",temp,255,this.path);
			WritePrivateProfileString(Section,Key,"",this.path);

            return temp.ToString();
		}
		public Boolean IniCheckFileExist(string pathfilename)
		{
            bool found = false;
            String path = ""; //Put your INI Path Here!

            if (File.Exists(path)) //Checking File INI if its Exist
            {
                found = true;
            }
            else // Otherwise
                found = false; //INI is not Found
            return found;
		}
		
	}
