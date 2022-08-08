using UnityEngine;

public class Fireball : Ability
{
    private float _damage;
    public Fireball(Sprite icon, float cooldown, float damage) : base(icon, cooldown)
    {
        _damage = damage;
    }

    protected override void Cast()
    {
        Debug.Log($"Fireball cast for {_damage} damage");
    }
}
