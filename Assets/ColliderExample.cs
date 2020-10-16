using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ColliderExample : MonoBehaviour
{
    public GameObject obj;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*Tilemap[] obj = FindObjectsOfType<Tilemap>();

        foreach(Tilemap tilemap in obj)
        {
            if (tilemap.gameObject.name == "Meseta")
                tilemap.gameObject.SetActive(true);
        }*/

        obj.SetActive(true);
    }
}
