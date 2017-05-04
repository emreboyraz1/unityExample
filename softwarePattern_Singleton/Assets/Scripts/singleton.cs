using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Multithreaded Singleton

//sealed to prevent derivation
public sealed class singleton
{

    //to ensure that assignment to the instance variable completes before the instance variable can be accessed
    private static volatile singleton instance;

    //instance to lock on, rather than locking on the type itself, to avoid deadlocks
    private static object syncRoot = new Object();

    private singleton() { }

    // Double-Check Locking 
    public static singleton Instance
    {
        get
        {
            if (instance == null)
            {
                // lock block identifies
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new singleton() ;
                }
            }
            return instance;
        }
    }
  
    public void SecondCounter()
    {
        for(int i = 0; i < 500; i++)
        {
            // StartCoroutine(countDown());
            Debug.Log("my i : " + i);
        }
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(5);

    }
    private void OnDestroy()
    { if (this == instance) { instance = null; } }
}
