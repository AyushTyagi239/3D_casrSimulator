
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Playerr;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
      
        transform.position = Playerr.position + offset ;
    }
}
