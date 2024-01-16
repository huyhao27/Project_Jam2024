using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tomino;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerContronller : MonoBehaviour
{
    List<Transform> squares = new List<Transform>();
    Transform centerSquare;
    void Start()
    {
        // lay danh sach cac thanh phan con
        foreach (Transform square in GetComponentInChildren<Transform>())
        {
            squares.Add(square);
            if (square.name.IndexOf("Center") != -1)
            {
                centerSquare = square;
                // xac dinh square trung tam 
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveAndRotate();

    }

    void PlayerMoveAndRotate()
    {
        if (Input.GetKeyDown(KeyCode.R)) // xoay bang nut R
        {
            foreach (Transform t in squares)
            {
                t.transform.SetParent(null); // dua tung cai ra ngoai
            }
            transform.position = centerSquare.transform.position; // cho vi tri playercontroller bang vi tri square trung tam
            foreach (Transform t in squares)
            {
                t.transform.SetParent(transform); // dua vao lai
            }
            transform.rotation = Quaternion.Euler(0, 0, transform.localEulerAngles.z - 90f); // xoay


        }

        //di chuyen len xuong trai phai
        Vector3 dir = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = Vector3.down;
        }
        foreach (Transform t in squares)
        {
            t.transform.position += dir;
        }
    }
}
