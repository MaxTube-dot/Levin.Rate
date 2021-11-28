using System;
using Levin.Rate.Models.Repository;
using Levin.Rate.Models.Valute;

namespace Levin.Rate.Models.Proxy
{
    public class ProxyWeb : Subject
    {
        RealSubject realSubject = new RealSubject();

        ValCurs Valutes ;

        private DateTime lastRequest;
        public override ValCurs Request()
        {
            DateTime now = DateTime.Now;

            TimeSpan time = now - lastRequest;

            bool needRefresh = time.TotalSeconds > 30;

            if (Valutes == null || needRefresh)
            {

                Valutes = realSubject.Request();

                ValuteRepository repository = new ValuteRepository();

                repository.Create(Valutes);

                lastRequest = DateTime.Now;

                return Valutes;
            }

            return   Valutes;
        }
    }
}
