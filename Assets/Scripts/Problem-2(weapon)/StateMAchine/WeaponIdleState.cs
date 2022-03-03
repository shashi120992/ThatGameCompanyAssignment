using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WEaponIdleState : WeaponBaseState
    {

        //here state changes to Base to Idle
        //player remain in this state till his magzine is filling

        public override void EnterState(WeaponStateManager weaponStateManager) { }
        public override void updateState(WeaponStateManager weaponStateManager) 
        {
            //if gun's magzine is full then 
            weaponStateManager.switchState(weaponStateManager.weaponActiveState);
        }
        public override void onCollisionEnter(WeaponStateManager weaponStateManager, Collision collision) { }
    }
}