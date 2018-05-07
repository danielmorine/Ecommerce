using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();

        public static List<Departments> GetDepartments() { 

        var dep = db.Departments.ToList();
        dep.Add(new Departments{
                DepartmentsId = 0,
                Name = "[ Selecione um Departamento ] "
            });

            return dep = dep.OrderBy(d => d.Name).ToList();
}

        public static List<City> GetCities()
        {
            var cit = db.Cities.ToList();
            cit.Add(new City {
                CityId = 0,
                Name = "[Selecione uma cidade]"
            });
            return cit = cit.OrderBy(c => c.Name).ToList();
        }
public void Dispose()
        {
            db.Dispose();
        }
    }
}