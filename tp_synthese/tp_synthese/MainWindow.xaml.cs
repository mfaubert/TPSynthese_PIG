using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tp_synthese
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // créer une observable collection
        public ObservableCollection<String> usersList { get; set; }
        public ObservableCollection<String> friendsList { get; set; }
        public string selectedUser;
        public User currentUser;
        public string imageUrl;

        public MainWindow()
        {

            GetUsers();

            InitializeComponent();

            GetCurrentUser();

            userProfilePic.Source = new BitmapImage(new Uri(currentUser.PrincImage, UriKind.Relative));
            userName.Text = currentUser.ToString();

            LoggedUserCbox.SelectedIndex = 0;

        }
        public void GetUsers()
        {
            usersList = new ObservableCollection<String>();
            foreach (User user in App.Current.Users.Values)
            {
                usersList.Add(user.ToString());
            }
        }

        public void GetCurrentUser() 
        {
            selectedUser = LoggedUserCbox.Items.CurrentItem.ToString();

            foreach (User user in App.Current.Users.Values)
            {
                if (user.ToString() == selectedUser)
                {
                    currentUser = user;
                }
            }
        }

        private void LoggedUserCbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Selectionner un nouvel objet
            var text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;

        }


        public void GetFriends()
        {
            friendsList = new ObservableCollection<String>();

            foreach (Friend friend in currentUser.Friends)
            {
                friendsList.Add(friend.ToString());
            }

        }

        private void MarketClick(object sender, RoutedEventArgs e)
        {
            AutreWindow window = new AutreWindow();
            window.Show();
        }

    }
}
