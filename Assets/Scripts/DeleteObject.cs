using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public bool gameHasEnded;
    void Update()
    {
        if(transform.position.z < 0f)
        {
            Destroy(gameObject);
        }
    }
    public void EndGame()
    {
        Destroy(gameObject);
    }
}
