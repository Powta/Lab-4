using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    /* whenever something is static, it is tied to the whole class and not just one instance of the class
     * private set is there becuase we dont want other classes to erase the instance, we just want them to able able the GET it
    */
    public static PersistentManager Instance { get; private set; }

    public int score; // this is tied to an instance
    public int numOfJumps;

    private void Awake()//we use this function so that it runs before start()
    {
        if (Instance == null) //if there is nothing stored in instance property, we set it to contain something
        {
            Instance = this; //that something is this, and this means the current particular instance thatt this code is running in
            DontDestroyOnLoad(gameObject);
        }
        else ///if there is something stored in instance then destroy the duplicate of the instance of Persistent manager script
        {
            Destroy(gameObject);
        }
    }
}