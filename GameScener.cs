using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*!
��������� ������� �� �������� � ������ ���� ��� ������ ������� ������� Q.
*/

public class GameScener : MonoBehaviour
{
    [Header("����������� �����")]

/*!
���������� ����� �����.
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