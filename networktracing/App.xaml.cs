using System;
using System.Runtime;
using System.Windows;

namespace networktracing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ProfileOptimization.SetProfileRoot(Environment.GetEnvironmentVariable("temp"));
            ProfileOptimization.StartProfile("networking.startup.profile");
        }
    }
}