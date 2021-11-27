using System;
using Levin.Rate.Models.Repository;
using Levin.Rate.Models.Valute;

namespace Levin.Rate.Models.Proxy
{
    class Proxy : Subject
    {
        RealSubject realSubject;

        ValutesCurs Valutes= new ValutesCurs();

        private DateTime lastRequest;
        public override ValutesCurs Request()
        {
            DateTime now = DateTime.Now;

            long time = now.Ticks - lastRequest.Ticks;

            bool needRefresh = time > 300000;

            if (realSubject == null || needRefresh)
            {

                Valutes = realSubject.Request();

                ValuteRepository repository = new ValuteRepository();

                repository.Create(Valutes);

                return Valutes;
            }

            return   Valutes;
        }
    }
}
