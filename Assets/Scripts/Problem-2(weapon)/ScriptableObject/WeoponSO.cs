using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Weopon", menuName = "Weopon")]
public class WeoponSO : ScriptableObject
{
    public enum weoponType 
    { 
        none, 
        HandGun, 
        SubMechine, 
        AsultRiffle, 
        ShotGun, 
        Snipper, 
    };

    public weoponType weopon;
    public string Name;
    public int Accuracy;
    public int Damage;
    public int Magazine;
    public int firerate;

    //Weopon Type
    
}
