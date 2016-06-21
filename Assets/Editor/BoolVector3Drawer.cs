using UnityEditor;
using UnityEngine;

namespace Editor
{

    /// <summary>
    /// 必须放入Editor文件夹下
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolVector3))]
    public class BoolVector3Drawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // BoolVector3 boolVector3 = attribute as BoolVector3;

            // 获得需要的属性
            SerializedProperty x = property.FindPropertyRelative("x");
            SerializedProperty y = property.FindPropertyRelative("y");
            SerializedProperty z = property.FindPropertyRelative("z");

            // 单个属性的宽度
            float propWith = position.width/6;

            CreateItem(x, 0, propWith, position, "x:");
            CreateItem(y, 1, propWith, position, "y:");
            CreateItem(z, 2, propWith, position, "z:");
        }


        private void CreateItem(SerializedProperty p, int index, float propWith, Rect postion, string content)
        {
            //1.创建属性描述
            EditorGUI.LabelField(new Rect(postion.x + index * 2 * propWith, postion.y, propWith, postion.height), content);
            //2.创建属性编辑框
            p.boolValue = EditorGUI.Toggle(new Rect(postion.x + (index * 2 + 1) * propWith, postion.y, propWith, postion.height), p.boolValue);
        }
    }
}