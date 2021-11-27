using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Levin.Rate.Models.Valute;

namespace Levin.Rate.Models.Proxy
{
    class RealSubject : Subject
    {
        public override ValutesCurs Request()
        {
            string dataXML = String.Empty;

            using (WebClient client  = new WebClient())
            {
                dataXML =  client.DownloadString(https://www.cbr-xml-daily.ru/daily_utf8.xml);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(ValutesCurs));

            ValutesCurs valutesCurs = new ValutesCurs();

            using (TextReader reader = new StreamReader(dataXML))
            {
                valutesCurs = (ValutesCurs)serializer.Deserialize(reader);
            }

            return valutesCurs;
        }
    }
}
