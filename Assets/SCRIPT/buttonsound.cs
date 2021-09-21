/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsound: MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;
    public static buttonsound instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }


}*/
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class buttonsound : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(impact, 0.7F);
    }
}
