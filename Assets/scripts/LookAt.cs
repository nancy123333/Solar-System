using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // target that the camera should look at 
    static public GameObject target;
    void Start()
    {
         if(target == null)
        {
            target= this.gameObject;
            Debug.Log("Look at target target not specified.Defaulting to parent GameObject");

        
    }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            transform.LookAt(target.transform);
        }
    }
}