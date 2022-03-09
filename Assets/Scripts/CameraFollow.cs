using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    private Transform t;


    // Start is called before the first frame update
    void Start()
    {
        t = target.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
      transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);

    }
}
