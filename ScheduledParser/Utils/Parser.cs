using AngleSharp;
using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;

namespace ScheduledParser.Utils
{
    public class Parser
    {
        HtmlParser _parser = new HtmlParser();
        
        const string BigBangTheoryEpisodes = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
        const string BoxFigthsSchedule = "http://vringe.com/schedule/";
        const string VringeNews = "http://vringe.com/news/";

        static IConfiguration config = new Configuration().WithDefaultLoader();

        public IHtmlDocument ParceUrlToHtml(string sourceUrl)
        {
            var result = BrowsingContext.New(config).OpenAsync(sourceUrl).Result;
            var document = _parser.Parse(result.Body.OuterHtml);
            return document;
        }


        /*
            var parser = new HtmlParser();
            //Source to be pared
            //var source = "<h1>Some example source</h1><p>This is a paragraph element";
            
            var source = vringeNews;
            var config = new Configuration().WithDefaultLoader();
            var doc = BrowsingContext.New(config).OpenAsync(source);
            var result = doc.Result;


            //Parse source to document
            var document = parser.Parse(result.Body.OuterHtml);
            //Do something with document like the following

            
            
            
            Console.WriteLine("Serializing the (original) document:");
            //Console.WriteLine(result.DocumentElement.OuterHtml);

            var newItems = document.QuerySelectorAll(".news_list>ul>li");
            foreach (var item in newItems)
            {
                var img = item.Children.FirstOrDefault(it => it.ClassName == "img");
                var info = item.Children.FirstOrDefault(it => it.ClassName == "info");
                if (info != null)
                {
                    var descr = info.Children.FirstOrDefault(ic => ic.ClassName == "descr");
                    var title = info.Children.FirstOrDefault(ic => ic.ClassName == "title");
                    var ttileText =  title.TextContent;
                }
            }


            var ul = document.QuerySelectorAll("div.news_list");


            var p = document.CreateElement("p");
            p.TextContent = "This is another paragraph.";

            Console.WriteLine("Inserting another element in the body ...");
            //document.Body.AppendChild(p);

            Console.WriteLine("Serializing the document again:");
            //Console.WriteLine(document.DocumentElement.OuterHtml);
            Console.ReadLine();
         * 
         * *./
        */
    }
}