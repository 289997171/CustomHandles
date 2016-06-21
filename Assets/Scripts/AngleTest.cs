using UnityEngine;
public class AngleTest : MonoBehaviour
{

    // 由于该值是[Angle(true)]，顾其只位于 0 ~ 3.14 * 2
    [Angle(true)] public float AngleRadians = 0f;

    // 由于该值是[Angle(false)]，顾其只位于 0 ~ 360
    [Angle(false)] public float AngleDegrees = 0f;
}
