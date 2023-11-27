# Beat'em-up Project

## Installations
Unity version: 2022.3.14f1.<br />
Unity packages:
* 2D Package
  * 2D Sprite
  * 2D Pixel Perfect
* Input system
* Cinemachine
* Universal RP
* Probuilder
* Netcode for GameObjects
* Relay

## Coding conventions

Namespaces are all PascalCase.
* _Bad:_
``` csharp
avangarde.currentgame.ui.mainmenu
```
* _Good:_
``` csharp
Avangarde.CurrentGame.UI.MainMenu
```
<br />

Classes & Methods are all PascalCase.
* _Bad:_
``` csharp
public class myclass
{
  public void somemethod{}
}
```
* _Good:_
``` csharp
public class MyClass
{
  public void SomeMethod{}
}
```
<br />

Static Fields should be PascalCase.
* _Bad:_
``` csharp
public static int _someStaticValue = 10;
```
* _Good:_
``` csharp
public static int SomeStaticValue = 10;
```
<br />

Properties are PascalCase.
* _Bad:_
``` csharp
private string _name;
public string name
{
  get
  {
    return _name;
  }
  set
  {
    _name = value;
  }
}
```
* _Good:_
``` csharp
private string name;
public string Name
  {
  get
  {
    return name;
  }
  set
  {
    name = value;
  }
}
```
<br />

Parameters should be camelCase.
* _Bad:_
``` csharp
public void HighlightElement(bool SomeCondition)
```
* _Good:_
``` csharp
public void HighlightElement(bool someCondition)
```
<br />

## Best practices

Always use access level modifiers.
* _Bad:_
``` csharp
int privateVariable;  
```
* _Good:_
``` csharp
private int privateVariable;
```
<br />

Always use access level modifiers.
* _Bad:_
``` csharp
private int firstVariable, secondVariable;
```
* _Good:_
``` csharp
private int firstVariable;
private int secondVariable;
```
<br />

Preface interfaces with a I.
* _Bad:_
``` csharp
PointerDown
```
* _Good:_
``` csharp
IPointerDown
```
<br />

Brace style
* _Bad:_
``` csharp
public void CreateSomething(){
  // code
}
```
* _Good:_
``` csharp
public void CreateSomething()
{
  // code
}
```
<br />

Sources:
https://avangarde-software.com/unity-coding-guidelines-basic-best-practices/
