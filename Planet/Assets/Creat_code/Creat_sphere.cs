using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class Creat_sphere : MonoBehaviour
{    
    [MenuItem("Creat_Planet/Planet")]
    static void Creat_Planet()
    {
        GameObject planet = new GameObject();
        planet.AddComponent<sphere>();
        planet.name = "planet";
    }
}