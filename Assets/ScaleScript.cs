using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public Vector3 scaleChange;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
    }
}
