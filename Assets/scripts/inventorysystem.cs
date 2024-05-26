using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorysystem : MonoBehaviour
{
    public int nwood ;//{ get; private set; }
    public int nrock ;//{ get; private set; }
    public int nfish ;

    public void collectwood(int woods)
    {
        nwood += woods;
    }
    public void collectrock(int rocks)
    {
        nrock += rocks;
    }
    public void collectfish(int fishs)
    {
        nfish += fishs;
    }
}
