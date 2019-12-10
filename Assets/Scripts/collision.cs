using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Sepiroth")
        {
            Debug.Log("Game Over!");

            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sepiroth")
        {
            Debug.Log("Game Over!");
            //SceneManager.LoadScene(2);
        }
    }
}
