using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switching : MonoBehaviour
{
    public Image On1;
    public Image Off1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ON()
    {

        Off1.gameObject.SetActive(true);
        On1.gameObject.SetActive(false);
    }
    public void OFF()
    {

        On1.gameObject.SetActive(true);
        Off1.gameObject.SetActive(false);
    }
}
