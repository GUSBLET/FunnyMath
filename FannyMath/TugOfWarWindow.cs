using FannyMath.Models;
using FannyMath.Services;


namespace FannyMath
{
    public partial class TugOfWarWindow : Form
    {
        private TugOfWarScore _tugOfWarScore;
        private TugOfWarGame _tugOfWarGame;
        private List<Label> _labels = new List<Label>();
        private int _correntIndex;
        

        public TugOfWarWindow(TugOfWarScore tugOfWarScore)
        {
            InitializeComponent();
            _tugOfWarScore = tugOfWarScore;
            _tugOfWarGame = new(tugOfWarScore);
            Update();
        }

        public TugOfWarScore GetResult()
        {
            _tugOfWarScore = new TugOfWarScore();
            if (int.Parse(CorentScore.Text) >= int.Parse(BetterScore.Text))
                _tugOfWarScore.Score = _tugOfWarGame.GetScore();
            else
                _tugOfWarScore.Score = int.Parse(BetterScore.Text);
            _tugOfWarScore.HardMode = _tugOfWarGame.GetHardMode();

            return _tugOfWarScore;
        }

        private List<Label> GenarationList(int[] parameters, PictureBox pictureBox)
        {
            List<Label> list = new List<Label>(parameters.Length);
            for (int i = 0; i < parameters.Length; i++)
            {
                list.Add(new Label());
                list[i].Parent = pictureBox;
                list[i].Text = parameters[i].ToString();
                list[i].Width = 80;
                list[i].Height = 30;
                list[i].Font = new Font("Arial", 14);
                list[i].AllowDrop = true;
                list[i].Location = new Point(10+80*i, 399);
                list[i].Tag = i;
                list[i].MouseDown += new MouseEventHandler(BoomBoom);
            }
            return list;
        }

        private void Update()
        {
            if (_tugOfWarGame.ChangeHardMode(_tugOfWarGame.GetScore()))
            {
                string message;
                if (_tugOfWarGame.GetHardMode() == Enums.HardMode.Winner)
                    message = "You are winner";
                else
                    message = "You have finished level";

                MessageBox.Show(message);

                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                Random random = new Random();
                BetterScore.Text = _tugOfWarScore.Score.ToString();
                if (_labels.Count > 0)
                {
                    _labels.Clear();
                    _tugOfWarGame.GetNewData();
                    textBox1.Text = "";
                }
                    
                _labels = GenarationList(_tugOfWarGame.Number, pictureBox1);
                
                Action.Text = _tugOfWarGame.Actions[random.Next(0, 2)];
            }
            _tugOfWarGame.UpdateScore();
            CorentScore.Text = _tugOfWarGame.GetScore().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in _labels)
            {
                item.Visible = true;
            }
            textBox1.Text = "";
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text += " ";
            textBox1.Text += e.Data.GetData(DataFormats.Text).ToString();
            _labels[_correntIndex].Visible = false;
        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void BoomBoom(object sender, MouseEventArgs e)
        {
            _correntIndex = Convert.ToInt32(((Label)sender).Tag);
            ((Label)sender).DoDragDrop(((Label)sender).Text, DragDropEffects.Move);
        }

        private int[] ConverToIntArrayLine(string line)
        {
            line = line.Remove(0, 1);
            var list = line.Split(' ');
            int[] array = new int[list.Length];
            
            for (int i = 0; i < list.Length; i++)
            {
                array[i] = Convert.ToInt32(list[i]);
            }

            return array;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Count(ConverToIntArrayLine(textBox1.Text)))
            {
                _tugOfWarGame._isChangeScore = true;
                Update();
            }
            else
            {
                Update();
            }
        }

        private bool Count(int[] userList)
        {
            if(Action.Text == _tugOfWarGame.Actions[0])
            {
                Array.Sort(_tugOfWarGame.Number);
                
                for (int i = 0; i < _tugOfWarGame.Number.Length; i++)
                {
                    if (_tugOfWarGame.Number[i] != userList[i])
                        return false;
                }
            }   
            else if(Action.Text == _tugOfWarGame.Actions[1])
            {
                Array.Sort(_tugOfWarGame.Number);
                Array.Reverse(_tugOfWarGame.Number);
                for (int i = 0; i < _tugOfWarGame.Number.Length; i++)
                {
                    if (_tugOfWarGame.Number[i] != userList[i])
                        return false;
                }
            }
            
            return true;
        }

        private void finish_Click(object sender, EventArgs e)
        {

        }
    }
}
