using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*!
Выводит на экран мини-карту. Карта отображает местоположение персонажа, направление его движения и окружающую его местность на расстоянии заданного радиуса.
*/

public class MiniMap : MonoBehaviour
{

/*!
Объект, отвечающий за первого персонажа.
*/

    public GameObject Target1;

/*!
Объект, отвечающий за второго персонажа.
*/

    public GameObject Target2;

/*!
Объект, отвечающий за управляемого в данный момент персонажа.
*/

    private GameObject Target;

/*!
Определяет преобразование камеры, привязанной к первому персонажу, в двумерной плоскости.
*/

    public Transform Trans1;

/*!
Определяет преобразование камеры, привязанной ко второму персонажу, в двумерной плоскости.
*/

    public Transform Trans2;

/*!
Определяет преобразование камеры, привязанной к управляемому в данный момент персонажу, в двумерной плоскости.
*/

    private Transform Trans;

/*!
Определяет высоту камеры над управляемым персонажем. Данная камера проецирует изображение на мини карту.
*/

    public float distance = 100;

    void LateUpdate()
    {
        if (Target1.activeSelf)
        {
            Target = Target1;
            Trans = Trans1;
        }
        if (Target2.activeSelf)
        {
            Target = Target2;
            Trans = Trans2;
        }
        transform.position = Target.transform.position + Vector3.up * distance;
        transform.rotation = Quaternion.Euler(90, Trans.eulerAngles.y, 0);
    }
}
