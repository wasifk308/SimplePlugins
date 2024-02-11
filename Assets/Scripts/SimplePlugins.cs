using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class SimplePlugins : MonoBehaviour
{

    //DllImport exposed  unmanaged dynamic-link library (DLL) as a static entry point.
    [DllImport("Test")]
    private static extern int MultiplyTwoNum(int x, int y);


    // Start is called before the first frame update
    void Start()
    {
        int ret = MultiplyTwoNum(20, 10);

        print(ret);
    }

  
}
