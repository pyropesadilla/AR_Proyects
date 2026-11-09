using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject texto;
    public GameObject cruz;
    public int number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texto.SetActive(false);
        cruz.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropdownSample(int index)
    {
        if( index==number)
        {
            texto.SetActive(true);
            cruz.SetActive(false);
        }
        else{
            texto.SetActive(false);
            cruz.SetActive(true);
        }
    }
}
