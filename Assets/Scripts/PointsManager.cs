using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject punto;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right*0.5f);
        transform.Rotate(Vector3.up*0.25f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        

    }
}
