using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
 ласс, отвечающий за противников с искусственным интеллектом. ¬ключает в себ€ три типа зомби.
*/

public class ZombieSpawn : MonoBehaviour {

/*!
ќбъект, представл€ющий собой первый тип зомби.
*/

    public GameObject zombie1;

/*!
ќбъект, представл€ющий собой второй тип зомби.
*/

    public GameObject zombie2;

/*!
ќбъект, представл€ющий собой третий тип зомби.
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