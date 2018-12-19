using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

/*!
Данный класс отвечает за реализацию основного меню игры. С его помощью можно начать новую либо загрузить уже существующую версию игры, выйти из игры, а также узнать данные о разработчиках проекта.
*/

public class Menu : MonoBehaviour
{

/*!
Объект, являющийся окном настроек.
*/

    public GameObject settings;

/*!
Объект, являющийся окном, содержащим информацию о разработчиках игры.
*/

    public GameObject AboutButton;

/*!
Объект, являющийся окном выхода из игры.
*/

    public GameObject message;
    private string Save;
    void Start()
    {
        Save = "Saves/Player.txt";
    }
    void Update()
    {
        Time.timeScale = 1f;
    }

/*!
Функция, вызывающаяся при нажатии кнопки New Game. Отвечает за запуск обучения.
*/

    public void NewGame()
    {
        StreamWriter sw = new StreamWriter(Save);
        sw.Write(1);
        sw.Close();
        SceneManager.LoadScene(1);
    }

/*!
Функция, вызывающаяся при нажатии кнопки Load Game. Отвечает за запуск раннее сохранённой версии игры.
*/

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

/*!
Функция, вызывающаяся при нажатии кнопки Settings. Открывает окно настроек.
*/

    public void SettingsWindow()
    {
        settings.SetActive(!settings.activeSelf);
        AboutButton.SetActive(!message.activeSelf && !settings.activeSelf && AboutButton.activeSelf);
        message.SetActive(message.activeSelf && !settings.activeSelf && !AboutButton.activeSelf);
    }

/*!
Функция, вызывающаяся при нажатии кнопки About. Открывает окно, содержащее информацию о разработчиках игры.
*/

    public void AboutWindow()
    {
        AboutButton.SetActive(!AboutButton.activeSelf);
        settings.SetActive(!message.activeSelf && settings.activeSelf && !AboutButton.activeSelf);
        message.SetActive(message.activeSelf && !settings.activeSelf && !AboutButton.activeSelf);
    }

/*!
Функция, вызывающаяся при нажатии кнопки Quit. Открывает окно выхода из игры.
*/

    public void QuitMessage()
    {
        message.SetActive(!message.activeSelf);
        AboutButton.SetActive(!message.activeSelf && !settings.activeSelf && AboutButton.activeSelf);
        settings.SetActive(!message.activeSelf && settings.activeSelf && !AboutButton.activeSelf);
    }

/*!
Функция, отвечающая за выход игры.
*/

    public void Quit()
    {
        Application.Quit();
    }
}
