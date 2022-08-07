using UnityEngine;

public class Player : MonoBehaviour
{
    private Stats _stats;
    private AbilityCaster _caster;
    private PlayerMover _mover;
    private BuffTarget _buffer;

    private void Start()
    {
        _stats = new Stats(100f, 100f, 10f, 3f, 5f);
        _mover = new PlayerMover(GetComponent<CharacterController>(), _stats, InputManager.Instance.Actions.Player.Movement);
        _caster = new AbilityCaster(
            InputManager.Instance.Actions.Player.UseAbility1,
            InputManager.Instance.Actions.Player.UseAbility2,
            InputManager.Instance.Actions.Player.UseAbility3,
            InputManager.Instance.Actions.Player.UseAbility4
            );
        _buffer = new BuffTarget();
    }

    private void Update()
    {
        _mover.Update();
    }
}
