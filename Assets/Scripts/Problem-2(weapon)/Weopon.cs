using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Weopon", menuName = "Weopon")]
public class Weopon : ScriptableObject
{
    public enum weopon { HandGun, SubMechine, AsultRiffle, ShotGun, Snipper, };
    
    public string Name;
    public string Ammo;
    public int MagSize;
    public int firerate;

    //Weopon Type
    
}
