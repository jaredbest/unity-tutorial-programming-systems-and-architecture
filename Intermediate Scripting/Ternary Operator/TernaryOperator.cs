using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour 
{
    // The Ternary Operator is a condensed form of an if-else statement
    void Start () 
    {
        int health = 10;
        string message;

        //This is an example Ternary Operation that chooses a message based
        //on the variable "health".
        // <boolean> ? <true expression> : <false expression>
        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }
}