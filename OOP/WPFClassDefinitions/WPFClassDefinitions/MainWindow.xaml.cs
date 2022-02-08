using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFClassDefinitions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Course> courseCollection = new ObservableCollection<Course>();
        private ObservableCollection<Results> resultCollection = new ObservableCollection<Results>();
        public MainWindow()
        {
            InitializeComponent();
            Course course = new Course("VK_123", "test", 1);
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        { 
            courseCollection.Add(new Course(tbCourseName.Text.ToString(), tbCourseCode.Text.ToString(), int.Parse(tbSBU.Text)));

            lvCourses.Items.Add(new Course(tbCourseName.Text.ToString(), tbCourseCode.Text.ToString(), int.Parse(tbSBU.Text)));
        }

        private void btnAddResult_Click(object sender, RoutedEventArgs e)
        {
            resultCollection.Add(new Results(tbCourseName2.Text.ToString(), int.Parse(tbCourseResult.Text)));

            lvResults.Items.Add(new Results(tbCourseName2.Text.ToString(), int.Parse(tbCourseResult.Text)));
        }
    }
}
