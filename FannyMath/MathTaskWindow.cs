using FannyMath.Models;
using FannyMath.Services;

namespace FannyMath
{
    public partial class MathTaskWindow : Form
    {
        private MathTaskScore _mathTaskScore;
        private MathGame _mathGame;

        public MathTaskScore GetResult()
        {
            _mathTaskScore = new MathTaskScore();
            if (int.Parse(CorentScore.Text) >= int.Parse(BetterScore.Text))
                _mathTaskScore.Score = _mathGame.GetScore();
            else
                _mathTaskScore.Score = int.Parse(BetterScore.Text);
            _mathTaskScore.HardMode = _mathGame.GetHardMode();
            
            return _mathTaskScore;
        }

        public MathTaskWindow(MathTaskScore mathTaskScore)
        {
            InitializeComponent();
            _mathTaskScore = mathTaskScore;
            _mathGame = new(_mathTaskScore);
            Update();
        }

        private void Update()
        {
            if (_mathGame.ChangeHardMode(_mathGame.GetScore()))
            {
                string message;
                if (_mathGame.GetHardMode() == Enums.HardMode.Winner)
                    message = "You are winner";
                else
                    message = "You have finished level";

                MessageBox.Show(message);

                //var modal = new ModalWindow(message);
                //modal.ShowDialog();
                button1.Visible = false;
            }
            else
            {
                Random random = new Random();
                BetterScore.Text = _mathTaskScore.Score.ToString();
                
                Action.Text = _mathGame.CharacterSet[random.Next(0, _mathGame.CharacterSet.Length)];
                if (Action.Text == "^")
                {
                    Num1.Text = random.Next(1, 11).ToString();
                    Num2.Text = random.Next(1, 11).ToString();
                }
                else
                {
                    Num1.Text = random.Next(_mathGame.DiapasoneSet[0], _mathGame.DiapasoneSet[1]).ToString();
                    Num2.Text = random.Next(_mathGame.DiapasoneSet[0], _mathGame.DiapasoneSet[1]).ToString();
                } 
            }
            _mathGame.UpdateScore();
            CorentScore.Text = _mathGame.GetScore().ToString();

        }
            

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Count_Click(object sender, EventArgs e)
        {
            if(AnswerBox.Text.Length > 0)
            {
                
                if (double.Parse(AnswerBox.Text) == Count(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text), Action.Text))
                {
                    _mathGame._isChangeScore = true;
                    Update();
                }
                else
                {
                    Update();
                }
                AnswerBox.Text = string.Empty;
            }
        }

        private double Count(int num1, int num2, string action)
        {
            double i = 0;
            switch (action)
            {
                case "+":
                    i = num1 + num2;
                    break;
                case "-":
                    i = num1 - num2;
                    break;
                case "/":
                    i = num1 / num2;
                    break;
                case "*":
                    i = num1 * num2;
                    break;
                case "^":
                    i = num1 ^ num2;
                    break;
                case "%":
                    i = num1 % num2;
                    break;
                default:
                    break;
            }
            return i;
        }
    }
}
