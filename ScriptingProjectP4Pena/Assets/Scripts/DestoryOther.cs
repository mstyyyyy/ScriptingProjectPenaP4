using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOther : MonoBehaviour
{
    public GameObject other;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
