using Levin.Rate.Models.Valute;

namespace Levin.Rate.Models.Proxy
{
    abstract class Subject
    {
        public abstract ValutesCurs Request();
    }
}
