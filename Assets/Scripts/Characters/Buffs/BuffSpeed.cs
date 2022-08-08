public class BuffSpeed : Buff
{
    private float _power;

    public BuffSpeed(float length, float power) : base(length)
    {
        _power = power;
    }

    protected override void ChangeStats(Stats stats, bool forward)
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
