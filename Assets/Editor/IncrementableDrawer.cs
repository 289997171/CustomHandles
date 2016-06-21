using UnityEditor;
using UnityEngine;

namespace Editor
{

    [CustomPropertyDrawer(typeof(IncrementableAttribute))]
    public class IncrementableDrawer : PropertyDrawer
    {
        private IncrementableAttribute _incrementableAttribute = null;

        private IncrementableAttribute incrementableAttribute
        {
            get
            {
                if (_incrementableAttribute == null)
                {
                    _incrementableAttribute = (IncrementableAttribute)attribute;
                }
                return _incrementableAttribute;
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // 定义按钮的宽度
            int buttonWidth = 40;

            // -1 为减法， 1 为加法
            int SubOrAdd = 0;

            // 创建减法按钮
            if (GUI.Button(new Rect(position.x, position.y, buttonWidth, position.height), "(-" + incrementableAttribute.incrementBy + ")"))
            {
                SubOrAdd = -1;
            }

            // 创建加法按钮
            if (GUI.Button(new Rect(position.width - buttonWidth, position.y, buttonWidth, position.height), "(+" + incrementableAttribute.incrementBy + ")"))
            {
                SubOrAdd = +1;
            }

            // 是浮点类型
            if (property.propertyType == SerializedPropertyType.Float)
            {
                if (SubOrAdd == -1)
                {
                    property.floatValue -= incrementableAttribute.incrementBy;
                } else if (SubOrAdd == +1)
                {
                    property.floatValue += incrementableAttribute.incrementBy;
                }

                EditorGUI.LabelField(new Rect(position.x + buttonWidth, position.y, position.width - buttonWidth * 2, position.height), "自定义Float加减操作：" + incrementableAttribute.incrementBy + " : " + property.floatValue);
            }

            // 是整数类型
            if (property.propertyType == SerializedPropertyType.Integer)
            {
                if (SubOrAdd == -1)
                {
                    property.intValue -= (int)incrementableAttribute.incrementBy;
                }
                else if (SubOrAdd == +1)
                {
                    property.intValue += (int)incrementableAttribute.incrementBy;
                }

                EditorGUI.LabelField(new Rect(position.x + buttonWidth, position.y, position.width - buttonWidth * 2, position.height), "自定义Int加减操作：" + incrementableAttribute.incrementBy + " : " + property.intValue);
            }

            
        }
    }
}