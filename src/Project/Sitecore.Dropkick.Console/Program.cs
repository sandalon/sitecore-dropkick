namespace Sitecore.Dropkick.Console
{
    using global::Dropkick.Feature.VSTSBuildNotification.Services;
    using SimpleInjector;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RestSharp;
    using Nito.AsyncEx;

    class Program
    {
        static readonly Container container;

        static Program()
        {
            container = new Container();

            try
            {
                container.Register<IRestClient>(() => new RestClient());
                container.Register<IVSTSService, VSTSService>(Lifestyle.Transient);
            }
            catch (Exception e) { }
            container.Verify();
        }

        static void Main(string[] args)
        {
            var vstsService = container.GetInstance<IVSTSService>();

            //AsyncContext.Run(() => MainAsync(args));

            
            //_buildManager = new BuildManager(_buildNotification, _buildDeployment);


            //_buildNotification.BeginMonitoring(consumerPortal);
            //_buildNotification.OnBuildComplete += 
        }

        //static async Task MainAsync(string[] args)
        //{
        //    Bootstrapper bs = new Bootstrapper();
        //    var list = await bs.GetList();
        //}
    }
}
