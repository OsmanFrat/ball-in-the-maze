using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject parent;
    private Rigidbody parentRb;
    void Start()
    {
        /*
        
        parentRb = GetComponent<Rigidbody>();
        */
        
        parentRb = parent.GetComponent<Rigidbody>();
        // Rigidbody'yi almak için metodu çağır
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RightTorque()
    {
        parentRb.AddTorque(0,0,-1, ForceMode.Impulse);
    }
    public void LeftTorque()
    {
        parentRb.AddTorque(0,0,1, ForceMode.Impulse);
    }
}
