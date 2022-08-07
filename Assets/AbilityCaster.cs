using System;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class AbilityCaster
{
    private Ability[] _abilities;

    public AbilityCaster(InputAction action1, InputAction action2, InputAction action3, InputAction action4)
    {
        _abilities = new Ability[4];
        _abilities[0] = new Fireball(null, 3f, 1f);
        _abilities[1] = new Fireball(null, 3f, 2f);
        _abilities[2] = new Fireball(null, 3f, 3f);
        _abilities[3] = new Fireball(null, 3f, 4f);

        action1.performed += (CallbackContext context) => _abilities[0].TryCast();
        action2.performed += (CallbackContext context) => _abilities[1].TryCast();
        action3.performed += (CallbackContext context) => _abilities[2].TryCast();
        action4.performed += (CallbackContext context) => _abilities[3].TryCast();
    }
}
