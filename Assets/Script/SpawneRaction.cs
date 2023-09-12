using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneRaction : MonoBehaviour
{
    public float larguraw = 10;
    public float alturah = 5;
    public GameObject pianotile;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(larguraw, alturah, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawner()
    {
        foreach(Transform chid in transform)
        {
            GameObject piano = Instantiate(pianotile, chid.position, Quaternion.identity);
            piano.transform.parent = chid;
        }
    }
}
