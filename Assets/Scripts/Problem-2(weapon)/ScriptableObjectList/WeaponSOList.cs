using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weopon List", menuName = "WeoponList")]
public class WeaponSOList : ScriptableObject
{
    public WeoponSO.weoponType weoponType; 
    public WeoponSO[] Weopons;
   
}
