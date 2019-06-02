using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ball;
    void Start()
    {
       Debug.Log("goal exists"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // if (other.tag == "player") {
            MeshRenderer meshRend = GetComponent<MeshRenderer>();
            meshRend.material.color = Color.green;
            Debug.Log("hei");
        // }
    }
}
