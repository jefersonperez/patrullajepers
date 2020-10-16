using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = transform.parent.gameObject;

        obj.SetActive(false);
    }
}
