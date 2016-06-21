using UnityEngine;

public class IncrementableTest : MonoBehaviour
{
    [Incrementable(0.1f)] public float in1;

    [Incrementable(0.5f)] public float in2;

    [Incrementable(2f)] public int in3;


}
