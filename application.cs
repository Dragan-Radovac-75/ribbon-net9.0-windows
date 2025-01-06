namespace App;

public partial class Application : System.Windows.Application
{
    [System.STAThread()]
    static void Main()
    {
        var application = new Application() { MainWindow = new View.Application() };        
        LoadComponent(application.MainWindow, new System.Uri("/application;component/application.xaml", System.UriKind.Relative));
        application.MainWindow.Show();
        application.Run();
    }
}
