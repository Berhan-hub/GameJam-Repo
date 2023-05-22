using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target; // Takip edilecek hedefin transform bileşeni

    private void LateUpdate()
    {
        // Kamerayı hedefin pozisyonuna eşitleme
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
