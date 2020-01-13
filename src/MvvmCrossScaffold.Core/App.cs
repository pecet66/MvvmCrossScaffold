using MvvmCross.ViewModels;
using MvvmCrossScaffold.Core.ViewModels.Main;

namespace MvvmCrossScaffold.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
