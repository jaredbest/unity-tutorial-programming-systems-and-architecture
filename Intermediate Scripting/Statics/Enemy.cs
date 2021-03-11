using UnityEngine;
using System.Collections;

public class Enemy
{
    //Static variables are shared across all instances
    //of a class.
    public static int enemyCount = 0;

    // By putting keyword "static" in the declaration of the member, 
    // you are declaring it is static and will belong to the class 
    // itself; not an instance of the class.

    public Enemy()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}