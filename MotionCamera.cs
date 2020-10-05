using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SimpleExample : MonoBehaviour
{
    public Transform objToFollow;
    private Vector3 deltaPos;

    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    // Update is called once per frame 
    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
       
    }
}
 
