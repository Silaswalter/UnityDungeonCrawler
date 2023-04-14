using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public bool northOn, southOn, eastOn, westOn;

    // Start is called before the first frame update
    void Start()
    {
        //hw answer should be in here!
        MasterData.setupDungeon();
        northOn = false;
        southOn = false;
        eastOn = false;
        westOn = false;
        northExit.SetActive(northOn);
        southExit.SetActive(southOn);
        eastExit.SetActive(eastOn);
        westExit.SetActive(westOn);

        if(MasterData.p.getCurrentRoom().hasExit("north"))
        {
            northOn = true;
            northExit.SetActive(northOn);
            MasterData.canGoNorth = true;
        }
        else
        {
            MasterData.canGoNorth = false;
        }

        if(MasterData.p.getCurrentRoom().hasExit("south"))
        {
            southOn = true;
            southExit.SetActive(southOn);
            MasterData.canGoSouth = true;
        }
        else
        {
            MasterData.canGoSouth = false;
        }
        
        if(MasterData.p.getCurrentRoom().hasExit("east"))
        {
            eastOn = true;
            eastExit.SetActive(eastOn);
            MasterData.canGoEast = true;
        }
        else
        {
            MasterData.canGoEast = false;
        }
        
        if(MasterData.p.getCurrentRoom().hasExit("west"))
        {
            westOn = true;
            westExit.SetActive(westOn);
            MasterData.canGoWest = true;
        }
        else
        {
            MasterData.canGoWest = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}