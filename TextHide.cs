using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
–еализует текст, €вл€ющийс€ подсказками игроку в ходе игрового процесса.
*/

public class TextHide : MonoBehaviour
{

/*!
ќтвечает за текст в игре.
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