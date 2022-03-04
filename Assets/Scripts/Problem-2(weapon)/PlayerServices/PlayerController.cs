using Assets.Scripts.Problem_2_weapon_.PlayerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    public PlayerModel PlayerModel { get; private set; }
    public PlayerView PlayerView { get; private set; }

    //Contoller connects Model and view and comunicate through Player service
}
