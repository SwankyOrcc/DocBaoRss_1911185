using DocBaoRss.IO;
using DocBaoRss.Models;
using DocBaoRss.RssFeed;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocBaoRss
{
	public class NewsFeedManager
	{
		private readonly INewsRepository _newsRespository;
		private List<Publisher> _publishers;
		private readonly RssReader _rssReader;
		public NewsFeedManager(INewsRepository newsRespository,RssReader rssReader)
		{
			_newsRespository = newsRespository;
			_rssReader = rssReader;
		}

		public List<Publisher> GetNewsFeed()
		{
			if(_publishers==null)
			{
				_publishers = _newsRespository.GetNews();
			}

			return _publishers;
		}

		public void SaveChanges()
		{
			_newsRespository.Save(_publishers);
		}

		public void RemovePublisher(string publisherName)
		{
			_publishers.RemoveAll(x => x.Name == publisherName);
			SaveChanges();
		}

		public void RemoveCategory(string publisherName,string CategoryName)
		{
			var publisher = _publishers.Find(x => x.Name == publisherName);
			if (publisher == null) return;
			publisher.RemoveCategory(CategoryName);
			SaveChanges();
		}

		public bool Addcategory(string publisherName,string categoryName,string rssLink, bool updateIfExisted)
		{
			var publisher = _publishers.Find(x => x.Name == publisherName);
			if(publisher==null)
			{
				publisher = new Publisher()
				{
					Name = publisherName
				};
				_publishers.Add(publisher);
			}
			return publisher.AddCategory(categoryName, rssLink, updateIfExisted);
		}

		public List<Article> GetNews(string publisherName,string categoryName)
		{
			var publisher = _publishers.Find(x => x.Name == publisherName);
			if (publisher == null) return new List<Article>();
			var category = publisher.Categories.Find(x => x.Name == categoryName);
			if (category == null) return new List<Article>();
			if(category.Articles.Count==0)
			{
				category.Articles = _rssReader.GetNews(category.RssLink);
			}
			return category.Articles;
		}
	}
}
