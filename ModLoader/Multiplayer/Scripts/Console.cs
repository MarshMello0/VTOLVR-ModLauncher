﻿using UnityEngine;
public static class Console
{
    public static void Log(object message)
    {
        Debug.Log("Mod Loader: " + message);
    }
}
