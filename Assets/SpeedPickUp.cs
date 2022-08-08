using UnityEngine;

public class SpeedPickUp : PickUp
{
    [SerializeField] private float _multiplier, _length;

    protected override void AffectPlayer(Player player)
    {
        player.ApplyBuff(new BuffSpeed(_length, _multiplier));
    }
}
