using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class CreateIcoSphere : MonoBehaviour
{
    static Camera cam;
    static Camera lastUsedCam;

    [MenuItem("Creat_Planet/IcoSphere")]
    static void CreateWizard()
    {
        cam = Camera.current;
        // Hack because camera.current doesn't return editor camera if scene view doesn't have focus
        if (!cam)
            cam = lastUsedCam;
        else
            lastUsedCam = cam;

        GameObject sphere = new GameObject();
        sphere.AddComponent<IcoSphere>();
        sphere.name = "IcoSphere";
        sphere.transform.position = cam.transform.position + cam.transform.forward * 5.0f;

    }
}