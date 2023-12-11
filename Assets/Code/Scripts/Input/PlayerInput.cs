//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Code/Scripts/Input/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""GamePlayInput"",
            ""id"": ""974b49c0-b7b9-42b7-be48-03a16d065a17"",
            ""actions"": [
                {
                    ""name"": ""AxisRight"",
                    ""type"": ""Button"",
                    ""id"": ""9a318ad4-fb20-4d35-b188-365329940299"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AxisLeft"",
                    ""type"": ""Button"",
                    ""id"": ""78151019-c696-4965-8e94-eae2e5050dba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AxisUp"",
                    ""type"": ""Button"",
                    ""id"": ""7a3015ad-42ba-4ed1-a021-74042bcec637"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AxisDown"",
                    ""type"": ""Button"",
                    ""id"": ""696e1454-52f5-4b4c-a531-21d378044e0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JumpButton"",
                    ""type"": ""Button"",
                    ""id"": ""eea1be9f-0115-464f-949e-880180d18a71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""1bc23164-539b-4776-8cec-932083e5bc5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseButton"",
                    ""type"": ""Button"",
                    ""id"": ""81e1211d-eaf4-4a38-99c3-972e599490ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DebugButton"",
                    ""type"": ""Button"",
                    ""id"": ""7d769045-5ee2-40b9-a505-87a86aece778"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fed10233-3ffc-4b21-94d5-7d37bf1b6aa2"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68c0fa7c-51eb-4eee-a7ef-15735fcf8188"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b59b8851-2eac-4590-adf8-99b334744729"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00161008-8b1b-4a8b-ba65-1c18063fc4c0"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6101c1a9-5581-4549-a2be-735b2fb05959"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3a7410-da6b-4c0e-bf22-a8f10a4e129a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8510ba5-9a51-4cbc-b0db-e0a69c51e018"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf5ea2a8-7027-452b-8d21-b30e9128ba25"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02edad41-93a1-49d1-a713-7efc528a6d53"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a881cda-628e-476b-8413-348e84c09be3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db4b3170-cd3f-4b01-9e02-178d1aa639b7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f05093da-ea8b-4efe-bc20-4a9c823e958e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2569eb1-f83a-42e5-a780-e05183e946ab"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c04c5601-9813-477a-98c4-fdd5dc12237c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f72d10e-9361-4202-b2e7-68de74b86583"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af58ddf0-d9a6-4b29-abcd-d52ecabab3e1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00621e00-11f3-4ee7-afec-36be608be0dc"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a997ac9-698d-42b3-a3f3-11395a133791"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fd42233-5553-4f48-8492-02f26e9359e3"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b1bedf-4b7f-44e6-92dc-7d5cd9c1f38f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuInput"",
            ""id"": ""98875b80-f70b-4da7-8117-3628e9bfec7c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5593c474-7f42-4a6a-af12-8eb56c559e8f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""c1b495c4-ec6e-430e-af1c-e7cb3959dd21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""cebce569-a083-4740-8a9d-7670f14dd3c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""42d3dcdb-f003-43ca-a927-a8d1329e1240"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57a84a34-4e9b-4b86-b57f-ab8fe3ab30e7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9667e095-76c0-4c11-a51e-e22e970028b0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f51a6a2a-fc8d-4fc8-94e8-906ed8bcf167"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3660148a-1fb1-49f5-a284-4a86a510fd4d"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81b1e032-a97c-4631-926c-cc77dd246d40"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa440edd-8971-466b-a781-cefedab51af8"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8c40015-7b63-4b49-b670-29860c94c7d6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c0eb46fb-73fa-4a0e-b155-2bad1f94dc71"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4bca8af3-016d-4fdd-b739-d9cb7ac46bbb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7487b9f3-d043-4a28-b6d4-3c2b078c1854"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2719d74f-2900-45c8-805b-ca9bc1e06f5e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8cd08eb8-0a37-4833-8915-dae0960396fc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""98030aa8-e60e-42f0-9b08-cb389ca51f07"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""81e51b4c-f92e-4a4f-94a2-1a1399ab27c6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2221e9e4-74fc-48d8-b8c8-8c04dfc2846f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31671c84-b808-423a-95dc-d2c983493c2e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""670ec709-41e8-41f2-b800-37629a832efd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5ffe8c64-1614-4bf3-aa00-189492fce36e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8b7497d2-42e7-4097-822b-6330e65c587f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a6902a4b-a349-4f26-ac0e-d950d8173d6d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cc466ef4-e98b-4448-95c4-256a248775ea"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed81e742-7ea4-436b-8f0f-95d5958294e2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4fc0490a-26a7-42e3-bd1c-eec6673d7a85"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19739c76-fa04-44e2-b802-43be088fc523"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a52fbcb-52c3-48ee-baf6-33d226b0a3f8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8df267bd-1195-49ff-9297-c7ad80ddecee"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlayInput
        m_GamePlayInput = asset.FindActionMap("GamePlayInput", throwIfNotFound: true);
        m_GamePlayInput_AxisRight = m_GamePlayInput.FindAction("AxisRight", throwIfNotFound: true);
        m_GamePlayInput_AxisLeft = m_GamePlayInput.FindAction("AxisLeft", throwIfNotFound: true);
        m_GamePlayInput_AxisUp = m_GamePlayInput.FindAction("AxisUp", throwIfNotFound: true);
        m_GamePlayInput_AxisDown = m_GamePlayInput.FindAction("AxisDown", throwIfNotFound: true);
        m_GamePlayInput_JumpButton = m_GamePlayInput.FindAction("JumpButton", throwIfNotFound: true);
        m_GamePlayInput_ActionButton = m_GamePlayInput.FindAction("ActionButton", throwIfNotFound: true);
        m_GamePlayInput_PauseButton = m_GamePlayInput.FindAction("PauseButton", throwIfNotFound: true);
        m_GamePlayInput_DebugButton = m_GamePlayInput.FindAction("DebugButton", throwIfNotFound: true);
        // MenuInput
        m_MenuInput = asset.FindActionMap("MenuInput", throwIfNotFound: true);
        m_MenuInput_Move = m_MenuInput.FindAction("Move", throwIfNotFound: true);
        m_MenuInput_Submit = m_MenuInput.FindAction("Submit", throwIfNotFound: true);
        m_MenuInput_Cancel = m_MenuInput.FindAction("Cancel", throwIfNotFound: true);
        m_MenuInput_Close = m_MenuInput.FindAction("Close", throwIfNotFound: true);
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

    // GamePlayInput
    private readonly InputActionMap m_GamePlayInput;
    private List<IGamePlayInputActions> m_GamePlayInputActionsCallbackInterfaces = new List<IGamePlayInputActions>();
    private readonly InputAction m_GamePlayInput_AxisRight;
    private readonly InputAction m_GamePlayInput_AxisLeft;
    private readonly InputAction m_GamePlayInput_AxisUp;
    private readonly InputAction m_GamePlayInput_AxisDown;
    private readonly InputAction m_GamePlayInput_JumpButton;
    private readonly InputAction m_GamePlayInput_ActionButton;
    private readonly InputAction m_GamePlayInput_PauseButton;
    private readonly InputAction m_GamePlayInput_DebugButton;
    public struct GamePlayInputActions
    {
        private @PlayerInput m_Wrapper;
        public GamePlayInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AxisRight => m_Wrapper.m_GamePlayInput_AxisRight;
        public InputAction @AxisLeft => m_Wrapper.m_GamePlayInput_AxisLeft;
        public InputAction @AxisUp => m_Wrapper.m_GamePlayInput_AxisUp;
        public InputAction @AxisDown => m_Wrapper.m_GamePlayInput_AxisDown;
        public InputAction @JumpButton => m_Wrapper.m_GamePlayInput_JumpButton;
        public InputAction @ActionButton => m_Wrapper.m_GamePlayInput_ActionButton;
        public InputAction @PauseButton => m_Wrapper.m_GamePlayInput_PauseButton;
        public InputAction @DebugButton => m_Wrapper.m_GamePlayInput_DebugButton;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayInputActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayInputActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayInputActionsCallbackInterfaces.Add(instance);
            @AxisRight.started += instance.OnAxisRight;
            @AxisRight.performed += instance.OnAxisRight;
            @AxisRight.canceled += instance.OnAxisRight;
            @AxisLeft.started += instance.OnAxisLeft;
            @AxisLeft.performed += instance.OnAxisLeft;
            @AxisLeft.canceled += instance.OnAxisLeft;
            @AxisUp.started += instance.OnAxisUp;
            @AxisUp.performed += instance.OnAxisUp;
            @AxisUp.canceled += instance.OnAxisUp;
            @AxisDown.started += instance.OnAxisDown;
            @AxisDown.performed += instance.OnAxisDown;
            @AxisDown.canceled += instance.OnAxisDown;
            @JumpButton.started += instance.OnJumpButton;
            @JumpButton.performed += instance.OnJumpButton;
            @JumpButton.canceled += instance.OnJumpButton;
            @ActionButton.started += instance.OnActionButton;
            @ActionButton.performed += instance.OnActionButton;
            @ActionButton.canceled += instance.OnActionButton;
            @PauseButton.started += instance.OnPauseButton;
            @PauseButton.performed += instance.OnPauseButton;
            @PauseButton.canceled += instance.OnPauseButton;
            @DebugButton.started += instance.OnDebugButton;
            @DebugButton.performed += instance.OnDebugButton;
            @DebugButton.canceled += instance.OnDebugButton;
        }

        private void UnregisterCallbacks(IGamePlayInputActions instance)
        {
            @AxisRight.started -= instance.OnAxisRight;
            @AxisRight.performed -= instance.OnAxisRight;
            @AxisRight.canceled -= instance.OnAxisRight;
            @AxisLeft.started -= instance.OnAxisLeft;
            @AxisLeft.performed -= instance.OnAxisLeft;
            @AxisLeft.canceled -= instance.OnAxisLeft;
            @AxisUp.started -= instance.OnAxisUp;
            @AxisUp.performed -= instance.OnAxisUp;
            @AxisUp.canceled -= instance.OnAxisUp;
            @AxisDown.started -= instance.OnAxisDown;
            @AxisDown.performed -= instance.OnAxisDown;
            @AxisDown.canceled -= instance.OnAxisDown;
            @JumpButton.started -= instance.OnJumpButton;
            @JumpButton.performed -= instance.OnJumpButton;
            @JumpButton.canceled -= instance.OnJumpButton;
            @ActionButton.started -= instance.OnActionButton;
            @ActionButton.performed -= instance.OnActionButton;
            @ActionButton.canceled -= instance.OnActionButton;
            @PauseButton.started -= instance.OnPauseButton;
            @PauseButton.performed -= instance.OnPauseButton;
            @PauseButton.canceled -= instance.OnPauseButton;
            @DebugButton.started -= instance.OnDebugButton;
            @DebugButton.performed -= instance.OnDebugButton;
            @DebugButton.canceled -= instance.OnDebugButton;
        }

        public void RemoveCallbacks(IGamePlayInputActions instance)
        {
            if (m_Wrapper.m_GamePlayInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayInputActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayInputActions @GamePlayInput => new GamePlayInputActions(this);

    // MenuInput
    private readonly InputActionMap m_MenuInput;
    private List<IMenuInputActions> m_MenuInputActionsCallbackInterfaces = new List<IMenuInputActions>();
    private readonly InputAction m_MenuInput_Move;
    private readonly InputAction m_MenuInput_Submit;
    private readonly InputAction m_MenuInput_Cancel;
    private readonly InputAction m_MenuInput_Close;
    public struct MenuInputActions
    {
        private @PlayerInput m_Wrapper;
        public MenuInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MenuInput_Move;
        public InputAction @Submit => m_Wrapper.m_MenuInput_Submit;
        public InputAction @Cancel => m_Wrapper.m_MenuInput_Cancel;
        public InputAction @Close => m_Wrapper.m_MenuInput_Close;
        public InputActionMap Get() { return m_Wrapper.m_MenuInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuInputActions set) { return set.Get(); }
        public void AddCallbacks(IMenuInputActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuInputActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Submit.started += instance.OnSubmit;
            @Submit.performed += instance.OnSubmit;
            @Submit.canceled += instance.OnSubmit;
            @Cancel.started += instance.OnCancel;
            @Cancel.performed += instance.OnCancel;
            @Cancel.canceled += instance.OnCancel;
            @Close.started += instance.OnClose;
            @Close.performed += instance.OnClose;
            @Close.canceled += instance.OnClose;
        }

        private void UnregisterCallbacks(IMenuInputActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Submit.started -= instance.OnSubmit;
            @Submit.performed -= instance.OnSubmit;
            @Submit.canceled -= instance.OnSubmit;
            @Cancel.started -= instance.OnCancel;
            @Cancel.performed -= instance.OnCancel;
            @Cancel.canceled -= instance.OnCancel;
            @Close.started -= instance.OnClose;
            @Close.performed -= instance.OnClose;
            @Close.canceled -= instance.OnClose;
        }

        public void RemoveCallbacks(IMenuInputActions instance)
        {
            if (m_Wrapper.m_MenuInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuInputActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuInputActions @MenuInput => new MenuInputActions(this);
    public interface IGamePlayInputActions
    {
        void OnAxisRight(InputAction.CallbackContext context);
        void OnAxisLeft(InputAction.CallbackContext context);
        void OnAxisUp(InputAction.CallbackContext context);
        void OnAxisDown(InputAction.CallbackContext context);
        void OnJumpButton(InputAction.CallbackContext context);
        void OnActionButton(InputAction.CallbackContext context);
        void OnPauseButton(InputAction.CallbackContext context);
        void OnDebugButton(InputAction.CallbackContext context);
    }
    public interface IMenuInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnClose(InputAction.CallbackContext context);
    }
}
