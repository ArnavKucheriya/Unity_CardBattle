using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMLoader : MonoBehaviour
{
    public AudioManager theAM;

    private void Awake()
    {
        if(FindObjectOfType<AudioManager>() == null)
        {
            AudioManager.instance = Instantiate(theAM);
            DontDestroyOnLoad(AudioManager.instance.gameObject);
        }
    }
}
