using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*!
Данный класс отвечает за выбор персонажа при входе в раннее сохранённую игру. Благодаря этому классу игрок начинает управлять тем же персонажем, которым он и управлял во время сохранения данной версии.
*/

public class ChoosePlayer : MonoBehaviour {

/*!
Объект, отвечающий за первого персонажа.
*/

    public GameObject Player1;

/*!
Объект, отвечающий за второго персонажа.
*/

    public GameObject Player2;

/*!
Объект, отвечающий за камеру, привязанную к первому персонажу.
*/

    public GameObject Camera1;

/*!
Объект, отвечающий за камеру, привязанную ко второму персонажу.
*/

    public GameObject Camera2;
    private float Check;
    void Start () {
        StreamReader streamReader = new StreamReader("Saves/Player.txt");
        if (streamReader != null)
        {
            while (!streamReader.EndOfStream)
            {
                Check = System.Convert.ToSingle(streamReader.ReadLine());
            }
            if (Check != 0)
            {
                if (Check == 1)
                {
                    Player1.SetActive(true);
                    Camera1.SetActive(true);
                }
                else if (Check == 2)
                {
                    Player2.SetActive(true);
                    Camera2.SetActive(true);
                }
            }
            else
            {
                Player1.SetActive(true);
                Camera1.SetActive(true);
            }
        }
    }
}
