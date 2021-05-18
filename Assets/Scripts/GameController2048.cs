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
        
    }

    public void SpawnFill()
    {
        float chance = Random.Range(of, 1f);
        if (chance <.2f)
        {
            return;
        } else if (chance < 8.f)
        {
            int whichSpawn = Random.Range(0, allCells.Lenght);
        }
    }
}
