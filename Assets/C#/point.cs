using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public GameObject Ship;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ship, transform.position, Quaternion.identity);
    }
}
