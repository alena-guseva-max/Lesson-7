using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool _open;//переменная для слежения состоянием двери
    public void Operate()
    {//открываем или закрываем дверь в зависимости от ее состояния
        if (_open)
        {
            transform.Rotate(0, 90, 0);
        }
        else
        {
            transform.Rotate(0, -90, 0);
        }
        _open = !_open;
    }
}
