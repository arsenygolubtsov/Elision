using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*!
Реализует меню паузы. В этом меню присутствуют функции возвращения в игру, выхода в основное меню и выхода из игры.
*/

public class MenuPause : MonoBehaviour
{

/*!
Объект, являющийся окном настроек в меню паузы.
*/

    public GameObject settings;

/*!
Объект, являющийся меню паузы.
*/
    public GameObject MenuMessage;

/*!
Объект, являющийся окном выхода из меню паузы.
*/

    public GameObject QuitMessage;

/*!
Функция, вызывающаяся при нажатии кнопки Settings. Открывает окно настроек в меню паузы.
*/

    public void SettingsWindow()
    {
        settings.SetActive(!settings.activeSelf);
        MenuMessage.SetActive(!QuitMessage.activeSelf && !settings.activeSelf && MenuMessage.activeSelf);
        QuitMessage.SetActive(QuitMessage.activeSelf && !settings.activeSelf && !MenuMessage.activeSelf);
    }

/*!
Функция, вызывающаяся при нажатии кнопки Quit. Открывает окно выхода из игры.
*/

    public void QuitWindow()
    {
        QuitMessage.SetActive(!QuitMessage.activeSelf);
        settings.SetActive(!QuitMessage.activeSelf && settings.activeSelf && !MenuMessage.activeSelf);
        MenuMessage.SetActive(!QuitMessage.activeSelf && !settings.activeSelf && MenuMessage.activeSelf);
    }

/*!
Функция, отвечающая за выход из игры.
*/

    public void Quit()
    {
        Application.Quit();
    }

/*!
Функция, вызывающаяся при нажатии кнопки Menu. Открывает окно выхода из в основное меню.
*/

    public void MenuWindow()
    {
        MenuMessage.SetActive(!MenuMessage.activeSelf);
        settings.SetActive(!QuitMessage.activeSelf && settings.activeSelf && !MenuMessage.activeSelf);
        QuitMessage.SetActive(QuitMessage.activeSelf && !settings.activeSelf && !MenuMessage.activeSelf);
    }


/*!
Функция, отвечающая за выход в основное меню.
*/
    public void Menu()
    {
        SceneManager.LoadScene(5);
    }
}
