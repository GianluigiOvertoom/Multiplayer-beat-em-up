using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binding
{
    public string KeyboardPath;
    public string GamepadPath;

    public Binding(string keyboardPath, string gamepadPath)
    {
        KeyboardPath = keyboardPath;
        GamepadPath = gamepadPath;
    }
}
