using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerContronller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveAndRotate();

    }

    void PlayerMoveAndRotate()
    {
        if (Input.GetKeyDown(KeyCode.R)) // xoay b?ng nút R
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.localEulerAngles.z - 90f);
        }

        //di chuy?n lên xu?ng trái ph?i
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
        transform.position += dir;
    }
}
