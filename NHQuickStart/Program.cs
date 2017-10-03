using NHibernate.Cfg;
using NHibernate.Linq;
using NHQuickStart.Models.HumanResources;
using NHQuickStart.Models.Person;
using System;
using System.Linq;

namespace NHQuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sessionFactory = new Configuration().Configure()
                    .BuildSessionFactory();
                using (var session = sessionFactory.OpenSession())
                {
                    session.Query<Person>().OrderBy(p => new[] { p.Lastname, p.Firstname })
                        .Where(p => p.Lastname.StartsWith("C"))
                        .Skip(100).Take(100).ToList()
                        .ForEach(p => Console.WriteLine("Name: {0}, {1}", p.Lastname, p.Firstname));
                    var emps = session.Query<Employee>()
                        .Take(10).ToList();
                    emps.ForEach(e => Console.WriteLine("Employee: {2}\tPerson: {0}, {1}", e.Person.Lastname, e.Person.Firstname, e.Jobtitle));
                    var addresses = session.Query<Address>()
                        .Take(10).ToList();
                    addresses.ForEach(a => Console.WriteLine("{0}\r\n{1}, {2}  {3}", a.Addressline1, a.City, a.Stateprovince.Stateprovincecode, a.Postalcode));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(getInner(ex));
                throw;
            }
        }

        static string getInner(Exception iex)
        {
            var message = "";
            if (iex.InnerException != null)
                message = getInner(iex.InnerException);
            return string.Format("{0}\r\n{1}\r\n{2}\r\n", message, iex.Message, iex.StackTrace);
        }

    }
}
