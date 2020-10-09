using AboutModule.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace AboutModule
{
    public class MyAboutModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public MyAboutModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("AboutRegion", () => container.Resolve<AboutUserControl>());
        }
    }
}