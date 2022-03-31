using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject enemyPrefab;//Открытая переменная для связи с префабом
    private GameObject _enemy;//закрытая переменная для слежения за прифабом врага на сцене
    private GameObject player;

    // Update is called once per frame
    void Update()
    { //порождаем нового врага, если на сцене отсутсвует
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject; //метод копирующий объект-шаблон
            _enemy.transform.position = gameObject.transform.position;
            player = GameObject.FindWithTag("Player");//находим объект с тегом “Player”
            _enemy.gameObject.GetComponent<AIEnemy>().target = player.transform;
            _enemy.gameObject.GetComponent<AIEnemy>().player = player.GetComponent<PlayerCharacter>();
            float angel = Random.Range(0, 360);//случайный число в переменную
            _enemy.transform.Rotate(0, angel, 0);//случайный поворот
        }
    }
}
