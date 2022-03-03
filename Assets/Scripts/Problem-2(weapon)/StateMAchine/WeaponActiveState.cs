using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WeaponActiveState : WeaponBaseState
    {

        //here state changes to base to active
        //player fires the wepon until it  will become empty

        public override void EnterState(WeaponStateManager weaponStateManager) { }
        public override void updateState(WeaponStateManager weaponStateManager) 
        {
            //when magzine is over choose anothe weapon
            
            weaponStateManager.switchState(weaponStateManager.WeopanChoosingState);
            Weoponchoose();
        }
        public override void onCollisionEnter(WeaponStateManager weaponStateManager, Collision collision) { }

         private void Weoponchoose()
        {

        }
    }
}