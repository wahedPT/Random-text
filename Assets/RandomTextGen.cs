using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextGen : MonoBehaviour
{
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public string Generator(int length)
    {
        string result = string.Empty;
        for(int i=0; i<length;i++)
        {
            int maxroll = chars.Length;
            char randomcharcter = chars[Random.Range(0, maxroll)];
            result += randomcharcter.ToString();
        }
        return result;
    }
}
