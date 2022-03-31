using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 5.0f; //переменная наносимого урона
    public float range = 50.0f; // переменная дальности луча

    public Camera cam;
    public ParticleSystem plazmLaser;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //блокируем курсор мыши
        Cursor.visible = false;  //скрываем курсор мыши
        plazmLaser.Stop();//останавливаем плазменный луч
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { //нажимаем на левую кнопку мыши
            plazmLaser.Play();//запускаем плазменный луч
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(point); //создание луча методом ScreenPointToRay().
            if (Physics.Raycast(ray, out hit ,range))
            {
                Debug.Log(hit.transform.name); // выводим имя объекта, в который попадает луч

                Strength objectVase = hit.transform.GetComponent<Strength>();
                DieEnemy enemy = hit.transform.GetComponent<DieEnemy>();
                if (enemy != null)
                {
                    enemy.ReactToHit();
                }
                if (objectVase != null)
                {
                    objectVase.Damage(damage);
                }
            }
        }
    }

    void OnGUI()
    {
        float posX = cam.pixelWidth / 2;
        float posY = cam.pixelHeight / 2;
        GUI.Label(new Rect(posX, posY, 12, 12), "*");//команда GUI.Label() отображает символ *
    }
}
