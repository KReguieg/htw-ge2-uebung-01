using UnityEngine;

public class AudioSourceManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource = null;
    //[SerializeField] private AudioClip pewPewClip = null;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in Microphone.devices)
        {
            Debug.Log(item);
        }
        this.audioSource.clip = Microphone.Start(Microphone.devices[4], true, 1, 44100);
        while (!(Microphone.GetPosition(Microphone.devices[4]) > 0)) { }
        this.audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
