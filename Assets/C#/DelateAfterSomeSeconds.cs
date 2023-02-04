using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelateAfterSomeSeconds : MonoBehaviour
{
    public int HowMathSeconds;

    // Start is called before the first frame update
    void Update()
    {
        new WaitForSeconds(HowMathSeconds);
        Destroy(gameObject);
    }
}
