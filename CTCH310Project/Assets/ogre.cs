using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogre : MonoBehaviour
{


    public int intel = 5;

    void Greet() 
    {
        switch(intel)
        {
            case 5:
                print("1+1=5");
                break;
            case 4:
                print("1+1=4");
                break;
            case 3:
                print("1+1=3");
                break;
            case 2:
                print("Em......I dunno");
                break;
            case 1:
                print("wut's 1+1?");
                break;
            default:
                print("Kill ya!");
                break;
        }


    }

    void headBlow()
    {
        intel -= 1;
    }

    void read()
    {
        intel += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Z))
        {
            Greet();
        }

        if(Input.GetKeyUp(KeyCode.X))
        {
            headBlow();
            Greet();
        }

        if(Input.GetKeyUp(KeyCode.C))
        {
            read();
            Greet();
        }
    }
}
