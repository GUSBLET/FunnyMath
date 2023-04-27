using FannyMath.Enums;
using FannyMath.Models;

namespace FannyMath.Services;

public abstract class MiniGame
{
    protected virtual void SetHardMode()
    {
    }

    public virtual bool ChangeHardMode(int score)
    {
        if (score == 5)
            return true;
        else if (score <= 10)
            return true;
        else if (score <= 20)
            return true;
        else if (score <= 30)
            return true;
        else if (score <= 40)
            return true;
        else if (score <= 100)
            return true;
        return false;
    }
}
