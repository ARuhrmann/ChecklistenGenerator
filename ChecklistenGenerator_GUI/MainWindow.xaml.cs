using ChecklistenGenerator_MSSQL;
using System.Windows;

namespace ChecklistenGenerator_GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Hole mir alle Warenwirtschaften
            // Fülle DropDown mit Warenwirtschaften
            InitializeComponent();
            DataContext = new DS_Warenwirtschaft();
        }
    }
}