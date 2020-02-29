// GENERATED AUTOMATICALLY FROM 'Assets/Input´s.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input´s"",
    ""maps"": [
        {
            ""name"": ""Movimentacao"",
            ""id"": ""e8d2bc50-11d4-4ca1-85c9-3d5fc578a962"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Button"",
                    ""id"": ""3a3e9854-b4c3-4c60-9111-7b3919a5d251"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ab2469d7-4dc2-4c2e-b6e3-762fa00351d7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a49fe8eb-fb6c-42ed-b8aa-01f29ec3c7a5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57217e25-a991-46b0-8d42-0ff1704e2591"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e27cc9b9-daab-41f9-8cd0-6611cb51136d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c3b28524-36aa-4735-9f8b-93312635a568"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""af0883c6-5e2a-46de-ad45-d33e0abcde75"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6262efdb-e113-4f19-9dcf-70fee4d011d2"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controle"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1291f51c-5209-48aa-866d-c3e2303980ab"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controle"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""366c1796-faaa-4149-99eb-6e52db4bd8b0"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controle"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc2e35ac-f476-413e-b032-80da795266b2"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controle"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controle"",
            ""bindingGroup"": ""Controle"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movimentacao
        m_Movimentacao = asset.FindActionMap("Movimentacao", throwIfNotFound: true);
        m_Movimentacao_WASD = m_Movimentacao.FindAction("WASD", throwIfNotFound: true);
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

    // Movimentacao
    private readonly InputActionMap m_Movimentacao;
    private IMovimentacaoActions m_MovimentacaoActionsCallbackInterface;
    private readonly InputAction m_Movimentacao_WASD;
    public struct MovimentacaoActions
    {
        private @Inputs m_Wrapper;
        public MovimentacaoActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_Movimentacao_WASD;
        public InputActionMap Get() { return m_Wrapper.m_Movimentacao; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovimentacaoActions set) { return set.Get(); }
        public void SetCallbacks(IMovimentacaoActions instance)
        {
            if (m_Wrapper.m_MovimentacaoActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_MovimentacaoActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_MovimentacaoActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_MovimentacaoActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_MovimentacaoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public MovimentacaoActions @Movimentacao => new MovimentacaoActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    private int m_ControleSchemeIndex = -1;
    public InputControlScheme ControleScheme
    {
        get
        {
            if (m_ControleSchemeIndex == -1) m_ControleSchemeIndex = asset.FindControlSchemeIndex("Controle");
            return asset.controlSchemes[m_ControleSchemeIndex];
        }
    }
    public interface IMovimentacaoActions
    {
        void OnWASD(InputAction.CallbackContext context);
    }
}
