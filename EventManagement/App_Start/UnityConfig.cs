using EventManagement.Areas.Accounting.Interfaces;
using EventManagement.Areas.Accounting.Services;
using EventManagement.Areas.Global.Interfaces;
using EventManagement.Areas.Global.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EventManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //global
            container.RegisterType<ISystemUser, SystemUserService>();
            container.RegisterType<ISettings, SettingsServices>();
            container.RegisterType<IJournal, JournalService>();
            container.RegisterType<IReport, ReportService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}