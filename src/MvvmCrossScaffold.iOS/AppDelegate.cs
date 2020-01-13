using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MvvmCrossScaffold.Core;

namespace MvvmCrossScaffold.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
