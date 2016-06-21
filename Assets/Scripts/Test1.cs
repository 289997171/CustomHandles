using System;
using UnityEngine;
using System.Collections;


[Serializable]
public class PlayerStates
{
    public float moveSpeed = 1.0f;
    public float turnSpee = 90.0f;
}

public class Test1 : MonoBehaviour {

    //public float moveSpeed = 1.0f;
    //public float turnSpee = 90.0f;

    public PlayerStates PlayerStates;

    public string other;
}
