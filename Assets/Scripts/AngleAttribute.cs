using UnityEngine;


/// <summary>
/// 定义一个 [Angle(bool)] 的注解
/// </summary>
public class AngleAttribute : PropertyAttribute
{
    public readonly bool radians;

    public AngleAttribute(bool radians)
    {
        this.radians = radians;
    }

}
