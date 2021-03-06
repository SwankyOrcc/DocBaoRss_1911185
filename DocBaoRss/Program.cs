using DocBaoRss.IO;
using DocBaoRss.RssFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocBaoRss
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
				   | SecurityProtocolType.Tls11
				   | SecurityProtocolType.Tls12;
				   //| SecurityProtocolType.Ssl3;
			
			INewsRepository repository = new NewsRepository();
			NewsParser parser = new NewsParser();
			RssReader reader = new RssReader(parser);
			var manager = new NewsFeedManager(repository,reader);
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(manager));
		}
	}
}
