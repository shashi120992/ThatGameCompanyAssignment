using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public abstract class WeaponBaseState
    {
        //this is a base class for weapon
        //here player loads bullets as per weapon type

        public abstract void EnterState(WeaponStateManager weaponStateManager);
        public abstract void updateState(WeaponStateManager weaponStateManager);
        public abstract void  onCollisionEnter(WeaponStateManager weaponStateManager, Collision collision);
        
    }
        
}