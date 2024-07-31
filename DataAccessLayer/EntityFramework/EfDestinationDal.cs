using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        Context context = new Context();   

        public Destination GetDestinationWithGuides(int id)
        {
            return context.Destinations.Where(x => x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
        }
    }
}
