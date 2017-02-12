using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(terrain))]
public class terrainEditor : Editor
{
    //SerializedObject PlanetGameobject;
    private float distance;
    public GameObject newTile;

    void OnSceneGUI()
    {
        Ray ray = Camera.current.ScreenPointToRay(Event.current.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit, 1000.0f))
        {
            Vector3 newTilePosition = hit.point;
            Debug.Log(newTilePosition);
        }
    }
    /*private void OnSceneGUI()
    {
        terrain t = target as terrain;


        float distance = Vector3.Distance(mousepos, t.PlanetGameobject.transform.position);

        Debug.Log(distance);

        /*terrain planet = target as terrain;
        if (planet == null || planet.gameObject == null)
        {
            Debug.Log("error!");
            return;
        }
        Vector3 mouse = Camera.main.ScreenToViewportPoint(Event.current.mousePosition);

        Vector3 center = planet.PlanetGameobject.transform.position;
        distance = Vector3.Distance(center, mouse);
        Debug.Log(123);
        
    }*/
}
