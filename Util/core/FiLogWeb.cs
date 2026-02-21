using OrakYazilimLib.DbUtil;
using System;
using System.Diagnostics;

namespace OrakUtilDotNetFrm.Util.core
{
	public class FiLogWeb
	{
		public static bool boTestEnabled = false;
		public static bool boDebugDetailEnabled = false;

		public static void logWeb(String message)
		{
			if (boTestEnabled)
			{
				Debug.WriteLine(message);
			}
		}

		public static void logDebug(String message)
		{
			Debug.WriteLine(message);
		}

		public static void logException(Exception ex)
		{
			if (boTestEnabled)
			{
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
			}
		}


		public static string getStackTrace(Exception exception)
		{
			if (boDebugDetailEnabled)
			{
				return exception.StackTrace;
			}
			return null;
		}

		public static string GetDetailSqlLog(FiMsQuery fiMsQuery)
		{
			if (boDebugDetailEnabled)
			{
				string log = "Query:" + fiMsQuery.sql + "\n Params \n" + fiMsQuery.GetSqlBindings();
				return log;
			}

			return null;


		}

		public static string GetMessage(Exception ex)
		{
			return ex.Message;
		}
	}
}