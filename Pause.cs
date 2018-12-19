using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*!
Позволяет выходить в меню паузы во время игры.
*/

public class Pause : MonoBehaviour
{

/*!
Отвечает за то, находится ли игра в состоянии паузы или нет.
*/

    public float timer;

/*!
Проверяет находится ли игра в состоянии паузы.
*/

    public bool isPaused = false;

/*!
Объект, являющийся меню паузы.
*/

    public GameObject PauseMenu;

/*!
Объект, являющийся шкалой здоровья управляемого персонажа.
*/

    public GameObject Health;
    void Start()
    {
        timer = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

/*!
Функция, вызывающаяся при нажатии кнопки Resume. Отвечает за возвращение из меню паузы в игру.
*/

    public void Resume()
    {
        isPaused = false;
    }
    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PauseMenu.gameObject.SetActive(true);
            Health.gameObject.SetActive(false);
            timer = 0;
        }
        else if (isPaused == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            PauseMenu.gameObject.SetActive(false);
            Health.gameObject.SetActive(true);
            timer = 1;
        }
    }
}
