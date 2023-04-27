using FannyMath.Enums;
using FannyMath.Models;

namespace FannyMath.Services;

public class MathGame : MiniGame
{
    private MathTaskScore _mathTaskScore;
    public bool _isChangeScore { get; set; }
    public string[] CharacterSet { get; set; }
    public int[] DiapasoneSet { get; set; }

    public MathGame(MathTaskScore mathTaskScore)
    {
        _mathTaskScore = new();
        _mathTaskScore.Score = 0;
        _mathTaskScore.HardMode = mathTaskScore.HardMode;
        SetHardMode();
    }

    public void SetScore(int score)
    {
        _mathTaskScore.Score = score;
    }

    public int GetScore() => _mathTaskScore.Score;
    public HardMode GetHardMode() => _mathTaskScore.HardMode;

    protected override void SetHardMode()
    {
        switch (_mathTaskScore.HardMode)
        {
            case HardMode.VeryEasy:
                CharacterSet = new string[] { "+" };
                DiapasoneSet = new int[] { 1, 9 };
                break;
            case HardMode.Easy:
                CharacterSet = new string[] { "+", "-" };
                DiapasoneSet = new int[] { 1, 50 };
                break;
            case HardMode.Simple:
                CharacterSet = new string[] { "/", "*" };
                DiapasoneSet = new int[] { 1, 100 };
                break;
            case HardMode.Hard:
                CharacterSet = new string[] { "+", "-", "/", "*" };
                DiapasoneSet = new int[] { 1, 100 };
                break;
            case HardMode.VeryHard:
                CharacterSet = new string[] { "+", "-", "/", "*", "^" };
                DiapasoneSet = new int[] { 1, 100 };
                break;
            case HardMode.Imposible:
                CharacterSet = new string[] { "+", "-", "/", "*", "^", "%" };
                DiapasoneSet = new int[] { 1, 100 };
                break;
            default:
                break;
        }
    }

    public void UpdateScore()
    {
        if(_isChangeScore)
        {
            _mathTaskScore.Score++;
            _isChangeScore = false;
        }
    }

    public override bool ChangeHardMode(int score)
    {
        if (score == 4 && _mathTaskScore.HardMode == HardMode.VeryEasy)
        {
            _mathTaskScore.HardMode = HardMode.Easy;
            return true;
        }

        else if (score == 9 && _mathTaskScore.HardMode == HardMode.Easy)
        {
            _mathTaskScore.HardMode = HardMode.Simple;
            return true;
        }

        else if (score == 19 && _mathTaskScore.HardMode == HardMode.Simple)
        {
            _mathTaskScore.HardMode = HardMode.Hard;
            return true;
        }
            
        else if (score == 29 && _mathTaskScore.HardMode == HardMode.Hard)
        {
            _mathTaskScore.HardMode = HardMode.VeryHard;
            return true;
        }
            
        else if (score == 39 && _mathTaskScore.HardMode == HardMode.VeryHard)
        {
            _mathTaskScore.HardMode = HardMode.Imposible;
            return true;
        }

        else if (score == 99 && _mathTaskScore.HardMode == HardMode.Imposible)
        {
            _mathTaskScore.HardMode = HardMode.Winner;
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
