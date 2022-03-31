using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public float radius = 2f;//расстояние, с которого можно активировать открытие двери
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {//реакция на кнопку ввода (кнопка E)
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);//метод OverlapSphere возвращает список ближайших объектов    
            foreach (Collider hitCollider in hitColliders)
            {
                hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);//метод SendMessage пытается вызвать функцию 
            }
        }
    }
}
