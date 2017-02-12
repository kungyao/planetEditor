using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SceneViewMouse))]
class SceneViewMouseEditor : Editor
{

    void OnSceneGUI()
    {
        SceneViewMouse obj = (SceneViewMouse)target;

        Vector3 mousepos = Event.current.mousePosition;

        mousepos = SceneView.lastActiveSceneView.camera.ScreenToWorldPoint(mousepos);
        mousepos.y = -mousepos.y;


        Debug.Log("mousepos: " + mousepos);
        if (Event.current.type == EventType.mouseDown)
        {
            Debug.Log("click");
        }
    }
}