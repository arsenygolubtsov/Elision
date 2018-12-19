using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*!
Отвечает за загрузку выбранной сцены при входе в конкретную область.
*/

public class SurfaceTP : MonoBehaviour
{

/*!
Определяет номер сцены.
*/

    public int sceneID;
    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
