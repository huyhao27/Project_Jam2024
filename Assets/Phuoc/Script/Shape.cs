using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    List<Transform> squares = new List<Transform>();

    private void Awake()
    {
        // chuyen cac square thanh child cua playercontroller
        foreach (Transform square in GetComponentInChildren<Transform>())
        {
            squares.Add(square);
        }
        foreach (Transform square in squares)
        {
            square.SetParent(FindObjectOfType<PlayerContronller>().transform);
        }
        Destroy(gameObject);
    }

}
