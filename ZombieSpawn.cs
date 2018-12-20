using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
Класс, отвечающий за противников с искусственным интеллектом. Включает в себя три типа зомби.
*/

public class ZombieSpawn : MonoBehaviour {

/*!
Объект, представляющий собой первый тип зомби.
*/

    public GameObject zombie1;

/*!
Объект, представляющий собой второй тип зомби.
*/

    public GameObject zombie2;

/*!
Объект, представляющий собой третий тип зомби.
*/

    public GameObject zombie3;
    void Start()
    {
        zombie1.SetActive(false);
        zombie2.SetActive(false);
        zombie3.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        zombie1.SetActive(true);
        zombie2.SetActive(true);
        zombie3.SetActive(true);
    }
}
