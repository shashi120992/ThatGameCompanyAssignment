using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    public int value;
    public SpriteRenderer mt_Rendor;
    [SerializeField] private TextMeshPro mt_Text;
    [SerializeField] private int mt_areaOfIntrest;
   
    
    private void Awake()
    {
        value = Random.Range(10, 96);
    }
    public void init()
    {
        mt_Text.text = value.ToString();
        mt_Rendor.color = GetRandomColour32();
    }
    public void init2()
    {
        value = value - mt_areaOfIntrest;
        mt_Text.text = value.ToString();
        mt_Rendor.color = GetRandomColour32();
    }
    public void init3()
    {
        value = value + mt_areaOfIntrest;
        mt_Text.text = value.ToString();
        mt_Rendor.color = GetRandomColour32();
    }

    private Color32 GetRandomColour32()
    {
        return new Color32(
          (byte)UnityEngine.Random.Range(0, 255),
          (byte)UnityEngine.Random.Range(0, 255),
          (byte)UnityEngine.Random.Range(0, 255),
          255
        );
    }
}
