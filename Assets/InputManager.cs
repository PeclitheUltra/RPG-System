using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public PlayerInputActions Actions;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Actions = new PlayerInputActions();
        Actions.Enable();
    }
}
