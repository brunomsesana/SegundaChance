//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Extras/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cf56e891-5fa2-4451-80ad-b1f28815ca1b"",
            ""actions"": [
                {
                    ""name"": ""XAxis"",
                    ""type"": ""Value"",
                    ""id"": ""294d77a4-9799-41b9-8ee0-8a2dc6ed1b8b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""YAxis"",
                    ""type"": ""Value"",
                    ""id"": ""8f864378-9851-47f5-8949-b052fff31a13"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f5026d5f-feec-4031-9f7a-ebf220da4dac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interate"",
                    ""type"": ""Button"",
                    ""id"": ""a180924f-2674-440f-82c1-96e3af718d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""c71cedbe-9b59-4e81-9649-317e58692d90"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0c648c4d-671a-407c-bdbb-50c7264b04aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5cac4358-e59e-418b-9973-b658383cd75a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left-Right"",
                    ""id"": ""ef51401d-a741-4715-ae82-1b77ffe22b1e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9d89c968-7767-415e-89b0-8cd3d9e90d2d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6bdb0eec-4886-4b63-a79f-a558579493a3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""145b48a8-7028-46eb-8657-daa5a03b67e9"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SW"",
                    ""id"": ""67b6c319-ee59-4ba0-b04f-6dc6c0939779"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b759b848-3e91-4bc9-bf4b-86d7b4dfd45b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2ce59943-35f3-407b-ad73-ef4918f05668"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down-Up"",
                    ""id"": ""6e6065b8-f8f4-4621-b90e-96ac9de0688d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a10e002b-2e51-4957-b680-ad2a399d5842"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9757b7d6-abc4-4927-a0d7-0c60761448f5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e25f2e43-06d2-4d4e-8ed5-faf7a0d8c37e"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9dbfc05-5f10-41db-af18-874fbf6433a7"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86eb30f2-1af9-4a50-bb8e-c07c28b77ad2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ac931d0-c2f9-4512-a9c1-f51373940235"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""441edba7-73c5-4abb-a1e0-35614340725b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9473a053-df0a-41c3-8c7d-965f8d8f5194"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Timelines"",
            ""id"": ""3087c8f2-51e4-43bf-8d0b-093006e0bd88"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""3e9adbb8-ca22-4af4-ac30-51fe5da65007"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b7094dd-2879-4f73-ac6a-e8ed54541fcf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_XAxis = m_Player.FindAction("XAxis", throwIfNotFound: true);
        m_Player_YAxis = m_Player.FindAction("YAxis", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_Interate = m_Player.FindAction("Interate", throwIfNotFound: true);
        // Timelines
        m_Timelines = asset.FindActionMap("Timelines", throwIfNotFound: true);
        m_Timelines_Unpause = m_Timelines.FindAction("Unpause", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_XAxis;
    private readonly InputAction m_Player_YAxis;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_Interate;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @XAxis => m_Wrapper.m_Player_XAxis;
        public InputAction @YAxis => m_Wrapper.m_Player_YAxis;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @Interate => m_Wrapper.m_Player_Interate;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @XAxis.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXAxis;
                @XAxis.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXAxis;
                @XAxis.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXAxis;
                @YAxis.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYAxis;
                @YAxis.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYAxis;
                @YAxis.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYAxis;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Interate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterate;
                @Interate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterate;
                @Interate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterate;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @XAxis.started += instance.OnXAxis;
                @XAxis.performed += instance.OnXAxis;
                @XAxis.canceled += instance.OnXAxis;
                @YAxis.started += instance.OnYAxis;
                @YAxis.performed += instance.OnYAxis;
                @YAxis.canceled += instance.OnYAxis;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Interate.started += instance.OnInterate;
                @Interate.performed += instance.OnInterate;
                @Interate.canceled += instance.OnInterate;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Timelines
    private readonly InputActionMap m_Timelines;
    private ITimelinesActions m_TimelinesActionsCallbackInterface;
    private readonly InputAction m_Timelines_Unpause;
    public struct TimelinesActions
    {
        private @Controls m_Wrapper;
        public TimelinesActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Unpause => m_Wrapper.m_Timelines_Unpause;
        public InputActionMap Get() { return m_Wrapper.m_Timelines; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TimelinesActions set) { return set.Get(); }
        public void SetCallbacks(ITimelinesActions instance)
        {
            if (m_Wrapper.m_TimelinesActionsCallbackInterface != null)
            {
                @Unpause.started -= m_Wrapper.m_TimelinesActionsCallbackInterface.OnUnpause;
                @Unpause.performed -= m_Wrapper.m_TimelinesActionsCallbackInterface.OnUnpause;
                @Unpause.canceled -= m_Wrapper.m_TimelinesActionsCallbackInterface.OnUnpause;
            }
            m_Wrapper.m_TimelinesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Unpause.started += instance.OnUnpause;
                @Unpause.performed += instance.OnUnpause;
                @Unpause.canceled += instance.OnUnpause;
            }
        }
    }
    public TimelinesActions @Timelines => new TimelinesActions(this);
    public interface IPlayerActions
    {
        void OnXAxis(InputAction.CallbackContext context);
        void OnYAxis(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInterate(InputAction.CallbackContext context);
    }
    public interface ITimelinesActions
    {
        void OnUnpause(InputAction.CallbackContext context);
    }
}
