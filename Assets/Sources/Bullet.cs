using System.Collections;
using UnityEngine;

namespace Sources
{
    public class Bullet : MonoBehaviour
    {
        public void Move(Vector3 destination) => 
            StartCoroutine(MoveCoroutine(destination));

        private IEnumerator MoveCoroutine(Vector3 destination)
        {
            while (Vector3.Distance(transform.position, destination) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime);
                
                yield return null;
            }
        }
    }
}