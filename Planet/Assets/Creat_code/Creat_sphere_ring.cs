using UnityEngine;
using UnityEditor;
using System.Collections;

public class Creat_sphere_ring : MonoBehaviour
{
    [MenuItem("Creat_Planet/Planet 2")]
    static void Creat_Planet()
    {
        GameObject planet = new GameObject();
        GameObject ring = new GameObject();
        ring.AddComponent<Torus>();
        ring.name = "circle";
        planet.AddComponent<sphere>();
        planet.name = "planet";
        ring.transform.parent = planet.transform;
    }
}
