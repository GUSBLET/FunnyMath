using FannyMath.Models;
using FannyMath.Services;

namespace FannyMath
{
    public partial class Form1 : Form, IDisposable
    {
        private ScoreOfUser _scoreOfUser;
        private readonly FileSaver _fileSaver;
        public Form1()
        {
            InitializeComponent();
            _fileSaver = new();
            _scoreOfUser = new();
            _scoreOfUser = _fileSaver.ReadScore();
            if(_scoreOfUser == null )
            {
                _scoreOfUser = _fileSaver.EmptyObjectGeneration();
            }


        }


        

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenGame(object sender, EventArgs e)
        {
            var triger = (PictureBox)sender;
            switch (triger.Name)
            {
                case "TugOfWar":
                    TugOfWarWindow tugOfWarWindow = new TugOfWarWindow(_scoreOfUser.TugOfWarScore);
                    if(tugOfWarWindow.ShowDialog() == DialogResult.OK)
                    {
                        _scoreOfUser.TugOfWarScore = tugOfWarWindow.GetResult();
                    }
                    break;
                case "MathTask":
                    MathTaskWindow mathTaskWindow = new MathTaskWindow(_scoreOfUser.MathTaskScore);
                    if(mathTaskWindow.ShowDialog() == DialogResult.OK)
                    {
                        _scoreOfUser.MathTaskScore = mathTaskWindow.GetResult();
                    }
                    break;
                case "Equation":
                    EquationWindow equationTaskWindow = new(_scoreOfUser.EquationScoreModel);
                    if (equationTaskWindow.ShowDialog() == DialogResult.OK)
                    {
                        _scoreOfUser.EquationScoreModel = equationTaskWindow.GetResult();
                    }
                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileSaver.SaveResult(_scoreOfUser);
            MessageBox.Show("Score was saved");
        }

        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalWindow modalWindow = new(_scoreOfUser);
            modalWindow.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fileSaver.SaveResult(_scoreOfUser);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fileSaver.DeleteFile())
            {
                MessageBox.Show("Success");
                _scoreOfUser = _fileSaver.EmptyObjectGeneration();
            }
            else
                MessageBox.Show("Error");

        }
    }
}