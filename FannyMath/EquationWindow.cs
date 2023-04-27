using FannyMath.Models;
using FannyMath.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FannyMath
{
    public partial class EquationWindow : Form
    {
        private EquationScoreModel _equationScoreModel;
        private EquationGame _equationGame;
        public EquationWindow(EquationScoreModel equationScoreModel)
        {
            InitializeComponent();
            _equationScoreModel = equationScoreModel;
            _equationGame = new(_equationScoreModel);
            Update();
        }

        private void Update()
        {
            if (_equationGame.ChangeHardMode(_equationGame.GetScore()))
            {
                string message;
                if (_equationGame.GetHardMode() == Enums.HardMode.Winner)
                    message = "You are winner";
                else
                    message = "You have finished level";

                MessageBox.Show(message);

                button1.Visible = false;
            }
            else
            {
                Random random = new Random();
                BetterScore.Text = _equationScoreModel.Score.ToString();

                Action.Text = _equationGame.CharacterSet[random.Next(0, _equationGame.CharacterSet.Length)];
                
                Num1.Text = random.Next(-10, 10).ToString();
                Num2.Text = random.Next(-10, 10).ToString();

            }
            _equationGame.UpdateScore();
            CorentScore.Text = _equationGame.GetScore().ToString();

        }

        public EquationScoreModel GetResult()
        {
            _equationScoreModel = new EquationScoreModel();
            if (int.Parse(CorentScore.Text) >= int.Parse(BetterScore.Text))
                _equationScoreModel.Score = _equationGame.GetScore();
            else
                _equationScoreModel.Score = int.Parse(BetterScore.Text);
            _equationScoreModel.HardMode = _equationGame.GetHardMode();

            return _equationScoreModel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Text = "Вірно";
            else
                checkBox1.Text = "Не вірно";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Count(int.Parse(Num1.Text), int.Parse(Num2.Text), Action.Text, checkBox1.Checked)) 
            { 
                _equationGame._isChangeScore = true;
                Update();
            }
            else
            {
                Update();
            }
        }
        private bool Count(int num1, int num2, string action, bool val)
        {
            bool i = false;
            switch (action)
            {
                case ">":
                    i = num1 > num2 ? true : false;
                    break;
                case "<":
                    i = num1 < num2 ? true : false;
                    break;
                case "=":
                    i = num1 == num2 ? true : false;
                    break;
                case "!=":
                    i = num1 != num2 ? true : false;
                    break;
                case ">=":
                    i = num1 >= num2 ? true : false;
                    break;
                case "<=":
                    i = num1 <= num2 ? true : false;
                    break;
                default:
                    break;
            }

            if (i && val)
            {
                i = true;
            }
            else if (i == false && val == false) 
            {
                i = true;
            }

            return i;
        }
    }
}
