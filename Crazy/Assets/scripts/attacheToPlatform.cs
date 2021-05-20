using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacheToPlatform : MonoBehaviour
{

    public GameObject child;

    public Transform parent;

    private void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            child.transform.SetParent(parent);
            print("test");
        }
    }

    public void Example(Transform newParent)
    {
        // Sets "newParent" as the new parent of the child GameObject.
        child.transform.SetParent(newParent);

        // Same as above, except worldPositionStays set to false
        // makes the child keep its local orientation rather than
        // its global orientation.
        //child.transform.SetParent(newParent, false);

        // Setting the parent to ‘null’ unparents the GameObject
        // and turns child into a top-level object in the hierarchy
        //child.transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
