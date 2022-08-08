using UnityEngine;

public class BuffSpeed : Buff
{
    private float _power;

    public BuffSpeed(Stats stats, float length, float power) : base(stats, length)
    {
        _power = power;
    }

    public override void ChangeStats(Stats stats, bool forward)
    {
        if (forward)
        {
            stats.MovementSpeed *= _power;
        }
        else
        {
            stats.MovementSpeed /= _power;
        }
    }
}
