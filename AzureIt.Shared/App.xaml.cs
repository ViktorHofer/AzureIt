using MetroLog;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace AzureIt
{
    public sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _unityContainer = new UnityContainer();

        public App()
        {
            InitializeComponent();
            LogManagerFactory.DefaultConfiguration.AddTarget(LogLevel.Trace, LogLevel.Fatal, new MetroLog.Targets.FileStreamingTarget());
            GlobalCrashHandler.Configure();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            throw new NotImplementedException();
        }

        protected override object Resolve(Type type) => _unityContainer.Resolve(type);
    }
}