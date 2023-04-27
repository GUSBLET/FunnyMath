using FannyMath.Enums;
using FannyMath.Models;
using System.Runtime.InteropServices;

namespace FannyMath.Services
{
    public class TugOfWarGame : MiniGame
    {
        private TugOfWarScore _tugOfWarScore;
        public bool _isChangeScore { get; set; }
        public int[] Number { get; set; }
        public string[] Actions { get; set; }

        public TugOfWarGame(TugOfWarScore tugOfWarScore)
        {
            _tugOfWarScore = new();
            _tugOfWarScore.Score = 0;
            _tugOfWarScore.HardMode = tugOfWarScore.HardMode;
            SetHardMode();
        }

        public void SetScore(int score)
        {
            _tugOfWarScore.Score = score;
        }

        public void UpdateScore()
        {
            if (_isChangeScore)
            {
                _tugOfWarScore.Score++;
                _isChangeScore = false;
            }
        }

        public int GetScore() => _tugOfWarScore.Score;

        public HardMode GetHardMode() => _tugOfWarScore.HardMode;

        public override bool ChangeHardMode(int score)
        {
            if (score == 4 && _tugOfWarScore.HardMode == HardMode.VeryEasy)
            {
                _tugOfWarScore.HardMode = HardMode.Easy;
                return true;
            }

            else if (score == 9 && _tugOfWarScore.HardMode == HardMode.Easy)
            {
                _tugOfWarScore.HardMode = HardMode.Simple;
                return true;
            }

            else if (score == 19 && _tugOfWarScore.HardMode == HardMode.Simple)
            {
                _tugOfWarScore.HardMode = HardMode.Hard;
                return true;
            }

            else if (score == 29 && _tugOfWarScore.HardMode == HardMode.Hard)
            {
                _tugOfWarScore.HardMode = HardMode.VeryHard;
                return true;
            }

            else if (score == 39 && _tugOfWarScore.HardMode == HardMode.VeryHard)
            {
                _tugOfWarScore.HardMode = HardMode.Imposible;
                return true;
            }

            else if (score == 99 && _tugOfWarScore.HardMode == HardMode.Imposible)
            {
                _tugOfWarScore.HardMode = HardMode.Winner;
                return true;
            }
            else
            {
                return false;
            }
        }

        

        private int[] MixArray(int[] array)
        {
            Random rand = new Random();

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
            
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        public void GetNewData()
        {
            SetHardMode();
        }

        protected override void SetHardMode()
        {
            Random random= new Random();
            switch (_tugOfWarScore.HardMode)
            {
                case HardMode.VeryEasy:
                    Number = MixArray(SetNumber(3, 1, 10));
                    break;
                case HardMode.Easy:
                    Number = MixArray(SetNumber(4, 1, 100));
                    break;
                case HardMode.Simple:
                    Number = MixArray(SetNumber(6, -100, 100));
                    break;
                case HardMode.Hard:
                    Number = MixArray(SetNumber(7, -1000, 1000));
                    break;
                case HardMode.VeryHard:
                    Number = MixArray(SetNumber(8, -1000, 1000));
                    break;
                case HardMode.Imposible:
                    Number = MixArray(SetNumber(10, -1000, 1000));
                    break;
                default:
                    break;
            }
            Actions = new string[] { "Від найменшого до найбільшого", "Від найбільшого до найменшого" };
        }

        private int[] SetNumber(int count, int limitFrom, int limitTo)
        {
            Random random = new Random();
            var arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(limitFrom, limitTo);
            }
            return arr;
        }
    }
}
