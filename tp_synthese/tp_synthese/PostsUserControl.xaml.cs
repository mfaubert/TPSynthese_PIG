using System;
using System.Collections.Generic;
using System.Text;
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
    /// Logique d'interaction pour PostsUserControl.xaml
    /// </summary>
    public partial class PostsUserControl : UserControl
    {
        private Post Post;
        private MainWindow MainWindow;
   
        public PostsUserControl(Post post, MainWindow mainWindow)
        {
            InitializeComponent();

            Post = post;
            MainWindow = mainWindow;

            TextBlockUsername.Text = post.User.ToString();
            ImgUser.Source = new BitmapImage(new Uri(post.User.PrincImage, UriKind.Relative));
            ImagePost.Source = new BitmapImage(new Uri(post.ImageUrl, UriKind.Relative));
            
            PostTitle.Text = post.Title;
            PostDate.Text = post.DateTime.ToString();
            PostDescription.Text = post.Description;

        }

    }
}
