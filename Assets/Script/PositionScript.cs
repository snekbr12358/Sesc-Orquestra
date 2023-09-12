using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScript : MonoBehaviour
{
    public float larguraw = 10;
    public float alturah = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position,new Vector3(larguraw,alturah,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
