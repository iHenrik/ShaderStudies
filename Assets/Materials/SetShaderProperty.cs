using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetShaderProperty : MonoBehaviour
{

    public Material Mat;
    public string propertyName;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Mat.SetVector(propertyName, player.position);
        }
        else
        {
            Debug.Log("Player not set.");
        }
    }
}
