using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*!
Выполняет перезагрузку сцены при помощи нажатия клавиши TAB.
*/

public class Scener : MonoBehaviour
{
    [Header("Загружаемая сцена")]


/*!
Определяет номер сцены.
*/
    public int sceneID;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
