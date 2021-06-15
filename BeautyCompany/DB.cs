using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCompany
{
    public static class DB
    {
        public static BeautyCompanyEntities db = new BeautyCompanyEntities();

        internal static List<Service> getServices()
        {
            var ser = db.Service.ToList();
            return ser;
        }

        internal static List<Service> getFilteredServices(string text)
        {
            var ser = db.Service.Where(s=>s.Title.StartsWith(text)).ToList();
            return ser;
        }

        internal static void saveChanges()
        {
            db.SaveChanges();
        }
        internal static void deleteService(Service service)
        {
            db.Service.Remove(service);
            db.SaveChanges();
        }

        internal static void addService(Service service)
        {
            db.Service.Add(service);
            db.SaveChanges();
        }

    }
}
