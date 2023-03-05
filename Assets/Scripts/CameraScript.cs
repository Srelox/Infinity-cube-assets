using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   
     private Camera cam;
     public float[] distances; 
 
     void Start()
     {
         cam = GetComponent<Camera>();
         cam.layerCullDistances = distances;
     }
 
 }
