
using UnityEngine;
using System;

[Serializable]
public class BoolVector3 
    // : PropertyAttribute // 可以不继承于PropertyAttribute。如果继承PropertyAttribute，BoolVector3Drawer可以使用BoolVector3 boolVector3 = attribute as BoolVector3;
{
    public bool x;
    public bool y;
    public bool z;

    public BoolVector3()
    {
    }

    public BoolVector3(bool x, bool y, bool z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}

public class Test4 : MonoBehaviour
{
    public BoolVector3 vec;

}
