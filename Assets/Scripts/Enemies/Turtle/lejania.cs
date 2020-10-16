using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lejania : MonoBehaviour
{
    private TurtleMovement velocidadTortuga;

    //ontriggerexit para que sepa cuando mario sale del colider
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.transform.root.gameObject.name.Equals("Player"))
        {
            velocidadTortuga = transform.root.GetComponent<TurtleMovement>();
           //para que la tortuga vuelva a su velocidad inicial cuando mario salga
            velocidadTortuga.maxHorizontalVelocity = 1;
           



        }
    }
}
