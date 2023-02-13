using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform
{
    private GameObject Plat;
    private List<GameObject> conPlat = new List<GameObject> ();


    public Platform(GameObject p)
    {
        this.Plat = p;
    }

    public void setConPlat(List<GameObject> list)
    {
        this.conPlat = list;
    }

    public GameObject getRandomConPlat()
    {
        return this.conPlat[Random.Range(0, this.conPlat.Count)];
    }
}
