using DocBaoRss.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocBaoRss.IO
{
	public interface INewsRepository
	{
		List<Publisher> GetNews();
		void Save(List<Publisher> publishers);
	}
}
