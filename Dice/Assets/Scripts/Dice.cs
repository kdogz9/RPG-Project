using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int RollD6()
    {
        int result = Random.Range(1, 7);
        Debug.Log("rolled a d6: " + result);
        return result;
    }

    public int RollD12()
    {
        int result = Random.Range(1, 13);
        Debug.Log("rolled a d12: " + result);
        return result;
    }
    public int RollD20()
    {
        int result = Random.Range(1, 21);
        Debug.Log("rolled a d20: " + result);
        return result; 
    }
}
