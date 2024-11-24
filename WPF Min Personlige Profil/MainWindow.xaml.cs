using System.Windows;
using System.Windows.Navigation;

namespace WPF_Min_Personlige_Profil
{
    public partial class MainWindow : Window
    {

        // Event handler for Hyperlink click
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri)
            { UseShellExecute = true });
            e.Handled = true;
        }
    }
}
