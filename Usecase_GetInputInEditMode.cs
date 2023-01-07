# link: https://answers.unity.com/questions/1501372/how-can-i-check-if-a-key-is-down-in-scene-view.html

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TerrainModifier))]
public class TerrainModifierEditor : Editor
{
    
    TerrainModifier terrainModifier; 

    SerializedProperty strength;

    void OnEnable()
    {
        terrainModifier = (TerrainModifier)target;
        SceneView.duringSceneGui += OnSceneGUI;

        strength = serializedObject.FindProperty("strength");

    }

    void OnDisable()
    {
        SceneView.duringSceneGui -= OnSceneGUI;
    }

    public override void OnInspectorGUI()
    {
        // DrawDefaultInspector ();
        serializedObject.Update();

        EditorGUILayout.PropertyField(strength);

        EditorGUILayout.Space(10);
        // EditorGUILayout.LabelField("1. Eidt Tool");
        
        terrainModifier.editingEnabled = EditorGUILayout.Toggle("Enable to edit", terrainModifier.editingEnabled);
       
        serializedObject.ApplyModifiedProperties();
    
    }


    void OnSceneGUI(SceneView sv)
    {
        Event e = Event.current;
 
        switch (e.type)
        {
            case EventType.MouseMove:
                Vector3 mousePos = e.mousePosition;
                // The Input class only works at runtime. It can't be used at edit time.
                // Ray ray = sv.camera.ScreenPointToRay(mousePos);
                Ray ray = HandleUtility.GUIPointToWorldRay(mousePos);
                terrainModifier.FindPosition(ray, mousePos);
                break;

            case EventType.MouseDrag:
                Vector3 mousePos1 = e.mousePosition;
                // Ray ray = sv.camera.ScreenPointToRay(mousePos);
                Ray ray1 = HandleUtility.GUIPointToWorldRay(mousePos1);
                terrainModifier.FindPosition(ray1, mousePos1);
                if(e.button == 0)
                {
                    terrainModifier.Dig();
                } else if(e.button == 1)
                {
                    terrainModifier.Build();
                }
                break;

            case EventType.ScrollWheel:
                terrainModifier.AdjustWheel(e.delta);
                break;

            case EventType.MouseDown:
                if(e.button == 0)
                {
                    terrainModifier.Dig();
                } else if(e.button == 1)
                {
                    terrainModifier.Build();
                }
                break;

            case EventType.Layout:
                HandleUtility.AddDefaultControl(GUIUtility.GetControlID(GetHashCode(), FocusType.Passive));
                break;
        }

    }
}
