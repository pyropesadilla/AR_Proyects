using UnityEngine;

public class punto : MonoBehaviour
{
    public GameObject[] fase0;
    public GameObject[] fase1;
    public GameObject[] fase2;
    public GameObject[] fase3;
    public int number;
    void Start()
    {
        number=0;
    }
    
    void Update()
    {
         Debug.Log("num:"+ number);
        if(number==0)
        {
            foreach (GameObject obj in fase0)
                {
                    obj.SetActive(true);
                }
            foreach (GameObject obj in fase1)
                {
                    obj.SetActive(false);
                } 
            foreach (GameObject obj in fase2)
                {
                    obj.SetActive(false);
                }
            foreach (GameObject obj in fase3)
                {
                    obj.SetActive(false);
                }
            
        }
        if(number==1)
        {
            foreach (GameObject obj in fase0)
                {
                    obj.SetActive(true);
                }
            foreach (GameObject obj in fase1)
                {
                    obj.SetActive(true);
                } 
            foreach (GameObject obj in fase2)
                {
                    obj.SetActive(false);
                }
            foreach (GameObject obj in fase3)
                {
                    obj.SetActive(false);
                }
            
        }
        if(number==2)
        {
             foreach (GameObject obj in fase0)
                {
                    obj.SetActive(true);
                }
            foreach (GameObject obj in fase1)
                {
                    obj.SetActive(true);
                } 

            foreach (GameObject obj in fase2)
                {
                    obj.SetActive(true);
                }
            foreach (GameObject obj in fase3)
                {
                    obj.SetActive(false);
                }
           
        }
        if(number==3)
        {
             foreach (GameObject obj in fase0)
                {
                    obj.SetActive(true);
                }
            foreach (GameObject obj in fase1)
                {
                    obj.SetActive(true);
                } 

            foreach (GameObject obj in fase2)
                {
                    obj.SetActive(false);
                }
            foreach (GameObject obj in fase3)
                {
                    obj.SetActive(true);
                }
           
        }

        if(number >=4 )
        {   number=0;}
    }
    public void QQ()
    {
        number+=1;
    }
}
