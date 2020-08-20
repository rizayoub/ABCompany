using ABCompany.Complaint.Mediators;
using ABCompany.Complaint.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ABCompany.Complaint
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IComplaintMediator, ComplaintMediator>();
            container.RegisterType<IDataModelService, DataModelService>();
            container.RegisterType<Factories.IComplaintFactory, Factories.ComplaintFactory>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}