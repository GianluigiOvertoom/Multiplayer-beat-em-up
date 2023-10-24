using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public enum ButtonAction 
{
    JumpButton,
    ActionButton
}

public class Input
{
    public static PlayerInput PlayerInputActions;
    //public static Rumble RumbleRef;
    public struct IButtonState
    {
        public bool pressed;
        public bool held;
        public bool released;
    }

    //Axis bindings
    public static int AxisLeft;
    public static int AxisRight;
    public static int AxisUp;
    public static int AxisDown;

    public static Vector2 MoveAxes;
    //Gameplay bindings
    //
    public static IButtonState JumpButton;
    public static IButtonState AttackButton;
    public static IButtonState SpecialButton;
    public static IButtonState BlockButton;
    //Menu bindings
    //
    public static IButtonState PauseButton;
    public static IButtonState SubmitButton;
    public static IButtonState CancelButton;
    public static IButtonState CloseButton;


    private static InputAction _actionInput;

    //private static Binding _defaultJumpBinding;

    public static void BindInput()
    {
        PlayerInputActions = new PlayerInput();
        //LoadBindings();

        PlayerInputActions.GamePlayInput.AxisLeft.started += XAxisNegative => GetLeftAxis();
        PlayerInputActions.GamePlayInput.AxisLeft.canceled += XAxisNegative => GetLeftAxisUp();

        PlayerInputActions.GamePlayInput.AxisRight.started += XAxisPositive => GetRightAxis();
        PlayerInputActions.GamePlayInput.AxisRight.canceled += XAxisPositive => GetRightAxisUp();

        PlayerInputActions.GamePlayInput.AxisUp.started += YAxisPositive => GetUpAxis();
        PlayerInputActions.GamePlayInput.AxisUp.canceled += YAxisPositive => GetUpAxisUp();

        PlayerInputActions.GamePlayInput.AxisDown.started += YAxisNegative => GetDownAxis();
        PlayerInputActions.GamePlayInput.AxisDown.canceled += YAxisNegative => GetDownAxisUp();

        PlayerInputActions.GamePlayInput.JumpButton.started += Jump => JumpButton.held = GetButton();
        PlayerInputActions.GamePlayInput.JumpButton.canceled += Jump => JumpButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.JumpButton.started += Jump => GetButtonJumpDown();
        PlayerInputActions.GamePlayInput.JumpButton.canceled += Jump => GetButtonJumpUp();

        PlayerInputActions.GamePlayInput.AttackButton.started += Attack => AttackButton.held = GetButton();
        PlayerInputActions.GamePlayInput.AttackButton.canceled += Attack => AttackButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.AttackButton.started += Attack => GetButtonAttackDown();
        PlayerInputActions.GamePlayInput.AttackButton.canceled += Attack => GetButtonAttackUp();

        PlayerInputActions.GamePlayInput.SpecialButton.started += Special => SpecialButton.held = GetButton();
        PlayerInputActions.GamePlayInput.SpecialButton.canceled += Special => SpecialButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.SpecialButton.started += Special => GetButtonSpecialDown();
        PlayerInputActions.GamePlayInput.SpecialButton.canceled += Special => GetButtonSpecialUp();

        PlayerInputActions.GamePlayInput.BlockButton.started += Block => BlockButton.held = GetButton();
        PlayerInputActions.GamePlayInput.BlockButton.canceled += Block => BlockButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.BlockButton.started += Block => GetButtonBlockDown();
        PlayerInputActions.GamePlayInput.BlockButton.canceled += Block => GetButtonBlockUp();

        /*_actionInput.started += Action => ActionButton.held = GetButton();
        _actionInput.canceled += Action => ActionButton.held = GetButtonUp();
        _actionInput.started += Action => GetButtonActionDown();
        _actionInput.canceled += Action => GetButtonActionUp();*/

        //Menu Input
        //
        PlayerInputActions.MenuInput.Move.performed += moveAxes => MoveAxes = moveAxes.ReadValue<Vector2>();

        PlayerInputActions.MenuInput.PauseButton.started += Pause => PauseButton.held = GetButton();
        PlayerInputActions.MenuInput.PauseButton.canceled += Pause => PauseButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.PauseButton.started += Pause => GetPauseButtonDown();
        PlayerInputActions.MenuInput.PauseButton.canceled += Pause => GetPauseButtonUp();

        PlayerInputActions.MenuInput.Submit.started += Submit => SubmitButton.held = GetButton();
        PlayerInputActions.MenuInput.Submit.canceled += Submit => SubmitButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Submit.started += Submit => GetSubmitButtonDown();
        PlayerInputActions.MenuInput.Submit.canceled += Submit => GetSubmitButtonUp();

        PlayerInputActions.MenuInput.Cancel.started += Cancel => CancelButton.held = GetButton();
        PlayerInputActions.MenuInput.Cancel.canceled += Cancel => CancelButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Cancel.started += Cancel => GetCancelButtonDown();
        PlayerInputActions.MenuInput.Cancel.canceled += Cancel => GetCancelButtonUp();

        PlayerInputActions.MenuInput.Close.started += Close => CloseButton.held = GetButton();
        PlayerInputActions.MenuInput.Close.canceled += Close => CloseButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Close.started += Close => GetCloseButtonDown();
        PlayerInputActions.MenuInput.Close.canceled += Close => GetCloseButtonUp();
    }

