using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*!
Данный класс отвечает за возвращение в меню после прохождения игры.
*/

public class BacktoMenu : MonoBehaviour {

/*!
Определяет номер сцены.
*/

    public int sceneID;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

/*!
Функция, вызывающаяся при нажатии кнопки Back to Menu. Возвращает игрока в основное меню игры.
*/

    public void BackToMenu()
    {
        SceneManager.LoadScene(sceneID);
    }
}
