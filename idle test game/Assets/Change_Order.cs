using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Order : MonoBehaviour{
    public int OrderInLayer = 0;

	// Use this for initialization
	void Start () {
	   MeshRenderer renderer = GetComponent<MeshRenderer>();
       renderer.sortingOrder = OrderInLayer;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}