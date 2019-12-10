using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogFloatings : MonoBehaviour
{
    // Private Log properties
    [SerializeField]
    private float movementSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * movementSpeed * Time.deltaTime;
    }
}
