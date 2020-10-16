using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximidad : MonoBehaviour
{
    private TurtleMovement velocidadTortuga;
    //ontriger enter para que se sepa que es cuando mario entra en el colider
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.root.gameObject.name.Equals("Player"))
        {   

            velocidadTortuga = transform.root.GetComponent<TurtleMovement>();
           //si mario entra la velocidad de la tortuga se aumenta a 5
            velocidadTortuga.maxHorizontalVelocity = 5;
            

        }
    }
}
