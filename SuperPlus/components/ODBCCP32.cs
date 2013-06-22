/*
 * 
 * Created on 6/19/2013 at 12:55 AM
 *
 * REVISION HISTORY
 *
 * Author		Date		changes
 * Armadix		6/19/2013 	Initial Revision
 * Using Interopservices link to ODBCCP32.dll windows/system32 API
 * 
 */

using System;
using System.Runtime.InteropServices;

	/// <summary>
	/// Description of ODBCCP32.	
	/// </summary>
	public class ODBCCP32
	{
		public ODBCCP32() //constructor
		{
		}
		
		#region Interop Methods

		/// <summary>
		/// Win32 API Imports
		/// </summary>
		[DllImport( "ODBCCP32.dll")]private static extern bool SQLManageDataSources(IntPtr hwnd);
		[DllImport( "ODBCCP32.dll")]private static extern bool SQLCreateDataSource(IntPtr hwnd, string lpszDS);

		#endregion

		#region Error Code
		public enum SQLError
		{
			ODBC_ERROR_GENERAL_ERR = 1,
			ODBC_ERROR_INVALID_BUFF_LEN,
			ODBC_ERROR_INVALID_HWND,
			ODBC_ERROR_INVALID_STR,
			ODBC_ERROR_INVALID_REQUEST_TYPE,
			ODBC_ERROR_COMPONENT_NOT_FOUND,
			ODBC_ERROR_INVALID_NAME,
			ODBC_ERROR_INVALID_KEYWORD_VALUE,
			ODBC_ERROR_INVALID_DSN,
			ODBC_ERROR_INVALID_INF,
			ODBC_ERROR_REQUEST_FAILED,
			ODBC_ERROR_INVALID_PATH,
			ODBC_ERROR_LOAD_LIB_FAILED,
			ODBC_ERROR_INVALID_PARAM_SEQUENCE,
			ODBC_ERROR_INVALID_LOG_FILE,
			ODBC_ERROR_USER_CANCELED,
			ODBC_ERROR_USAGE_UPDATE_FAILED,
			ODBC_ERROR_CREATE_DSN_FAILED,
			ODBC_ERROR_WRITING_SYSINFO_FAILED,
			ODBC_ERROR_REMOVE_DSN_FAILED,
			ODBC_ERROR_OUT_OF_MEM,      
			ODBC_ERROR_OUTPUT_STRING_TRUNCATED
		}
		#endregion
		
		#region Methods
		public bool ManageDatasources(IntPtr hwnd)
		{
			return SQLManageDataSources(hwnd);
		}
		
		public bool CreateDatasource(IntPtr hwnd, string szDsn)
		{
			return SQLCreateDataSource(hwnd, szDsn);
		}
		#endregion
}
