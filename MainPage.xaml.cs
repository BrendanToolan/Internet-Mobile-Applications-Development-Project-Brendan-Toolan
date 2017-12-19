using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BrendanToolanProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //int variable used to see if it is a O or a X 
        int playerTurn;

        public MainPage()
        {
            this.InitializeComponent();
        }

        //Method that decides what will be entered into the first space called Space1
        private void onClick(object sender, RoutedEventArgs e)
        {

            //if statement used to find out if a O or a X is entered 
            if(playerTurn == 0)
            {
                Space1.Content = "O";
                playerTurn++;
            }
            else if(playerTurn == 1)
            {
                Space1.Content = "X";
                playerTurn--;
            }
            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space1.IsEnabled = false;

            //Checks to see if there a winner in the game 
            result();
        }

        //Method that decides what will be entered into the second space called Space2
        private void onClick1(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space2.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space2.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cant change
            //whats in the square as it disables the button
            Space2.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in third space called Space3
        private void onClick2(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space3.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space3.Content = "X";
                playerTurn--;
            }
            //This piece of code makes sure the user cant change
            //whats in the square as it disables the button
            Space3.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in fourth space called Space4
        private void onClick3(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space4.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space4.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space4.IsEnabled = false;
           
            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in fifth space called Space5
        private void onClick4(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space5.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space5.Content = "X";
                playerTurn--;
            }

            Space5.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in sixth space called Space6
        private void onClick5(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space6.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space6.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space6.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in seventh space called Space7
        private void onClick6(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space7.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space7.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space7.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in eighted space called Space8
        private void onClick7(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space8.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space8.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space8.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Method that decided what will be entered in ninth space called Space9
        private void onClick8(object sender, RoutedEventArgs e)
        {
            //if statement to see if it a X or a O
            if (playerTurn == 0)
            {
                Space9.Content = "O";
                playerTurn++;
            }
            else if (playerTurn == 1)
            {
                Space9.Content = "X";
                playerTurn--;
            }

            //This piece of code makes sure the user cannot change 
            //whats in the spuare as it disables the button
            Space9.IsEnabled = false;

            //checks if theres a winner
            result();
        }

        //Code for the restart button that resets the button and clears all the X's and O's and the result text from the screen 
        private void restart(object sender, RoutedEventArgs e)
        {
            Space1.Content = "";
            Space1.IsEnabled = true;
            Space2.Content = "";
            Space2.IsEnabled = true;
            Space3.Content = "";
            Space3.IsEnabled = true;
            Space4.Content = "";
            Space4.IsEnabled = true;
            Space5.Content = "";
            Space5.IsEnabled = true;
            Space6.Content = "";
            Space6.IsEnabled = true;
            Space7.Content = "";
            Space7.IsEnabled = true;
            Space8.Content = "";
            Space8.IsEnabled = true;
            Space9.Content = "";
            Space9.IsEnabled = true;
            resultText.Text = "";
        }

        void result()
        {
          
            //Checks to see if there is three X's in a row in the grid x
            if(Space1.Content=="X" && Space2.Content =="X" && Space3.Content =="X" 
                || Space1.Content=="X" && Space5.Content =="X" && Space9.Content =="X"
                || Space1.Content=="X" && Space4.Content=="X" && Space7.Content=="X"
                || Space2.Content=="X" && Space5.Content=="X" && Space8.Content=="X"
                || Space3.Content=="X" && Space6.Content=="X" && Space9.Content=="X"
                || Space7.Content=="X" && Space8.Content=="X" && Space9.Content=="X"
                || Space4.Content=="X" && Space5.Content=="X" && Space6.Content=="X"
                || Space3.Content=="X" && Space5.Content=="X" && Space7.Content=="X")
            {
                //displays the text "Player X Wins" wins in the text block in the xaml code
                resultText.Text = "Player X Wins";
                //disables all the button once there is a winner 
                Space1.IsEnabled = false;
                Space2.IsEnabled = false;
                Space3.IsEnabled = false;
                Space4.IsEnabled = false;
                Space5.IsEnabled = false;
                Space6.IsEnabled = false;
                Space7.IsEnabled = false;
                Space8.IsEnabled = false;
                Space9.IsEnabled = false;
            }

            //checks to see if there is three O's in a row in the grid
            if (Space1.Content == "O" && Space2.Content == "O" && Space3.Content == "O"
               || Space1.Content == "O" && Space5.Content == "O" && Space9.Content == "O"
               || Space1.Content == "O" && Space4.Content == "O" && Space7.Content == "O"
               || Space2.Content == "O" && Space5.Content == "O" && Space8.Content == "O"
               || Space3.Content == "O" && Space6.Content == "O" && Space9.Content == "O"
               || Space7.Content == "O" && Space8.Content == "O" && Space9.Content == "O"
               || Space4.Content == "O" && Space5.Content == "O" && Space6.Content == "O"
               || Space3.Content == "O" && Space5.Content == "O" && Space7.Content == "O")
            {
                //displays the text "Player O Wins" in the text block from the xaml
                resultText.Text = "Player O Wins";

                //disables all buttons once theres a winner
                Space1.IsEnabled = false;
                Space2.IsEnabled = false;
                Space3.IsEnabled = false;
                Space4.IsEnabled = false;
                Space5.IsEnabled = false;
                Space6.IsEnabled = false;
                Space7.IsEnabled = false;
                Space8.IsEnabled = false;
                Space9.IsEnabled = false;
            }
        }
    }
}
