using FannyMath.Models;
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
    public partial class ModalWindow : Form
    {
        private readonly ScoreOfUser _scoreOfUser;
        public ModalWindow(ScoreOfUser scoreOfUser)
        {
            InitializeComponent();
            _scoreOfUser = scoreOfUser;
            MathScore.Text = scoreOfUser.MathTaskScore.Score.ToString();
            MathMode.Text = scoreOfUser.MathTaskScore.HardMode.ToString();

            EquationScore.Text = scoreOfUser.EquationScoreModel.Score.ToString();
            EquationMode.Text = scoreOfUser.EquationScoreModel.HardMode.ToString();

            TurOfWarScore.Text = scoreOfUser.TugOfWarScore.Score.ToString();
            TurOfWarMode.Text = scoreOfUser.TugOfWarScore.HardMode.ToString();
        }
    }
}
