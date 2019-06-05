/*David Laughton
 * June 6th 2019
 * magic squares
 */

using System;
using System.Collections.Generic;
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

namespace CulminatingProblemJ2MagicSquares
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string rowOn = rowOne.Text;
            string[] splitOne = rowOn.Split(null);
            int[] one;
            int totalOne = 0;
            one = Array.ConvertAll(splitOne, int.Parse);

            string rowTw = rowTwo.Text;
            string[] splitTwo = rowTw.Split(null);
            int[] two;
            int totalTwo = 0;
            two = Array.ConvertAll(splitTwo, int.Parse);

            string rowTh = rowThree.Text;
            string[] splitThree = rowTh.Split(null);
            int[] three;
            int totalThree = 0;
            three = Array.ConvertAll(splitThree, int.Parse);

            string rowFo = rowFour.Text;
            string[] splitFour = rowFo.Split(null);
            int[] four;
            int totalFour = 0;
            four = Array.ConvertAll(splitFour, int.Parse);          
            
            int coloumOne = one[0] + two[0] + three[0] + four[0];
            int coloumTwo = one[1] + two[1] + three[1] + four[1];
            int coloumThree = one[2] + two[2] + three[2] + four[2];
            int coloumFour = one[3] + two[3] + three[3] + four[3];

            for (int i = 0; i < 4; i++) 
            {
                totalOne += one[i];
                totalTwo += two[i];
                totalThree += three[i];
                totalFour += four[i];
            }

            if (totalOne == coloumOne && totalOne == coloumTwo && totalOne == coloumThree && totalOne == coloumFour && 
                totalOne == totalTwo && totalOne == totalThree && totalOne == totalFour)
            {
                lblOutput.Content = "magic";
            }

            else
            {
                lblOutput.Content = "not magic";
            }

        }
    }
}
