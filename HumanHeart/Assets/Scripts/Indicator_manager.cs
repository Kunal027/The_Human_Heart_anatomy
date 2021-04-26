using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;


public class Indicator_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject aorta_indicator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Aourta_buttonClicked()
    {
        StartCoroutine(Aourta_Indicator_Coroutine());
    }
  

    IEnumerator Aourta_Indicator_Coroutine()
    {
        aorta_indicator.SetActive(true);
        yield return new WaitForSeconds(5f);
        aorta_indicator.SetActive(false);

    }
}
