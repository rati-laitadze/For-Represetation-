using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.DbContexts;
using WandioRestful.Entities;
using WandioRestful.ResourceParameters;

namespace WandioRestful.Services
{
    public class MobileRepository : IMobileRepository
    {
        private readonly AppDbContext appDbContext;

        public MobileRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return appDbContext.Manufacturers.ToList<Manufacturer>();
        }

        public Mobile GetMobile(int mobileId)
        {
            if (mobileId <= 0)
            {
                throw new ArgumentNullException(nameof(mobileId));
            }
            return appDbContext.Mobiles.FirstOrDefault(o => o.Id == mobileId);
        }

        public IEnumerable<Mobile> GetMobiles(MobilesResourceParameters mobilesResourceParameters)
        {
            if (mobilesResourceParameters.Page == 0)
            {
                mobilesResourceParameters.Page = 1;
            }
            if (mobilesResourceParameters == null)
            {
                return GetMobiles(mobilesResourceParameters.Page);
            }
            if (mobilesResourceParameters.ManufacturerId <= 0
                && string.IsNullOrWhiteSpace(mobilesResourceParameters.SearchQuery)
                && mobilesResourceParameters.MinPrice == 0 && mobilesResourceParameters.MaxPrice == 0)
            {
                return GetMobiles(mobilesResourceParameters.Page);
            }

            var collection = appDbContext.Mobiles as IQueryable<Mobile>;

            if (mobilesResourceParameters.ManufacturerId > 0)
            {
                collection = collection.Where(a => a.ManufacturerId == mobilesResourceParameters.ManufacturerId);
            }

            if (!string.IsNullOrWhiteSpace(mobilesResourceParameters.SearchQuery))
            {

                var searchQuery = mobilesResourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.Name.Contains(searchQuery));
            }
            if (mobilesResourceParameters.MinPrice > 0 )
            {
                collection = collection.Where(a => a.Price >= mobilesResourceParameters.MinPrice);
            }
            if (mobilesResourceParameters.MaxPrice > 0)
            {
                collection = collection.Where(a => a.Price <= mobilesResourceParameters.MaxPrice);
            }
        
            collection = collection.Skip((mobilesResourceParameters.Page-1) * 6).Take(6);

            return collection.ToList();
        }

        public IEnumerable<Mobile> GetMobiles(int pageNumber=1)
        {
            var collection = appDbContext.Mobiles as IQueryable<Mobile>;
             collection = collection.Skip((pageNumber - 1) * 6).Take(6);
            return collection;
        }

        public IEnumerable<Mobile> GetMobilesOnManufacturers(MobilesResourceParameters mobilesResourceParameters)
        {
            if (mobilesResourceParameters.ManufacturerId <= 0)
            {
                throw new ArgumentNullException(nameof(mobilesResourceParameters.ManufacturerId));
            }
            var collection = appDbContext.Mobiles as IQueryable<Mobile>;
            collection = collection.Where(o => o.ManufacturerId == mobilesResourceParameters.ManufacturerId);
            collection = collection.Skip((mobilesResourceParameters.Page - 1) * 6).Take(6);
            return collection;
        }
    }
}
