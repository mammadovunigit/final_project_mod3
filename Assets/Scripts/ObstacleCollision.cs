using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject PlayerC;
    public GameObject ModelC;
    public GameObject envcontrol;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = PlayerC.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)

    {
        Debug.Log(other.gameObject.name + " collided with an object");
        PlayerC.GetComponent<PlayerMove>().enabled = false;
        playerAudio.Play();
        ModelC.GetComponent<Animator>().Play("Stumble Backwards");
        envcontrol.GetComponent<Distance>().enabled = false;
        envcontrol.GetComponent<EndRun>().enabled = true;

    }
}
