using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private GenerateBlocksScript generateBlocksScript;
    public GameObject PlatformA;
    public GameObject PlatformB;
    public GameObject PlatformC;
    public GameObject MainCamera;

    private List<GameObject> gameObjectList = new List<GameObject>();
    private double yPos = 1;
    private int counter = 0;

    private double camYPos = 10.5;
    private int camZPos = -50;




    void Start()
    {
        
        // This following line of code lets the game call the function
        // generateBlocks every 0.5 seconds
        //InvokeRepeating("generateBlocks", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")){
            generateBlocksScript.Start();
        }

    }

    private void generateBlocks()
    {
        if (counter < 20)
        {
            if (gameObjectList.Count < 5)
            {
                //Instantiate at position (0, 0, 0) and zero rotation.
                gameObjectList.Add(Instantiate(PlatformA, new Vector3(0, ((float)yPos), 0), Quaternion.identity));
                MainCamera.transform.position = new Vector3(0, ((float)camYPos), camZPos);
                yPos = yPos + 2;
                camYPos = camYPos + 2;
                counter++;
            }
            else
            {
                GameObject.Destroy(gameObjectList[0], 1.0f);
                gameObjectList.RemoveAt(0);
            }
        }
    }
}
