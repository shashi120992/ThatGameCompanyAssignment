using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WeaponStateManager : MonoBehaviour
    {
        WeaponIdleState  currentState;
        WeaponActiveState weaponActiveState = new WeaponActiveState();
        WeopanChoosingState WeopanChoosingState = new WeopanChoosingState();


        private void Update()
        {
            //switch(currentState)
                //case: weaponActiveState.Active()
        }

    }
}