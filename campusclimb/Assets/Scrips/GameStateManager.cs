using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject PlatformA;
    public GameObject PlatformB;
    public GameObject PlatformC;
    public GameObject PlatformD;
    public GameObject MainCamera;

    private Platform PlatA;
    private Platform PlatB;
    private Platform PlatC;
    private Platform PlatD;

    private List<GameObject> conPlatAD = new List<GameObject>();
    private List<GameObject> conPlatB = new List<GameObject>();
    private List<GameObject> conPlatC = new List<GameObject>();

    private List<GameObject> gameObjectList = new List<GameObject>();
    private double yPos = 1;
    private int counter = 0;

    private double camYPos = 10.5;
    private int camZPos = -20;

    private float addRemoveRate = 0.5f;
    private float timer = 0.5f;
    //private Random rdm = new Random();


    void Start()
    {
        this.PlatA = new Platform(PlatformA);
        this.PlatB = new Platform(PlatformB);
        this.PlatC = new Platform(PlatformC);
        this.PlatD = new Platform(PlatformD);
        
        //Un-comment this for more complete code

        //conPlatAD.Add(PlatformA);
        //conPlatB.Add(PlatformB);
        //conPlatC.Add(PlatformC);
        //conPlatAD.Add(PlatformD);

        //Comment the next 4 lines for more complete code
        conPlatB.Add(PlatformA);
        conPlatB.Add(PlatformB);
        conPlatB.Add(PlatformC);
        conPlatB.Add(PlatformD);

        PlatA.setConPlat(conPlatAD);
        PlatB.setConPlat(conPlatB);
        PlatC.setConPlat(conPlatC);
        PlatD.setConPlat(conPlatAD);

        //Un-comment this for more complete code
        //this.gameObjectList.Add(PlatA.getRandomConPlat());
        this.gameObjectList.Add(PlatB.getRandomConPlat());

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void FixedUpdate()
    {
        timer -= 1 * Time.deltaTime;
        if (timer < 0)
        {
            Invoke("generateBlocks", 1.0f);
            timer = 0.5f;
        }

            
    }

    // Method to generate Platforms in the world at pos (0, Y, 0) where Y must be half the height of a Platform
    // 
    // Currently the camera's position is hard coded into the method. It's Ypos is simply set to a specific number
    // which then increases as more platforms are added.
    private void generateBlocks()
    {
        if (counter < 200)
        {
            if (gameObjectList.Count < 80)
            {
                
                this.gameObjectList.Add(Instantiate(chooseNextBlock(), new Vector3(0, ((float)yPos), 0), Quaternion.identity));
                MainCamera.transform.position = new Vector3(0, ((float)camYPos), camZPos);
                yPos = yPos + 2;
                camYPos = camYPos + 2;
                counter++;
            }
            else
            {
                GameObject.DestroyImmediate(gameObjectList[0]);
                gameObjectList.RemoveAt(0);
            }
        }

    }

    private GameObject chooseNextBlock()
    {
        //Swap what code is commented below for more complete code, not just tests


        return this.PlatB.getRandomConPlat();
        //int temp = gameObjectList.Count;
        //Debug.Log("The Object count is: " + temp);
        //if (gameObjectList[^1].tag == "Testag")
        //{
        //    return this.PlatB.getRandomConPlat();
        //}
        //else if (gameObjectList[^1].tag == "TestTag2")
        //{
        //    return this.PlatC.getRandomConPlat();
        //}
        //else
        //{
        //    return this.PlatA.getRandomConPlat();
        //}

    }
}
