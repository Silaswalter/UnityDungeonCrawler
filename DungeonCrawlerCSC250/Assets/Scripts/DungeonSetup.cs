using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;
    
    public bool northOn, southOn, eastOn, westOn;
    // Start is called before the first frame update
    void Start()
    {
        northOn = true;
        southOn = true;
        eastOn = true;
        westOn = true;

        
        if(northOn != true)
        {
            this.northExit.SetActive(false);
        }

        if(southOn != true)
        {
            this.southExit.SetActive(false);
        }

        if(eastOn != true)
        {
            this.eastExit.SetActive(false);
        }

        if(westOn != true)
        {
            this.westExit.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
