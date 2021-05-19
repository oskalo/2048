using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2048 : MonoBehaviour
{
    [SerializeField] GameObject fillPrefab;
    [SerializeField] Transform[] allCells;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SpawnFill();
        }
    }

    public void SpawnFill()
    {
        int whichSpawn = Random.Range(0, allCells.Length);
        if (allCells[whichSpawn].childCount != 0){
            Debug.Log(allCells[whichSpawn].name);
            SpawnFill();
            return;
        }

        float chance = Random.Range(0f, 1f);
        Debug.Log(chance);
        if (chance <.2f){
            return;
        } else if (chance <.8f){
            
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(2);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            tempFillComp.FillValueUpdate(2);
        } else
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(4);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            tempFillComp.FillValueUpdate(4);
        }
    }
}
