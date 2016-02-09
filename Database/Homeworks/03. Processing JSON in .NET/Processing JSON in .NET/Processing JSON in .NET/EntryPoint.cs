namespace Processing_JSON_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntryPoint
    {
        private static void Main(string[] args)
        {
            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string rssFeedXml = "youtubeRssFeed.xml";

            // Download content
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(url, rssFeedXml);

            // Parse XML to JSON
            var document = XDocument.Load(rssFeedXml);
            string json = JsonConvert.SerializeXNode(document, Newtonsoft.Json.Formatting.Indented);

            // LINQ to JSON
            var jsonObject = JObject.Parse(json);
            var videosTitles = jsonObject["feed"]["entry"].Select(i => i["title"]);

            foreach (var videoTitle in videosTitles)
            {
                Console.WriteLine("Video title : {0}", videoTitle);
            }

            // Parse videos to POCO
            IEnumerable<Video> videoCollection = GetVideosAsCollection(json);

            // Generate HTML page
            GenerateHtmlResult(videoCollection);
        }

        private static IEnumerable<Video> GetVideosAsCollection(string videosAsJson)
        {
            var jsonObject = JObject.Parse(videosAsJson);

            return jsonObject["feed"]["entry"]
                   .Select(e => JsonConvert.DeserializeObject<Video>(e.ToString()));
        }

        private static void GenerateHtmlResult(IEnumerable<Video> videos)
        {
            var document = new XDocument();
            document.Add(new XDocumentType("html", null, null, null));

            var html = new XElement("html");
            var head = new XElement("head");

            var meta = new XElement("meta");
            meta.SetAttributeValue("charset", "utf-8");

            head.Add(meta);

            var title = new XElement("title");
            title.SetValue("Telerik Academy Videos");

            head.Add(title);
            html.Add(head);

            var body = new XElement("body");
            body.SetAttributeValue("bgcolor", "yellowgreen");

            var h1Title = new XElement("h1");
            h1Title.SetValue("Telerik Academy Videos");
            h1Title.SetAttributeValue("style", "text-align: center");

            body.Add(h1Title);

            foreach (var video in videos)
            {
                var videoDiv = new XElement("div");
                videoDiv.SetAttributeValue("style", "display: inline-block; margin-left: 5%");

                var videoTitle = new XElement("h3");
                videoTitle.SetValue(video.Title);

                var videoLink = new XElement("a");
                videoLink.SetValue("Video");
                videoLink.SetAttributeValue("href", string.Format("https://www.youtube.com/watch?v={0}", video.VideoId));

                videoDiv.Add(videoLink);
                videoDiv.Add(videoTitle);

                var videoIframe = new XElement("iframe");
                videoIframe.SetValue(string.Empty);
                videoIframe.SetAttributeValue("src", string.Format("https://www.youtube.com/embed/{0}", video.VideoId));
                videoIframe.SetAttributeValue("width", 500);
                videoIframe.SetAttributeValue("height", 300);

                videoDiv.Add(videoIframe);
                body.Add(videoDiv);
            }

            html.Add(body);
            document.Add(html);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            var writer = XmlWriter.Create("../../videos.html", settings);

            document.Save(writer);
            writer.Close();
        }
    }
}