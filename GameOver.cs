using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
Реализует финальную сцену игры.После данной сцены игрок имеет возможность вернуться в основное меню игры.
*/

public class GameOver : MonoBehaviour {

/*!
Объект, отвечающий за первого зомби в финальной сцене.
*/

    public GameObject zombie1;

/*!
Объект, отвечающий за второго зомби в финальной сцене.
*/

    public GameObject zombie2;

/*!
Объект, отвечающий за третьего зомби в финальной сцене.
*/

    public GameObject zombie3;

/*!
Объект, отвечающий за четвёртого зомби в финальной сцене.
*/

    public GameObject zombie4;

/*!
Объект, отвечающий за пятого зомби в финальной сцене.
*/

    public GameObject zombie5;

/*!
Объект, отвечающий за шестого зомби в финальной сцене.
*/

    public GameObject zombie6;

/*!
Объект, отвечающий за седьмого зомби в финальной сцене.
*/

    public GameObject zombie7;

/*!
Объект, отвечающий за восьмого зомби в финальной сцене.
*/

    public GameObject zombie8;

/*!
Объект, отвечающий за девятого зомби в финальной сцене.
*/

    public GameObject zombie9;

/*!
Объект, отвечающий за десятого зомби в финальной сцене.
*/

    public GameObject zombie10;

/*!
Объект, отвечающий за одиннадцатого зомби в финальной сцене.
*/

    public GameObject zombie11;

/*!
Объект, отвечающий за двенадцатого зомби в финальной сцене.
*/

    public GameObject zombie12;

/*!
Объект, представляющий из себя область, при входе в которую игрок выходит из финальной сцены и фактически завершает игру.
*/

    public GameObject TheEnd;

    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            zombie1.SetActive(true);
            zombie2.SetActive(true);
            zombie3.SetActive(true);
            zombie4.SetActive(true);
            zombie5.SetActive(true);
            zombie6.SetActive(true);
            zombie7.SetActive(true);
            zombie8.SetActive(true);
            zombie9.SetActive(true);
            zombie10.SetActive(true);
            zombie11.SetActive(true);
            zombie12.SetActive(true);
            TheEnd.SetActive(true);
        }
    }
}