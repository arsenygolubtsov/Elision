using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
Реализует текст, являющийся подсказками игроку в ходе игрового процесса.
*/

public class TextHide : MonoBehaviour
{

/*!
Отвечает за текст в игре.
*/

    public GameObject text;
    void OnTriggerEnter(Collider TP)
    {
        if (TP.attachedRigidbody)
        {
            text.SetActive(false);
        }
    }
}
