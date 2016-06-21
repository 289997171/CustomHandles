using UnityEngine;

public class IncrementableAttribute : PropertyAttribute
{
    public readonly float incrementBy;

    public IncrementableAttribute(float incrementBy)
    {
        this.incrementBy = incrementBy;
    }
}
