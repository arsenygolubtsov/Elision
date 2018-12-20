using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
Класс, представляющий собой обучение, начинающееся при нажатии кнопки New Game.
*/

public class Training : MonoBehaviour
{

/*!
Объект, представляющий собой надпись "Press right arrow to next training or left to previous" во время обучения.
*/

    public GameObject tr1;

/*!
Объект, представляющий собой надпись "Move MOUSE to rotate camera" во время обучения.
*/

    public GameObject tr2;

/*!
Объект, представляющий собой надпись "A-W-S-D to move" во время обучения.
*/

    public GameObject tr3;

/*!
Объект, представляющий собой надпись "Space to jump" во время обучения.
*/

    public GameObject tr4;

/*!
Объект, представляющий собой надпись "Shift to sprint & ctrl to sneak" во время обучения.
*/

    public GameObject tr5;

/*!
Объект, представляющий собой надпись "1, 2, 3, 4 or mouse wheel to change weapons" во время обучения.
*/

    public GameObject tr6;

/*!
Объект, представляющий собой надпись "Press q to complete training" во время обучения.
*/

    public GameObject tr7;

/*!
Объект, представляющий собой окно,в котором находятся надписи во время обучения.
*/

    public GameObject training;
    private int i;

    void Start()
    {
        i = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && i < 7)
        {
            i++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && i > 1)
        {
            i--;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            training.SetActive(!training.activeSelf);
        }
        switch (i)
        {
            case 1:
                tr1.SetActive(true);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 2:
                tr1.SetActive(false);
                tr2.SetActive(true);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 3:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(true);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 4:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(true);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 5:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(true);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
            case 6:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(true);
                tr7.SetActive(false);
                break;
            case 7:
                tr1.SetActive(false);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(true);
                break;
            default:
                tr1.SetActive(true);
                tr2.SetActive(false);
                tr3.SetActive(false);
                tr4.SetActive(false);
                tr5.SetActive(false);
                tr6.SetActive(false);
                tr7.SetActive(false);
                break;
        }
    }
}
