using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartBaseBall
{
    public partial class Form1 : Form
    {

        private int NumberOfBalls = 0;
        private int NumberOfStrikes = 0;
        private int NumberOfOuts = 0;

        private int TeamOneScore = 0;
        private int TeamTwoScore = 0;

        private int InningNumber = 1;

        private int WhoIsBatting = 1;


        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateTotalRuns()
        {
            T1Total.Text = (int.Parse(T1I1.Text) + int.Parse(T1I2.Text) + int.Parse(T1I3.Text) + int.Parse(T1I4.Text) + int.Parse(T1I5.Text) + int.Parse(T1I6.Text) + int.Parse(T1I7.Text) + int.Parse(T1I8.Text) + int.Parse(T1I9.Text)).ToString();
            T2Total.Text = T2I1.Text + T2I2.Text + T2I3.Text + T2I4.Text + T2I5.Text + T2I6.Text + T2I7.Text + T2I8.Text + T2I9.Text;
        }
        private void StrikeButton_Click(object sender, EventArgs e)
        {
            CanYouKeepPlaying(NumberOfOuts);
                if (NumberOfStrikes < 2)
                {
                    NumberOfStrikes++;
                    UpdateScoreBoard();
                }
                else
                {
                    NumberOfStrikes = 0;
                    NumberOfOuts++;
                    ClearStrikesAndBalls();
                    UpdateScoreBoard();
                    
                }
            
        }
        private void AddPoint()
        {
            if (WhoIsBatting == 1)
            {
                switch (InningNumber)
                {
                    case (1):
                        T1I1.Text = (int.Parse(T1I1.Text) + 1).ToString();
                        break;
                    case (2):
                        T1I2.Text = (int.Parse(T1I2.Text) + 1).ToString();
                        break;
                    case (3):
                        T1I3.Text = (int.Parse(T1I3.Text) + 1).ToString();
                        break;
                    case (4):
                        T1I4.Text = (int.Parse(T1I4.Text) + 1).ToString();
                        break;
                    case (5):
                        T1I5.Text = (int.Parse(T1I5.Text) + 1).ToString();
                        break;
                    case (6):
                        T1I6.Text = (int.Parse(T1I6.Text) + 1).ToString();
                        break;
                    case (7):
                        T1I7.Text = (int.Parse(T1I7.Text) + 1).ToString();
                        break;
                    case (8):
                        T1I8.Text = (int.Parse(T1I8.Text) + 1).ToString();
                        break;
                    case (9):
                        T1I9.Text = (int.Parse(T1I9.Text) + 1).ToString();
                        break;
                }
            }
            if (WhoIsBatting == 2)
            {
                switch (InningNumber)
                {
                    case (1):
                        T2I1.Text = (int.Parse(T2I1.Text) + 1).ToString();
                        break;
                    case (2):
                        T2I2.Text = (int.Parse(T2I2.Text) + 1).ToString();
                        break;
                    case (3):
                        T2I3.Text = (int.Parse(T2I3.Text) + 1).ToString();
                        break;
                    case (4):
                        T2I4.Text = (int.Parse(T2I4.Text) + 1).ToString();
                        break;
                    case (5):
                        T2I5.Text = (int.Parse(T2I5.Text) + 1).ToString();
                        break;
                    case (6):
                        T2I6.Text = (int.Parse(T2I6.Text) + 1).ToString();
                        break;
                    case (7):
                        T2I7.Text = (int.Parse(T2I7.Text) + 1).ToString();
                        break;
                    case (8):
                        T2I8.Text = (int.Parse(T2I8.Text) + 1).ToString();
                        break;
                    case (9):
                        T2I9.Text = (int.Parse(T2I9.Text) + 1).ToString();
                        break;
                }
            }

        }
        private void CanYouKeepPlaying(int outs)
        {
            if (outs >= 3)
            {
                if (WhoIsBatting == 1)
                {
                    WhoIsBatting++;
                }
                else
                {
                    WhoIsBatting = 1;
                    if (InningNumber < 9)
                    {
                        InningNumber++;
                    }
                    else
                    {
                        MessageBox.Show("Good Game!!");
                        StrikeButton.Enabled = false;
                        OutButton.Enabled = false;
                        BallButton.Enabled = false;
                        FoulButton.Enabled = false;
                        SingleButton.Enabled = false;
                        DoubleButton.Enabled = false;
                        TripleButton.Enabled = false;
                        HomerunButton.Enabled = false;
                        SacrificeButton.Enabled = false;
                        StolenBaseButton.Enabled = false;
                        SafeHitButton.Enabled = false;
                        DoublePlayButton.Enabled = false;
                    }
                }
            }
        }
        private void UpdateScoreBoard()
        {
            StrikeLabel.Text = NumberOfStrikes.ToString();
            OutLabel.Text = NumberOfOuts.ToString();
            BallLabel.Text = NumberOfBalls.ToString();
            CalculateTotalRuns();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateScoreBoard();
        }

        private void BallButton_Click(object sender, EventArgs e)
        {
            CanYouKeepPlaying(NumberOfOuts);
                if (NumberOfBalls < 3)
                {
                    NumberOfBalls++;
                    UpdateScoreBoard();
                }
                else
                {
                    ClearStrikesAndBalls();
                    NumberOfBalls = 0;
                    if (BasesOccupied() == 0 || BasesOccupied() == 1 || BasesOccupied() == 11 || BasesOccupied() == 111)
                    {
                        SingleButton_Click(sender, e);
                    }
                    else
                    {
                        switch (BasesOccupied())
                        {
                            case(10):
                                FirstBase.FillColor = Color.Green;
                                break;
                            case(100):
                                FirstBase.FillColor = Color.Green;
                                break;
                            case(101):
                                SecondBase.FillColor = Color.Green;
                                break;
                            case(110):
                                FirstBase.FillColor = Color.Green;
                                break;

                        }
                    }
                    UpdateScoreBoard();
                }

            
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            CanYouKeepPlaying(NumberOfOuts);
                NumberOfOuts++;
                UpdateScoreBoard();
                //TODO switch sides if over 3 outs
            
            ClearStrikesAndBalls();
        }
        private void ClearStrikesAndBalls()
        {
            NumberOfStrikes = 0;
            NumberOfBalls = 0;
            UpdateScoreBoard();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            switch (BasesOccupied())
            {
                case(0):
                    FirstBase.FillColor = Color.Green;
                    break;
                case(1):
                    SecondBase.FillColor = Color.Green;
                    break;
                case(10):
                    ThirdBase.FillColor = Color.Green;
                    SecondBase.FillColor = Color.White;
                    FirstBase.FillColor = Color.Green;
                    break;
                case(100):
                    ThirdBase.FillColor = Color.White;
                    AddPoint();
                    break;
                case(11):
                    ThirdBase.FillColor = Color.Green;
                    break;
                case(101):
                    ThirdBase.FillColor = Color.White;
                    SecondBase.FillColor = Color.Green;
                    AddPoint();
                    break;
                case(110):
                    SecondBase.FillColor = Color.White;
                    FirstBase.FillColor = Color.Green;
                    AddPoint();
                    break;
                case(111):
                    AddPoint();
                    break;
            }
            ClearStrikesAndBalls();
        }

        private int BasesOccupied()
        {
            //1 = only first base
            //10 = only second base
            //100 = only third base
            //11 = second and first
            //101 = first and third
            //110 = second and third
            //111 = bases loaded

            int counter = 0;

            if (FirstBase.FillColor != Color.White)
            {
                counter++;
            }
            if (SecondBase.FillColor != Color.White)
            {
                counter += 10;
            }
            if (ThirdBase.FillColor != Color.White)
            {
                counter += 100;
            }

            return counter;

        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {

                switch (BasesOccupied())
                {
                    case(0):
                        SecondBase.FillColor = Color.Green;
                        break;
                    case(1):
                        FirstBase.FillColor = Color.White;
                        ThirdBase.FillColor = Color.Green;
                        SecondBase.FillColor = Color.Green;
                        break;
                    case (10):
                        AddPoint();
                        break;
                    case(11):
                        FirstBase.FillColor = Color.White;
                        ThirdBase.FillColor = Color.Green;
                        SecondBase.FillColor = Color.Green;
                        AddPoint();
                        break;
                    case (100):
                        SecondBase.FillColor = Color.Green;
                        ThirdBase.FillColor = Color.White;
                        AddPoint();
                        break;
                    case(101):
                        FirstBase.FillColor = Color.White;
                        SecondBase.FillColor = Color.Green;
                        AddPoint();
                        break;
                    case (110):
                        ThirdBase.FillColor = Color.White;
                        AddPoint();
                        AddPoint();
                        break;
                    case(111):
                        FirstBase.FillColor = Color.White;
                        AddPoint();
                        AddPoint();
                        break;
            }
                ClearStrikesAndBalls();
        }

        private void FoulButton_Click(object sender, EventArgs e)
        {
            CanYouKeepPlaying(NumberOfOuts);
            
                if(NumberOfStrikes < 2)
                {
                    NumberOfStrikes++;
                    UpdateScoreBoard();
                }
            
        }

        private void SacrificeButton_Click(object sender, EventArgs e)
        {
            ClearStrikesAndBalls();
            SingleButton_Click(sender, e);
            FirstBase.FillColor = Color.White;
            NumberOfOuts++;
            UpdateScoreBoard();
        }

        private void SafeHitButton_Click(object sender, EventArgs e)
        {
            NumberOfBalls = 324234;
            BallButton_Click(sender, e);
        }
    }
}
