using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{

    public AudioSource Audio;

    public AudioClip step;

    public static Sfx sfxInstance;

    //private void Awake()
    //{
    //    if (sfxInstance != null && sfxInstance != null)
    //    {
    //        Destroy(this.gameObject);
    //        return;

    //    }

    //    sfxInstance = this;
    //    DontDestroyOnLoad(this);



    //}

    private void Awake()
    {
        if (GetComponent<FindMousePositionTest>().isWalking == true)
        {
            
            Awake();
            Debug.Log("Now Playing... Walk - Pantara");

        }



    }


}