    public static void UnbindInput()
    {
        PlayerInputActions.GamePlayInput.AxisLeft.started -= XAxisNegative => GetLeftAxis();
        PlayerInputActions.GamePlayInput.AxisLeft.canceled -= XAxisNegative => GetLeftAxisUp();

        PlayerInputActions.GamePlayInput.AxisRight.started -= XAxisPositive => GetRightAxis();
        PlayerInputActions.GamePlayInput.AxisRight.canceled -= XAxisPositive => GetRightAxisUp();

        PlayerInputActions.GamePlayInput.AxisUp.started -= YAxisPositive => GetUpAxis();
        PlayerInputActions.GamePlayInput.AxisUp.canceled -= YAxisPositive => GetUpAxisUp();

        PlayerInputActions.GamePlayInput.AxisDown.started -= YAxisNegative => GetDownAxis();
        PlayerInputActions.GamePlayInput.AxisDown.canceled -= YAxisNegative => GetDownAxisUp();

        PlayerInputActions.GamePlayInput.JumpButton.started -= Jump => JumpButton.held = GetButton();
        PlayerInputActions.GamePlayInput.JumpButton.canceled -= Jump => JumpButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.JumpButton.started -= Jump => GetButtonJumpDown();
        PlayerInputActions.GamePlayInput.JumpButton.canceled -= Jump => GetButtonJumpUp();

        PlayerInputActions.GamePlayInput.AttackButton.started -= Attack => AttackButton.held = GetButton();
        PlayerInputActions.GamePlayInput.AttackButton.canceled -= Attack => AttackButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.AttackButton.started -= Attack => GetPauseButtonDown();
        PlayerInputActions.GamePlayInput.AttackButton.canceled -= Attack => GetPauseButtonUp();

        PlayerInputActions.GamePlayInput.SpecialButton.started -= Special => SpecialButton.held = GetButton();
        PlayerInputActions.GamePlayInput.SpecialButton.canceled -= Special => SpecialButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.SpecialButton.started -= Special => GetPauseButtonDown();
        PlayerInputActions.GamePlayInput.SpecialButton.canceled -= Special => GetPauseButtonUp();

        PlayerInputActions.GamePlayInput.BlockButton.started -= Block => BlockButton.held = GetButton();
        PlayerInputActions.GamePlayInput.BlockButton.canceled -= Block => BlockButton.held = GetButtonUp();
        PlayerInputActions.GamePlayInput.BlockButton.started -= Block => GetPauseButtonDown();
        PlayerInputActions.GamePlayInput.BlockButton.canceled -= Block => GetPauseButtonUp();
        //Menu Input
        //
        PlayerInputActions.MenuInput.Move.performed -= moveAxes => MoveAxes = moveAxes.ReadValue<Vector2>();

        PlayerInputActions.MenuInput.PauseButton.started -= Pause => PauseButton.held = GetButton();
        PlayerInputActions.MenuInput.PauseButton.canceled -= Pause => PauseButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.PauseButton.started -= Pause => GetPauseButtonDown();
        PlayerInputActions.MenuInput.PauseButton.canceled -= Pause => GetPauseButtonUp();

        PlayerInputActions.MenuInput.Submit.started -= Submit => SubmitButton.held = GetButton();
        PlayerInputActions.MenuInput.Submit.canceled -= Submit => SubmitButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Submit.started -= Submit => GetSubmitButtonDown();
        PlayerInputActions.MenuInput.Submit.canceled -= Submit => GetSubmitButtonUp();

        PlayerInputActions.MenuInput.Cancel.started -= Cancel => CancelButton.held = GetButton();
        PlayerInputActions.MenuInput.Cancel.canceled -= Cancel => CancelButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Cancel.started -= Cancel => GetCancelButtonDown();
        PlayerInputActions.MenuInput.Cancel.canceled -= Cancel => GetCancelButtonUp();

        PlayerInputActions.MenuInput.Close.started -= Close => CloseButton.held = GetButton();
        PlayerInputActions.MenuInput.Close.canceled -= Close => CloseButton.held = GetButtonUp();
        PlayerInputActions.MenuInput.Close.started -= Close => GetCloseButtonDown();
        PlayerInputActions.MenuInput.Close.canceled -= Close => GetCloseButtonUp();
    }

