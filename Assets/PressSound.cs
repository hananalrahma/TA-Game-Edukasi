using System.Collections;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]

public class PressSound : MonoBehaviour
{
    public AudioClip sound;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
    }

    void PlaySound()
    {
        source.PlayOneShot(sound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
