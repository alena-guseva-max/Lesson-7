using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    public float health = 25f; //значение прочности предмета
    public void Damage(float value)
    {
        health -= value;
        if (health <= 0)
        {// если прочность предмета меньше 0
            Destroy(gameObject); // уничтожаем объект методом Destroy()
        }
    }
}
