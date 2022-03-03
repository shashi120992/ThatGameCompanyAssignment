using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.StateMAchine
{
    public class WeaponStateManager : MonoBehaviour
    {
        WeaponBaseState  currentState;
        public WeaponActiveState weaponActiveState = new WeaponActiveState();
        public WeopanChoosingState WeopanChoosingState = new WeopanChoosingState();
        public WEaponIdleState WEaponIdleState = new WEaponIdleState();



        private void Start()
        {
            currentState = WEaponIdleState;
            currentState.EnterState(this);
        }

        private void OnCollisionEnter(Collision collision)
        {
            currentState.onCollisionEnter(this, collision); 
        }
        private void exitState(Collision collision)
        {

        }
        private void Update()
        {
            currentState.updateState(this);
        }

        //switching between states
        public void switchState(WeaponBaseState state)
        {
          currentState = state;
            state.EnterState(this);


        }

    }
}