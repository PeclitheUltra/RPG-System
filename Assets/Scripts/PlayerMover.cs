using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover
{
    private CharacterController _controller;
    private Stats _stats;
    private InputAction _action;

    public PlayerMover(CharacterController controller, Stats stats, InputAction action)
    {
        _controller = controller;
        _stats = stats;
        _action = action;
    }

    public void Update()
    {
        var inputVector = _action.ReadValue<Vector2>();
        inputVector.Normalize();
        inputVector *= _stats.MovementSpeed * Time.deltaTime;
        _controller.Move(_controller.transform.forward * inputVector.y + _controller.transform.right * inputVector.x);
    }
}
