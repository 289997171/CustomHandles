using UnityEditor;
using UnityEngine;

namespace Editor
{

    /// <summary>
    /// 对应[Angle(bool)]注解功能
    /// </summary>
    [CustomPropertyDrawer(typeof(AngleAttribute))]
    public class AngleAttributeDrawer : PropertyDrawer
    {

        // 获得注解
        private AngleAttribute angleAttribute = null;

        private AngleAttribute attributeValue
        {
            get
            {
                if (angleAttribute == null)
                {
                    angleAttribute = (AngleAttribute) attribute;
                }
                return angleAttribute;
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // 显示默认的属性编辑器
            EditorGUI.PropertyField(position, property);

            // 根据注解内容处理属性值
            clampAngle(property);
        }

        private void clampAngle(SerializedProperty property)
        {
            if (property == null)
                return;

            float fullRotation = (attributeValue.radians ? Mathf.PI*2f : 360f);
            while (property.floatValue < 0f)
            {
                property.floatValue += fullRotation;
            }

            while (property.floatValue > fullRotation)
            {
                property.floatValue -= fullRotation;
            }
        }
    }
}