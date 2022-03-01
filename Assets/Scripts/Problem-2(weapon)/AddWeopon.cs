using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddWeopon : MonoBehaviour
{
    [SerializeField] Weopon mt_Wepon;
    [SerializeField] TMP_Text NameText;
    [SerializeField] TMP_Text ammoText;
    [SerializeField] TMP_Text MagSizeText;
    [SerializeField] TMP_Text FireRateText;

    private void Start()
    {
        NameText.text = mt_Wepon.Name;
        ammoText.text = mt_Wepon.Ammo;
        MagSizeText.text = mt_Wepon.MagSize.ToString();
        FireRateText.text = mt_Wepon.firerate.ToString();
    }
}
