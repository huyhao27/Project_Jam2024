using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    public Color[] availableColors; // tạo mảng màu mình muốn biến đổi

    void Start()
    {
        RandomizeColors(); // game bắt đầu thì random màu
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // Kiểm tra khi người chơi nhấn chuột trái, để để test, có thể bỏ sau khi ok
        {
            RandomizeColors(); // Gọi hàm random màu 
        }
    }

    void RandomizeColors()
    {

        if (availableColors != null)
        {
            foreach (Transform child in transform)


                foreach (Transform c in transform)
                {
                    if (availableColors.Length != 0)


                    {
                        SpriteRenderer squareRenderer = child.GetComponent<SpriteRenderer>(); // Lấy reference tới SpriteRenderer của hình vuông
                        if (squareRenderer != null)
                        {
                            int randomIndex = Random.Range(0, availableColors.Length); // Chọn ngẫu nhiên index trong mảng màu
                            squareRenderer.color = availableColors[randomIndex]; // Thay đổi màu của hình vuông con
                        }
                    }

                }



        }
    }
}
