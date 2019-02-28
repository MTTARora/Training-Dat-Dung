using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GamesDataAccess;

namespace ProjectWeek.Controllers
{
    public class GamesController : ApiController
    {
        public IEnumerable<GamesDB> GetAllGame()
        {
            using (GamesEntities entities = new GamesEntities())
            {
                return entities.GamesDBs.ToList();
            }
        }

        public GamesDB GetGame(int id)
        {
            using (GamesEntities entities = new GamesEntities())
            {
                return entities.GamesDBs.FirstOrDefault(p => p.Id == id);
            }
        }
    }

}
