using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHQuickStart
{
    public sealed class NHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory sessionFactory;
        static NHibernateHelper()
        {
            sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
        }
        public static ISession GetCurrentSession()
        {
            ISession session = sessionFactory.GetCurrentSession();
            if (session == null)
            {
                session = sessionFactory.OpenSession();
                //ConfigurationManager.AppSettings[CurrentSessionKey] = session.ToString();
            }
            else
            {
                session = sessionFactory.GetCurrentSession();
            }
            return session;
        }
        public static void CloseSession()
        {
            var currentSession = ConfigurationManager.AppSettings[CurrentSessionKey];
            if (currentSession == null)
            {
                // No current session
                return;
            }
            //currentSession.Close();
            //context.Items.Remove(CurrentSessionKey);
        }
        public static void CloseSessionFactory()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
        }
    }
}
