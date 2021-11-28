using Levin.Rate.Models.Valute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Levin.Rate.Models.Repository
{
    public class ValuteRepository : IRepository<ValCurs>
    {
        List<ValCurs> valutesCurs = new List<ValCurs>() {
        
            new ValCurs(){     
                name="Один",
                Date = DateTime.Now.ToString(),
                Valute = new ValCursValute[]{ 
                    new ValCursValute {    
                        CharCode="17", ID="1", Name="RUN", Nominal=1, NumCode=23, Value= "df"             
                    }      
                }
            }, 
            new ValCurs(){
                name="Один",
                Date = DateTime.Now.ToString(),
                Valute = new ValCursValute[]{
                    new ValCursValute {
                        CharCode="14", ID="41", Name="R3UN", Nominal=12, NumCode=233, Value= "df3"
                    }
                }
            }
        };



        public void Create(ValCurs item)
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

        public ValCurs GetValute(int id)
        {
          return  valutesCurs[id];
        }

        public ValCurs GetLastValute()
        {
            return valutesCurs.LastOrDefault();
        }

        public IEnumerable<ValCurs> GetValuteList()
        {
            return valutesCurs.ToArray();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ValCurs item)
        {
            throw new NotImplementedException();
        }
    }

   
}
