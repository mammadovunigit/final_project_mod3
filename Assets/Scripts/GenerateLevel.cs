using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject[] Env;    // Array of environment prefabs to be generated
    public int envNum;          // Index for selecting the environment prefab to generate
    public bool creatingEnv = false; // Flag to check if an environment is currently being created
    public float zPos;          // Z position for generating environments

    void Start()
    {
        
    }

    void Update()
    {
        if (creatingEnv == false)
        {
            creatingEnv = true; 
            StartCoroutine(GenerateEnv()); // Start generating a new environment
        }
    }

    // Generate an environment
    IEnumerator GenerateEnv()
    {
       
        envNum = Random.Range(0, 3);

        //  Create a new instance of the selected environment
        Instantiate(Env[envNum], new Vector3(0, 0, zPos), Env[envNum].transform.rotation);

        zPos = zPos + 98;
        yield return new WaitForSeconds(3);
        creatingEnv = false; 
    }
}
