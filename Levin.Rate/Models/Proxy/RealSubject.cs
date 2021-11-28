using System.Xml;
using System.Xml.Serialization;
using Levin.Rate.Models.Valute;

namespace Levin.Rate.Models.Proxy
{
    class RealSubject : Subject
    {
        public override ValCurs Request()
        {
            string url = "https://www.cbr-xml-daily.ru/daily_utf8.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(ValCurs));

            ValCurs valutesCurs = new ValCurs();

            using (XmlTextReader reader = new XmlTextReader(url))
            {
                valutesCurs = (ValCurs)serializer.Deserialize(reader);
            }

            return valutesCurs;
        }
    }
}
