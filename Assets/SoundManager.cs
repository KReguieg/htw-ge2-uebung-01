using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] toneLadder = null;
    [SerializeField] AudioSource audioSource = null;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.clip = toneLadder[counter % toneLadder.Length];
            audioSource.Play();
            counter++;
        }
    }
}
