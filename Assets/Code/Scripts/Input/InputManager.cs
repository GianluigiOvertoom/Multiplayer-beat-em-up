using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public enum ButtonAction 
{
    JumpButton,
    ActionButton
}

public class Input
{
    public static PlayerInput PlayerInputActions;
    public struct IButtonState
    {
        public bool pressed;
        public bool held;
        public bool released;
    }

    public static int AxisLeft;
    public static int AxisRight;
    public static int AxisUp;
    public static int AxisDown;

    static bool jButton;

    public static IButtonState JumpButton;
    public static IButtonState ActionButton;
    public static IButtonState PauseButton;

    public static IButtonState SubmitButton;
    public static IButtonState CancelButton;

    /*private static InputAction _jumpInput;
    private static InputAction _actionInput;*/

    private static Binding _defaultJumpBinding;

    public static void Enable()
    {
        PlayerInputActions = new PlayerInput();

        PlayerInputActions.GamePlayInput.AxisLeft.started += XAxisNegative => GetLeftAxis();
        PlayerInputActions.GamePlayInput.AxisLeft.canceled += XAxisNegative => GetLeftAxisUp();

        PlayerInputActions.GamePlayInput.AxisRight.started += XAxisPositive => GetRightAxis();
        PlayerInputActions.GamePlayInput.AxisRight.canceled += XAxisPositive => GetRightAxisUp();

        PlayerInputActions.GamePlayInput.AxisUp.started += YAxisPositive => GetUpAxis();
        PlayerInputActions.GamePlayInput.AxisUp.canceled += YAxisPositive => GetUpAxisUp();

        PlayerInputActions.GamePlayInput.AxisDown.started += YAxisNegative => GetDownAxis();
        PlayerInputActions.GamePlayInput.AxisDown.canceled += YAxisNegative => GetDownAxisUp();

        PlayerInputActions.GamePlayInput.JumpButton.started += Pause => JumpButton.held = GetButton();
        PlayerInputActions.GamePlayInput.JumpButton.canceled += Pause => JumpButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.JumpButton.started += Pause => GetButtonJumpDown();
        PlayerInputActions.GamePlayInput.JumpButton.canceled += Pause => GetButtonJumpUp();

        PlayerInputActions.GamePlayInput.ActionButton.started += Pause => ActionButton.held = GetButton();
        PlayerInputActions.GamePlayInput.ActionButton.canceled += Pause => ActionButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.ActionButton.started += Pause => GetButtonActionDown();
        PlayerInputActions.GamePlayInput.ActionButton.canceled += Pause => GetButtonActionUp();

        /*_jumpInput.started += Jump => JumpButton.held = GetButton();
        _jumpInput.canceled += Jump => JumpButton.held = GetButtonUp();
        _jumpInput.started += Jump => GetButtonJumpDown();
        _jumpInput.canceled += Jump => GetButtonJumpUp();

        _actionInput.started += Action => ActionButton.held = GetButton();
        _actionInput.canceled += Action => ActionButton.held = GetButtonUp();
        _actionInput.started += Action => GetButtonActionDown();
        _actionInput.canceled += Action => GetButtonActionUp();*/

        PlayerInputActions.GamePlayInput.PauseButton.started += Pause => PauseButton.held = GetButton();
        PlayerInputActions.GamePlayInput.PauseButton.canceled += Pause => PauseButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.PauseButton.started += Pause => GetPauseButtonDown();
        PlayerInputActions.GamePlayInput.PauseButton.canceled += Pause => GetPauseButtonUp();

        PlayerInputActions.MenuInput.Submit.started += Pause => SubmitButton.held = GetButton();
        PlayerInputActions.MenuInput.Submit.canceled += Pause => SubmitButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Submit.started += Pause => GetSubmitButtonDown();
        PlayerInputActions.MenuInput.Submit.canceled += Pause => GetSubmitButtonUp();

        PlayerInputActions.MenuInput.Cancel.started += Pause => CancelButton.held = GetButton();
        PlayerInputActions.MenuInput.Cancel.canceled += Pause => CancelButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Cancel.started += Pause => GetCancelButtonDown();
        PlayerInputActions.MenuInput.Cancel.canceled += Pause => GetCancelButtonUp();

        PlayerInputActions.MenuInput.Enable();
    }
    public static void EnableMenuInput() => PlayerInputActions.MenuInput.Enable();
    public static void DisableMenuInput() => PlayerInputActions.MenuInput.Disable();
    public static void EnableGamePlayInput() => PlayerInputActions.GamePlayInput.Enable();
    public static void DisableGameplayInput() => PlayerInputActions.GamePlayInput.Disable();

    /// <summary>
    /// Bindings
    /// </summary>
    private static void GetLeftAxis() => AxisLeft = 1;
    private static void GetLeftAxisUp() => AxisLeft = 0;
    private static void GetRightAxis() => AxisRight = 1;
    private static void GetRightAxisUp() => AxisRight = 0;

    private static void GetUpAxis() => AxisUp = 1;
    private static void GetUpAxisUp() => AxisUp = 0;
    private static void GetDownAxis() => AxisDown = 1;
    private static void GetDownAxisUp() => AxisDown = 0;

    private static bool GetButton() { return true; }
    private static bool GetButtonUp() { return false; }
    public static async void GetButtonJumpDown()
    {   
        JumpButton.pressed = true;
        await Task.Yield();
        JumpButton.pressed = false;
    }
    public static async void GetButtonJumpUp()
    {
        JumpButton.released = true;
        await Task.Yield();
        JumpButton.released = false;
    }
    public static async void GetButtonActionDown()
    {
        ActionButton.pressed = true;
        await Task.Yield();
        ActionButton.pressed = false;
    }
    public static async void GetButtonActionUp()
    {
        ActionButton.released = true;
        await Task.Yield();
        ActionButton.released = false;
    }
    public static async void GetPauseButtonDown()
    {
        PauseButton.pressed = true;
        await Task.Yield();
        PauseButton.pressed = false;
    }
    public static async void GetPauseButtonUp()
    {
        PauseButton.released = true;
        await Task.Yield();
        PauseButton.released = false;
    }
    public static async void GetSubmitButtonDown()
    {
        SubmitButton.pressed = true;
        await Task.Yield();
        SubmitButton.pressed = false;
    }
    public static async void GetSubmitButtonUp()
    {
        SubmitButton.released = true;
        await Task.Yield();
        SubmitButton.released = false;
    }
    public static async void GetCancelButtonDown()
    {
        CancelButton.pressed = true;
        await Task.Yield();
        CancelButton.pressed = false;
    }
    public static async void GetCancelButtonUp()
    {
        CancelButton.released = true;
        await Task.Yield();
        CancelButton.released = false;
    }
}
