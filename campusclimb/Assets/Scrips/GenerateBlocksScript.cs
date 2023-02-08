using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocksScript : MonoBehaviour
{

    public GameObject PlatformA;
    public GameObject PlatformB;
    public GameObject PlatformC;
    public GameObject MainCamera;

    private List<GameObject> gameObjectList = new List<GameObject>();
    private double yPos = 1;
    private int counter = 0;

    private double camYPos = 10.5;
    private int camZPos = -50;

    private float addRemoveRate = 0.5f;

    // Start is called before the first frame update
    public void Start()
    {
        InvokeRepeating("generateBlocks", addRemoveRate, addRemoveRate);
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (running==false) 
        //{
        //    if (Input.GetKey(KeyCode.A))
        //    {
        //        Invoke("generateBlocks", 1.5f);
        //    }
        //}
    }

    private void generateBlocks()
    {

            if (counter < 20)
            {
                if (gameObjectList.Count < 4)
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
                    GameObject.Destroy(gameObjectList[0], addRemoveRate+0.5f);
                    gameObjectList.RemoveAt(0);
                }
            }
        

    }
}
