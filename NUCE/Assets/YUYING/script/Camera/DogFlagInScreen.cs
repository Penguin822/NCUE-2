using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFlagInScreen : MonoBehaviour
{
    static public bool inScreen;
    private void OnBecameVisible()
    {
        inScreen = true;
    }
    private void OnBecameInvisible()
    {
        inScreen = false;
    }
}
