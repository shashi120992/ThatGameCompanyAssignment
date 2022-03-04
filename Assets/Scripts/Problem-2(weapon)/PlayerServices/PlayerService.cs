using Assets.Scripts.Problem_2_weapon_.SingleTon;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.PlayerServices
{
    public class PlayerService : MonoSingleton<PlayerService>
    {
        public PlayerController PlayerController;

        public WeaponSOList WeoponSOList;

        //Player service will acess all functions of model view from controller only

        private void Start()
        {
            criatePlayer();
        }

        private void criatePlayer()
        {
            //criate some player
        }
    }
}