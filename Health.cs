using UnityEngine;
using UnityEngine.UI;

namespace CoverShooter
{
    [ExecuteInEditMode]

/*!
Класс Health отвечает за здоровье управляемого персонажа. Благодаря нему на экране отображается количество здоровья персонажа и реализуется его смерть в случае если здоровье становится равным нулю.
*/

    public class Health : MonoBehaviour
    {
        [Tooltip("Object whose health is displayed on the health bar.")]

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
        [Range(0, 1)]
        [Tooltip("Current value of the health bar.")]

/*!
Отображает оставшееся здоровье управляемого персонажа.
*/

        public float Value = 1.0f;
        [Tooltip("Determines if the health bar is hidden when the target has no health.")]

/*!
Скрывает шкалу здоровья когда управляемый персонаж умирает.
*/

        public bool HideWhenDead = true;
        [Tooltip("Determines if the health bar is hidden when there is no target.")]

/*!
Оставляет шкалу здоровья на экране пока управляемый персонаж жив.
*/

        public bool HideWhenNone = false;
        [Tooltip("Link to the object that draws the health bar.")]

/*!
Отображает значок загрузки.
*/

        public Image LoadingImg;

        private GameObject _cachedTarget;
        private CharacterHealth _cachedCharacterHealth;

        private void LateUpdate()
        {
            if (Target1.activeSelf)
            {
                Target = Target1;
            }
            if (Target2.activeSelf)
            {
                Target = Target2;
            }
            if (Target != _cachedTarget)
            {
                _cachedTarget = Target;

                if (Target != null)
                {
                    _cachedCharacterHealth = Target.GetComponent<CharacterHealth>();
                }
                else
                {
                    _cachedCharacterHealth = null;
                }
            }

            if (_cachedCharacterHealth != null)
                Value = _cachedCharacterHealth.Health / _cachedCharacterHealth.MaxHealth;

            var isVisible = true;

            if (Application.isPlaying)
            {
                isVisible = (!HideWhenDead || Value > float.Epsilon) && (!HideWhenNone || Target != null);

                if (LoadingImg != null) LoadingImg.gameObject.SetActive(isVisible);
            }

            if (isVisible)
            {
                if (LoadingImg != null)
                    LoadingImg.fillAmount = Value;
            }
        }
    }
}