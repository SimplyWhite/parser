using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ScheduledParser.DAL
{
    public class NewsItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string OwnerTitle { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; } 
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public virtual ICollection<NewsImage> Images { get; set; }
    }
}