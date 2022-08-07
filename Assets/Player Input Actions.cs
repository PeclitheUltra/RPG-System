// GENERATED AUTOMATICALLY FROM 'Assets/Player Input Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Input Actions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""04adc349-2fe5-499f-9b72-f1f2c37647e2"",
            ""actions"": [
                {
                    ""name"": ""Use Ability 1"",
                    ""type"": ""Button"",
                    ""id"": ""ce79aab0-06b9-4b50-b627-fa8559e29a93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Ability 2"",
                    ""type"": ""Button"",
                    ""id"": ""e7b5aedf-e9b1-4df6-aece-82b94e5c1703"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Ability 3"",
                    ""type"": ""Button"",
                    ""id"": ""5d83c045-c38f-401a-9d50-75fbbcbf1a21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Ability 4"",
                    ""type"": ""Button"",
                    ""id"": ""4e8ecd2f-991b-4c5f-b0c6-934a8e846bfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5f669d44-3d0c-45dd-a28a-0dc8da256570"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""974716db-3d8f-4999-800f-f7b897deaacd"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Ability 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be82529a-bddd-44e1-8b1c-9fc7557d9ffd"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Ability 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8b0d0f0-6000-484d-a27a-74f71fb02136"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Ability 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8cdad46-ea8e-4ee0-88f3-6dd8bb13a13b"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Ability 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5b1f6316-e912-4cd4-ab76-8341222fbe93"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""61733374-e9f2-466e-adc3-e84e38f87efd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""577ffefd-b796-4371-b5d1-bc7ab5d9f38f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a6f337a-cd46-4493-9915-61a2cf1f0166"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b81737a1-2998-4cfa-a18f-cb07b15c5acc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_UseAbility1 = m_Player.FindAction("Use Ability 1", throwIfNotFound: true);
        m_Player_UseAbility2 = m_Player.FindAction("Use Ability 2", throwIfNotFound: true);
        m_Player_UseAbility3 = m_Player.FindAction("Use Ability 3", throwIfNotFound: true);
        m_Player_UseAbility4 = m_Player.FindAction("Use Ability 4", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_UseAbility1;
    private readonly InputAction m_Player_UseAbility2;
    private readonly InputAction m_Player_UseAbility3;
    private readonly InputAction m_Player_UseAbility4;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @UseAbility1 => m_Wrapper.m_Player_UseAbility1;
        public InputAction @UseAbility2 => m_Wrapper.m_Player_UseAbility2;
        public InputAction @UseAbility3 => m_Wrapper.m_Player_UseAbility3;
        public InputAction @UseAbility4 => m_Wrapper.m_Player_UseAbility4;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @UseAbility1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility1;
                @UseAbility1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility1;
                @UseAbility1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility1;
                @UseAbility2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility2;
                @UseAbility2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility2;
                @UseAbility2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility2;
                @UseAbility3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility3;
                @UseAbility3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility3;
                @UseAbility3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility3;
                @UseAbility4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility4;
                @UseAbility4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility4;
                @UseAbility4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseAbility4;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UseAbility1.started += instance.OnUseAbility1;
                @UseAbility1.performed += instance.OnUseAbility1;
                @UseAbility1.canceled += instance.OnUseAbility1;
                @UseAbility2.started += instance.OnUseAbility2;
                @UseAbility2.performed += instance.OnUseAbility2;
                @UseAbility2.canceled += instance.OnUseAbility2;
                @UseAbility3.started += instance.OnUseAbility3;
                @UseAbility3.performed += instance.OnUseAbility3;
                @UseAbility3.canceled += instance.OnUseAbility3;
                @UseAbility4.started += instance.OnUseAbility4;
                @UseAbility4.performed += instance.OnUseAbility4;
                @UseAbility4.canceled += instance.OnUseAbility4;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnUseAbility1(InputAction.CallbackContext context);
        void OnUseAbility2(InputAction.CallbackContext context);
        void OnUseAbility3(InputAction.CallbackContext context);
        void OnUseAbility4(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