    public static void EnableMenuInput() => PlayerInputActions.MenuInput.Enable();
    public static void DisableMenuInput() => PlayerInputActions.MenuInput.Disable();
    public static void EnableGamePlayInput() => PlayerInputActions.GamePlayInput.Enable();
    public static void DisableGameplayInput() => PlayerInputActions.GamePlayInput.Disable();

    /// <summary>
    /// state bindings
    /// </summary>
    private static bool GetButton() { return true; }
    private static bool GetButtonUp() { return false; }
    #region Axes input state
    private static void GetLeftAxis() => AxisLeft = 1;
    private static void GetLeftAxisUp() => AxisLeft = 0;
    private static void GetRightAxis() => AxisRight = 1;
    private static void GetRightAxisUp() => AxisRight = 0;

    private static void GetUpAxis() => AxisUp = 1;
    private static void GetUpAxisUp() => AxisUp = 0;
    private static void GetDownAxis() => AxisDown = 1;
    private static void GetDownAxisUp() => AxisDown = 0;
    #endregion
    #region Gameplay input state
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
    public static async void GetButtonAttackDown()
    {
        AttackButton.pressed = true;
        await Task.Yield();
        AttackButton.pressed = false;
    }
    public static async void GetButtonAttackUp()
    {
        AttackButton.released = true;
        await Task.Yield();
        AttackButton.released = false;
    }
    public static async void GetButtonSpecialDown()
    {
        SpecialButton.pressed = true;
        await Task.Yield();
        SpecialButton.pressed = false;
    }
    public static async void GetButtonSpecialUp()
    {
        SpecialButton.released = true;
        await Task.Yield();
        SpecialButton.released = false;
    }
    public static async void GetButtonBlockDown()
    {
        BlockButton.pressed = true;
        await Task.Yield();
        BlockButton.pressed = false;
    }
    public static async void GetButtonBlockUp()
    {
        BlockButton.released = true;
        await Task.Yield();
        BlockButton.released = false;
    }
    #endregion
    #region Menu input state
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
    public static async void GetCloseButtonDown()
    {
        CloseButton.pressed = true;
        await Task.Yield();
        CloseButton.pressed = false;
    }
    public static async void GetCloseButtonUp()
    {
        CloseButton.released = true;
        await Task.Yield();
        CloseButton.released = false;
    }
    #endregion
    /// <summary>
    /// Rebind functions
    /// </summary>
    public static void LoadBindings()
    {
        //_jumpInput = SetInputAction(_jumpInput, SettingsData.JumpBinding, PlayerInputActions.GamePlayInput.JumpButton);
        //_actionInput = SetInputAction(_actionInput, SettingsData.ActionBinding, PlayerInputActions.GamePlayInput.AttackButton);

    }
    /*private static InputAction SetInputAction(InputAction action, Binding binding, InputAction defaultAction)
    {
        action = defaultAction;
        action.ApplyBindingOverride(0, (binding.KeyboardPath != string.Empty) ? binding.KeyboardPath : defaultAction.bindings[0].path);
        action.ApplyBindingOverride(1, (binding.GamepadPath != string.Empty) ? binding.GamepadPath : defaultAction.bindings[1].path);
        return action;
    }*/
    public static void ResetBindings() 
    {
        //SettingsData.DefaultControlsData();
        LoadBindings();
    }
    /*public static void OverwriteBindings()
    {
        Binding jumpBinding = SettingsData.JumpBinding;
        _jumpAction = SetInputAction(jumpBinding.KeyboardPath, jumpBinding.GampadPath);
        Binding actionBinding = SettingsData.ActionBinding;
        _actionButton = SetInputAction(actionBinding.KeyboardPath, actionBinding.GampadPath);
    }
    private static Binding SetDefaultBinding(InputAction action)
    {
        return new Binding(action.bindings[0].path, action.bindings[1].path);
    }*/
}
