using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Buff
{
    private Sprite _icon;
    private float _length;
    private CancellationTokenSource _cancelToken = new CancellationTokenSource();

    public Buff(float length)
    {
        _length = length;
    }

    public async void ApplyBuff(Stats stats)
    {
        await Task.Delay(10);
        ChangeStats(stats, true);
        RemoveBuff(stats);
    }

    public async void ApplyBuff(Stats stats, Action onComplete)
    {
        await Task.Delay(10);
        ChangeStats(stats, true);
        RemoveBuff(stats, onComplete);
    }

    public void EarlyRemoveBuff()
    {
        _cancelToken.Cancel();
    }

    protected abstract void ChangeStats(Stats stats, bool forward);

    private async void RemoveBuff(Stats stats)
    {
        await Task.Delay((int)(_length * 1000), _cancelToken.Token);
        ChangeStats(stats, false);
    }

    private async void RemoveBuff(Stats stats, Action onComplete)
    {
        await Task.Delay((int)(_length * 1000), _cancelToken.Token);
        ChangeStats(stats, false);
        onComplete.Invoke();
    }

}
