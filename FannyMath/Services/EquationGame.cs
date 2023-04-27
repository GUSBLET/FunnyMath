using FannyMath.Enums;
using FannyMath.Models;

namespace FannyMath.Services;

public class EquationGame : MiniGame
{
    private EquationScoreModel _equationScoreModel;

    public string[] CharacterSet { get; set; }
    public bool _isChangeScore { get; set; }
    public EquationGame(EquationScoreModel equationScoreModel) 
    {
        _equationScoreModel = new();
        _equationScoreModel.Score = 0;
        _equationScoreModel.HardMode = equationScoreModel.HardMode;
        SetHardMode();
    }

    
    public void SetScore(int score)
    {
        _equationScoreModel.Score = score;
    }

    public int GetScore() => _equationScoreModel.Score;
    public HardMode GetHardMode() => _equationScoreModel.HardMode;

    public void UpdateScore()
    {
        if (_isChangeScore)
        {
            _equationScoreModel.Score++;
            _isChangeScore = false;
        }
    }

    public override bool ChangeHardMode(int score)
    {
        if (score == 4 && _equationScoreModel.HardMode == HardMode.VeryEasy)
        {
            _equationScoreModel.HardMode = HardMode.Easy;
            return true;
        }

        else if (score == 9 && _equationScoreModel.HardMode == HardMode.Easy)
        {
            _equationScoreModel.HardMode = HardMode.Simple;
            return true;
        }

        else if (score == 19 && _equationScoreModel.HardMode == HardMode.Simple)
        {
            _equationScoreModel.HardMode = HardMode.Hard;
            return true;
        }

        else if (score == 29 && _equationScoreModel.HardMode == HardMode.Hard)
        {
            _equationScoreModel.HardMode = HardMode.VeryHard;
            return true;
        }

        else if (score == 39 && _equationScoreModel.HardMode == HardMode.VeryHard)
        {
            _equationScoreModel.HardMode = HardMode.Imposible;
            return true;
        }

        else if (score == 99 && _equationScoreModel.HardMode == HardMode.Imposible)
        {
            _equationScoreModel.HardMode = HardMode.Winner;
            return true;
        }
        else
        {
            return false;
        }

    }

    protected override void SetHardMode()
    {
        switch (_equationScoreModel.HardMode)
        {
            case HardMode.VeryEasy:
                CharacterSet = new string[] { "=" };
                break;
            case HardMode.Easy:
                CharacterSet = new string[] { ">", "<" };
                break;
            case HardMode.Simple:
                CharacterSet = new string[] { ">", "<", "=" };
                break;
            case HardMode.Hard:
                CharacterSet = new string[] { ">=", "<=" };
                break;
            case HardMode.VeryHard:
                CharacterSet = new string[] { ">=", "<=", "=", ">", "<" };
                break;
            case HardMode.Imposible:
                CharacterSet = new string[] { ">=", "<=", "=", ">", "<", "!=" };
                break;
            default:
                break;
        }
    }

    
}
