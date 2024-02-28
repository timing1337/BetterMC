using LOC.Website.Web.App_Start;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]

namespace LOC.Website.Web.App_Start {
    using System.Web.Mvc;
    using DependencyResolution;

    public static class StructuremapMvc {
        public static void Start() {
            var container = IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}