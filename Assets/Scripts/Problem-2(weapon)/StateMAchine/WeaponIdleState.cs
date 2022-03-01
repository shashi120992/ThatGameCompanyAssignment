using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public abstract class WeaponIdleState
    {
        //this is a base class for weapon
        //here player loads bullets as per weapon type

        public virtual void enterState()
        { }
    }
}