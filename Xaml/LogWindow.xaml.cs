#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Xaml.Xaml
File: LogWindow.xaml.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Xaml
{
	using System;
	using System.Collections.Generic;

	using Ecng.Serialization;

	using StockSharp.Logging;

	/// <summary>
	/// The window to display logs.
	/// </summary>
	public partial class LogWindow : ILogListener
	{
		/// <summary>
		/// To create a window.
		/// </summary>
		public LogWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Format for conversion time into a string.
		/// </summary>
		public string TimeFormat
		{
			get { return LogCtrl.TimeFormat; }
			set { LogCtrl.TimeFormat = value; }
		}

		/// <summary>
		/// The log entries collection.
		/// </summary>
		public IList<LogMessage> Messages => LogCtrl.Messages;

		void ILogListener.WriteMessages(IEnumerable<LogMessage> messages)
		{
			((ILogListener)LogCtrl).WriteMessages(messages);
		}

		void IPersistable.Load(SettingsStorage storage)
		{
			LogCtrl.Load(storage);
		}

		void IPersistable.Save(SettingsStorage storage)
		{
			LogCtrl.Save(storage);
		}

		void IDisposable.Dispose()
		{
		}
	}
}