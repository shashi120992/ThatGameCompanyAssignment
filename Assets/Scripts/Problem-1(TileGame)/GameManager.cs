using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int mt_width, mt_height;
    [SerializeField] private GameObject mt_nodePrefab;
    [SerializeField] private Block mt_blockPrefab;
    [SerializeField] private Transform mt_CameraPosition;
    [SerializeField] private int mt_AreaOfIntrest;
    //[SerializeField] Transform[] allcells;
    //private GridLayout tilePos;

    private GameObject node;
    private GridLayout tileGrid;

    private void Start()
    {
        generateGrid();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3Int tilePos = tileGrid.WorldToCell(worldPos);
            //Debug.Log("cell is " + node);
            spawnBlocks();
        }
    }
    private void generateGrid()
    {
        for (int i = 0; i < mt_width; i++)
        {
            for (int j = 0; j < mt_height; j++)
            {
                node = Instantiate(mt_nodePrefab, new Vector3(i, j), Quaternion.identity);
                node.name = $"Node_{i}{j}";    
            }
        }
        mt_CameraPosition.transform.position = new Vector3((float)mt_width / 2 - 0.5f, (float)mt_width / 2 - 0.5f, -10);
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
    void spawnBlocks()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        int Rand = Random.Range(10, 95);

        for(int i = -mt_AreaOfIntrest; i <= mt_AreaOfIntrest; i++)
        {
            for (int j = -mt_AreaOfIntrest; j <= mt_AreaOfIntrest; j++)
            {
                Vector3 a = new Vector3((float)Math.Round(worldPosition.x + i), (float)Math.Round(worldPosition.y + j), 0f);
                var block1 = Instantiate(mt_blockPrefab, a, Quaternion.identity);
                block1.transform.parent = node.transform;
               // block1.init();

                //Not Working...

                for (int k = 0; k < block1.transform.childCount; ++k)
                {
                    Transform currentItem = block1.transform.GetChild(k);

                    //Search by name
                    if (currentItem.name.Equals("Back"))
                    {
                        currentItem.GetComponent<SpriteRenderer>().material.color = GetRandomColour32();
                        //currentItem.GetComponent<Sprite>().gra
                        continue;
                    }

                    if (currentItem.name.Equals("Text"))
                    {
                        int s = Rand + ((-2 * mt_AreaOfIntrest) - 1)*j + i;
                        currentItem.GetComponentInChildren<TextMeshPro>().text = s.ToString();
                        continue;
                    }
                }
                
            }
        }

    }


}
[Serializable]
public struct blockType
{
    public int Val;
    public Color col;
}

