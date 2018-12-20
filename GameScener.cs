using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*!
Выполняет переход из обучения в начало игры при помощи нажатия клавиши Q.
*/

public class GameScener : MonoBehaviour
{
    [Header("Çàãðóæàåìàÿ ñöåíà")]

/*!
Определяет номер сцены.
*/

    public int sceneID;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
