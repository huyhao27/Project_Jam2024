using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    List<Transform> squares = new List<Transform>();

    private void Awake()
    {
        transform.position = FindObjectOfType<PlayerContronller>().transform.position;
        transform.rotation = FindObjectOfType<PlayerContronller>().transform.rotation;
    }

}
