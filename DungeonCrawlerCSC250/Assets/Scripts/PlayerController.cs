using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    public bool movement;
    public Vector3 middleVector;
    public Vector3 southVector;
    public Vector3 northVector;
    public Vector3 westVector;
    public Vector3 eastVector;
    

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        MasterData md = new MasterData();
        movement = true;

        this.middleVector = new Vector3(0.00f,1.00f,0.00f);
        this.southVector = new Vector3(0.00f,1.00f,-3.00f);
        this.northVector = new Vector3(0.00f,1.00f,3.00f);
        this.westVector = new Vector3(-3.00f,1.00f,0.00f);
        this.eastVector = new Vector3(3.00f,1.00f,0.00f);

        
            if(MasterData.whereDidIComeFrom == "north")
            {
                transform.position = southVector;
                this.rb.AddForce(new Vector3(0.00f,1.00f,3.00f)* movementSpeed);
            }
            if(MasterData.whereDidIComeFrom == "south")
            {
                transform.position = northVector;
                this.rb.AddForce(new Vector3(0.00f,1.00f,-3.00f)* movementSpeed);
            }
            if(MasterData.whereDidIComeFrom == "west")
            {
                transform.position = eastVector;
                this.rb.AddForce(new Vector3(-3.00f,1.00f,0.00f)* movementSpeed);
            }
            if(MasterData.whereDidIComeFrom == "east")
            {
                transform.position = westVector;
                this.rb.AddForce(new Vector3(3.00f,1.00f,0.00f)* movementSpeed);
            }


    }
        
           
            
 

    // Update is called once per frame
    void Update()
    {
        if(movement == true)
        {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            movement = false;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            movement = false;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            movement = false;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            movement = false;
        }
        }
        
    
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Exit"))
        {
            if(other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
                MasterData.count++;
                movement = true;
                MasterData.atMiddle = false;
                SceneManager.LoadScene("DungeonRoom");                    
            }
            if(other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
                MasterData.count++;
                movement = true;
                MasterData.atMiddle = false;
                SceneManager.LoadScene("DungeonRoom");
            }
            if(other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
                MasterData.count++;
                movement = true;
                MasterData.atMiddle = false;
                SceneManager.LoadScene("DungeonRoom");
            }
            if(other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
                MasterData.count++;
                movement = true;
                MasterData.atMiddle = false;
                SceneManager.LoadScene("DungeonRoom");
            }
             
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(MasterData.atMiddle == false)
        {
        if(other.gameObject.CompareTag("Middle"))
        {
            MasterData.atMiddle = true;
            MasterData.whereDidIComeFrom = "?";
            SceneManager.LoadScene("DungeonRoom");
        }
        }
    }
}