using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingConversation : MonoBehaviour
{
    void Start()
    {
        CharMovements moveScript = GetComponent<CharMovements>();
        moveScript.canMove = false;
    }
} 