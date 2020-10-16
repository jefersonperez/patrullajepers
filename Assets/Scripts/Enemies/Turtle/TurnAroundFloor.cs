﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAroundFloor : MonoBehaviour
{








    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(transform.root.gameObject.name);

        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.name == "DamageArea")
        {
            Debug.Log("Detecte Pared");
            Vector3 scale = new Vector3(transform.root.localScale.x * -1,
                transform.root.localScale.y,
                transform.root.localScale.z);

            transform.root.localScale = scale;
        }
    }
}
