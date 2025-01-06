namespace Application;

public partial class App : System.Windows.Application
{
    [System.STAThread()]
    static void Main()
    {
        var app = new App() { MainWindow = new View.Window() };        
        LoadComponent(app.MainWindow, new System.Uri("/application;component/window.xaml", System.UriKind.Relative));
        app.MainWindow.Show();
        app.Run();
    }
}
