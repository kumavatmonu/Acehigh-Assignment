using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class track : MonoBehaviour
{
    public string[] Track1;
    public string[] Track2;
    public Text text;
    

    private void Start()
    {
        string[] n = Track1.Concat(Track2).ToArray();
        
        text.text = string.Join("\n", n);
       
    }
}
