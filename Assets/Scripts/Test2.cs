using UnityEngine;

public class Test2 : MonoBehaviour
{
    public float hiddenVariable = 1.0f;

    private float serializePrivateVariable = 2.0f;

    public float spaceFloat = 10f;

    public float rangeFloat = 3.5f;

    public string headeredString = "headeredString";

    public string textArea = "Here is some text\nin a\ntext area";

    public string multilineText = "Mult\ni\nline\ntext\nscroll\nto\nthis\ntext";

    public int tooltippedInteger = 9;

    public float ContextFloat = 0.0f;

    private void FieldContextFunction()
    {
        Debug.Log(ContextFloat);
    }

    public void ContextFunction()
    {
        Debug.Log("Context Function Activated!");
    }

}
