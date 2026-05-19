namespace SchoolApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Use AppShell as the root so Shell routing and Shell.Current are available.
            return new Window(new AppShell()) { Title = "SchoolApp" };
        }
    }
}
