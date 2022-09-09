using System.Linq;
using UnityEditor;
using UnityEngine;

namespace RequireInterface.Editor
{
    [CustomPropertyDrawer(typeof(RequireInterfaceAttribute))]
    public class InterfaceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var objectReference = property.objectReferenceValue;
            var requiredAttribute = attribute as RequireInterfaceAttribute;
            var type = requiredAttribute.Interface;

            EditorGUI.BeginProperty(position, label, property);

            if (objectReference != null)
            {
                var interfaces = objectReference.GetType().GetInterfaces();

                if (interfaces.Contains(type) == false)
                {
                    Debug.LogError($"{property.name} should implement {requiredAttribute.Interface.Name}");
                }
            }
            
            property.objectReferenceValue = EditorGUI.ObjectField(position, label, objectReference, typeof(MonoBehaviour), true);
            EditorGUI.EndProperty();
        }
    }
}