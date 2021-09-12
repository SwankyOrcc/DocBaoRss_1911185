﻿using DocBaoRss.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DocBaoRss.RssFeed
{
	public class RssReader
	{
		private readonly NewsParser _parser;
		public RssReader(NewsParser parser)
		{
			_parser = parser;
		}

		public List<Article> GetNews(string rssLink)
		{
			var feedData = DownloadFeed(rssLink);
			return _parser.ParseXml(feedData);
		}

		private string DownloadFeed(string rssLink)
		{
			var client = new WebClient()
			{
				Encoding = Encoding.UTF8
			};
			return client.DownloadString(rssLink);
		}
	}
}
