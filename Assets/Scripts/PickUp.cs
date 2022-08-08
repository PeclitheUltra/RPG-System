using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if(player != null)
        {
            AffectPlayer(player);
            Destroy(gameObject);
        }
    }

    protected abstract void AffectPlayer(Player player);
}
