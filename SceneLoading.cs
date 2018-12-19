using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*!
Даёт возможность игроку загрузить раннее сохранённую версию игры, нажав в основном меню клавишу Load Game.
*/

public class SceneLoading : MonoBehaviour
{
    [Header("Загружаемая сцена")]

/*!
Определяет номер сцены.
*/

    public int sceneID;

    void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
