using Levin.Rate.Models.Valute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Levin.Rate.Models.Repository
{
    public class ValuteRepository : IRepository<ValutesCurs>
    {
        List<ValutesCurs> valutesCurs = new List<ValutesCurs>() {
        
            new ValutesCurs(){     
                name="Один",
                Date = DateTime.Now.ToString(),
                Valute = new ValuteCurs[]{ 
                    new ValuteCurs {    
                        CharCode="17", ID="1", Name="RUN", Nominal=1, NumCode=23, Value= "df"             
                    }      
                }
            }, 
            new ValutesCurs(){
                name="Один",
                Date = DateTime.Now.ToString(),
                Valute = new ValuteCurs[]{
                    new ValuteCurs {
                        CharCode="14", ID="41", Name="R3UN", Nominal=12, NumCode=233, Value= "df3"
                    }
                }
            }
        };



        public void Create(ValutesCurs item)
        {
            valutesCurs.Add(item);
        }

        public void Delete(int id)
        {

            valutesCurs.Remove(valutesCurs[id]);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValutesCurs GetValute(int id)
        {
          return  valutesCurs[id];
        }

        public ValutesCurs GetLastValute()
        {
            return valutesCurs.LastOrDefault();
        }

        public IEnumerable<ValutesCurs> GetValuteList()
        {
            return valutesCurs.ToArray();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ValutesCurs item)
        {
            throw new NotImplementedException();
        }
    }

   
}
