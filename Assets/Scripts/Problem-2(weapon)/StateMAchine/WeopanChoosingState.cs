using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WeopanChoosingState : WeaponIdleState
    {

        //here player choses the wepon based on his requrement
        // he can have maximum of 3 Guns
        //and only one gun is active at once and if that gun becomes empty then only he can use another Gun

        public void EnterState()
        {

        }
        
    }
}