using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Buff
{
    private Sprite _icon;
    private float _length;
    private CancellationTokenSource _cancelToken = new CancellationTokenSource();

    public Buff(Stats stats, float length)
    {
        _length = length;
        ApplyBuff(stats);
        RemoveBuff(stats);
    }

    private async void ApplyBuff(Stats stats)
    {
        await Task.Delay(10);
        ChangeStats(stats, true);
    }

    public void EarlyRemoveBuff()
    {
        _cancelToken.Cancel();
    }

    public abstract void ChangeStats(Stats stats, bool forward);

    private async void RemoveBuff(Stats stats)
    {
        await Task.Delay((int)(_length * 1000), _cancelToken.Token);
        ChangeStats(stats, false);
    }
    
}
