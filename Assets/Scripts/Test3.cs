using UnityEngine;

public class Test3 : MonoBehaviour
{
    [HideInInspector]public float hiddenVariable = 1.0f;

    [SerializeField]private float serializePrivateVariable = 2.0f;

    [Space(30.0f)]public float spaceFloat = 10f;

    [Range(3f, 4f)]public float rangeFloat = 3.5f;

    [Header("Text Attributes")]public string headeredString = "headeredString";

    [TextArea(3, 6)]public string textArea = "Here is some text\nin a\ntext area";

    [Multiline(4)]public string multilineText = "Mult\ni\nline\ntext\nscroll\nto\nthis\ntext";

    [Tooltip("this variable is an interger")]public int tooltippedInteger = 9;

    // 鼠标右键点击，会有可执行的按钮，Output Value，点点击后，执行FieldContextFunction函数
    [ContextMenuItem("Output Value", "FieldContextFunction")]public float ContextFloat = 0.0f;

    private void FieldContextFunction()
    {
        Debug.Log(ContextFloat);
    }


    // 在Inspector中，Test3（Script）点击右键，会有一个Context Funtion按钮，点击后执行该函数
    [ContextMenu("Context Funtion")]
    public void ContextFunction()
    {
        Debug.Log("Context Function Activated!");
    }

}
