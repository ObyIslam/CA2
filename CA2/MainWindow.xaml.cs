using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Team> Teams = new List<Team>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Teams = GetData();

            OrderTeamsList();

        }

        public List<Team> GetData()
        {
            List<Team> teams = new List<Team>();
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };

            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);

            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            teams[0].Players.AddRange(new List<Player> { p1, p2, p3 }); // France
            teams[1].Players.AddRange(new List<Player> { p4, p5, p6 }); // Italy
            teams[2].Players.AddRange(new List<Player> { p7, p8, p9 }); //Spain

            return teams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Team teams = lbxTeams.SelectedItem as Team;

            if (lbxTeams.SelectedItems != null)
            {
                lbxPlayers.ItemsSource = teams.Players;
            }
        }

        private void UpdateResult(char letter)
        {
            if (lbxPlayers.SelectedItem != null)
            {
                Player player = (Player)lbxPlayers.SelectedItem;

                if (player.ResultRecord.Length >= 5)
                {
                    player.ResultRecord = player.ResultRecord.Substring(1) + letter;
                    lbxPlayers.Items.Refresh();
                }
            }

            OrderTeamsList();
            lbxTeams.Items.Refresh();
        }


        private void OrderTeamsList() //highest to lowest points
        {
            lbxTeams.ItemsSource = Teams.OrderByDescending(team => team.TeamPoints).ToList();
        }

        private void Win_Click(object sender, RoutedEventArgs e)
        {
            UpdateResult('W');
        }

        private void Loss_Click(object sender, RoutedEventArgs e)
        {
            UpdateResult('L');
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            UpdateResult('D');
        }

        //private void lbxPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    image.Source = new BitmapImage(new Uri("/images/0points.jpg", UriKind.Relative));
        //}




        //public void StarRatings()
        //{
        //    string imagePath = "";
        //    string points0 = @"../../../0points";
        //    string points1to5 = @"../../../1-5points";
        //    string points6to10 = @"../../../6-10points";
        //    string points11to15 = @"../../../11-15points";

        //    Player player = new Player();

        //    if(player.Points == 0)
        //    {
        //        imagePath = @"../../../0points";
        //    }
        //    else if (player.Points >= 1 && player.Points <= 5)
        //    {
        //        imagePath = @"../../../1-5points";
        //    }
        //    else if (player.Points >= 6 && player.Points <= 10)
        //    {
        //        imagePath = @"../../../6-10points";
        //    }
        //    else if (player.Points >= 11 && player.Points <= 15)
        //    {
        //        imagePath = @"../../../11-15points";
        //    }
        //}

    }
}
