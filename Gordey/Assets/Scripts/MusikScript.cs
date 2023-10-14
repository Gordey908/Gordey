using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikScript : MonoBehaviour
{
    private static MusikScript instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
