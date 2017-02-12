using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

[ExecuteInEditMode]
public class terrain : MonoBehaviour
{
    public bool edit_mode = false;
    public GameObject PlanetGameobject;

    [Range(-4.0f, 4.0f)]
    public float radius;

}