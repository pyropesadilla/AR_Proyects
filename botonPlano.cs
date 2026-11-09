using UnityEngine;

public class botonPlano : MonoBehaviour
{
    public GameObject[] fase0;
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
                    obj.SetActive(false);
                } 

        }
        
        if(number==1)
        {
            foreach (GameObject obj in fase0)
                {
                    obj.SetActive(true);
                } 
        }
        

        if(number >=2 )
        {   number=0;}
    }
    public void Plano()
    {
        number+=1;
    }
}
