using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Dbg
{
    public static void Log(object a) {
        Debug.Log(a);
    }
    
    public static void Log(object a, object b) {
        Debug.Log(a + " " + b);
    }

    public static void Log(object a, object b, object c) {
        Debug.Log(a + " " + b + " " + c);
    }
}
