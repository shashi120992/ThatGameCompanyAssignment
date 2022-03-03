using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WeopanChoosingState : WeaponBaseState
    {

        //here player choses the wepon based on his requrement
        // he can have maximum of 3 Guns
        //and only one gun is active at once and if that gun becomes empty then only he can use another Gun

        public override void EnterState(WeaponStateManager weaponStateManager) { }
        public override  void updateState(WeaponStateManager weaponStateManager) 
        {
            weaponStateManager.switchState(weaponStateManager.WEaponIdleState);
        }
        public override void onCollisionEnter(WeaponStateManager weaponStateManager, Collision collision) { }

    }
}