﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementGenerator : MonoBehaviour {

    [Header("References")]
    public Vector3 Center; //x=-7 (p1), x=7 (p2)
    public Vector3 AreaSize;  // x=12, z=10

    private readonly List<GameObject> ElementTypes = new List<GameObject>();
    public GameObject element1; //R-Fire
    public GameObject element2; //G-Earth
    public GameObject element3; //B-Water

    private SphereCollider gemCollider3D;
    private Transform gemVisuals;

    // Use this for initialization
    void Start () {
        ElementTypes.Add(element1);
        ElementTypes.Add(element2);
        ElementTypes.Add(element3);

        //SpawnElement();
	}
	
	// Update is called once per frame
	void Update () {	
	}

    public void SpawnElement()
    {
        int element = Random.Range(0, ElementTypes.Count);
        GameObject NewElement = ElementTypes[element];

        Vector3 pos = Center + new Vector3(Random.Range(-AreaSize.x / 2, AreaSize.x / 2), 1, Random.Range(-AreaSize.z / 2, AreaSize.z / 2));

        Instantiate(NewElement, pos, Quaternion.identity);

        //GameObject newElement = ObjectPooler.SharedInstance.GetPooledObject("Pickup");
        //if (newElement != null)
        //{
        //    gemCollider3D = newElement.GetComponent<SphereCollider>();
            
        //    //gemVisuals = newElement.transform.Find("Gem Mesh");
        //    //gemVisuals.gameObject.SetActive(true);
        //    //Must be able to set Mesh to active onEnable

        //    if (!gemCollider3D.enabled)
        //    {
        //        gemCollider3D.enabled = true;
        //    }
        //    newElement.transform.position = pos;
        //    newElement.transform.rotation = Quaternion.identity;
        //    newElement.SetActive(true);
        //}

    } //end SpawnElement

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(Center, AreaSize);
    }
} //end ElementGenerator class
