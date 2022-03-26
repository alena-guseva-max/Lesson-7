using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 3.0f; //Объявление общедоступной переменной для скорости вращения

    void Update()
    {
        if (speed == 6.0f)
        { //если скорость равна 6
            transform.Rotate(0, speed, 0);
        }
        else
        { //иначе куб поворачивается в другую сторону
            transform.Rotate(0, -speed, 0);
        }
    }
}
