using System.Threading.Tasks;
using UnityEngine;

public abstract class Ability
{
    private Sprite _icon;
    private float _cooldown, _timeOfLastCast;
    private bool _canCast = true;

    public Ability(Sprite icon, float cooldown)
    {
        _icon = icon;
        _cooldown = cooldown;
    }

    public Sprite GetIcon() => _icon;

    public float GetRemainingCooldown() => _canCast ? 0 : _cooldown - (Time.time - _timeOfLastCast);

    public void TryCast()
    {
        if (_canCast)
        {
            Cast();
            ActivateCooldown();
        }
    }

    protected abstract void Cast();

    private async void ActivateCooldown()
    {
        _timeOfLastCast = Time.time;
        _canCast = false;
        await Task.Delay((int)(_cooldown * 1000));
        _canCast = true;
    }
}
