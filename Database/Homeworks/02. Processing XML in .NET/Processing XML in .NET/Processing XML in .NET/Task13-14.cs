namespace Processing_XML_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Xsl;

    public class Task13_14
    {
        public static void TransformFromXmlToHtml()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../Catalogue.xslt");
            xslt.Transform("../../Catalogue.xml", "../../Catalogue.html");
            Console.WriteLine("\tDONE!!! Check file!");
        }
    }
}
