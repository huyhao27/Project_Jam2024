using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {

        // day la cach di xuyen tuong 
        if (collision.CompareTag("Wall Right"))
        {
            transform.position = new Vector2(transform.position.x - 8, transform.position.y);
        }
        if (collision.CompareTag("Wall Left"))
        {
            transform.position = new Vector2(transform.position.x + 8, transform.position.y);
        }
        if (collision.CompareTag("Wall Top"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 8);
        }
        if (collision.CompareTag("Wall Bottom"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 8);
        }

    }
}
