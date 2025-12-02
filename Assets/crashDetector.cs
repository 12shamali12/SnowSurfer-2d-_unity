using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{[SerializeField] float delayInSeconds = 5f;
[SerializeField] ParticleSystem crashEffect;
   
  void OnCollisionEnter2D(Collision2D collision)
  { 
    
    int layerindex =LayerMask.NameToLayer("floor");


    if (collision.gameObject.layer == layerindex)
    {
      FindFirstObjectByType<playercontroller>().playing = false;
     crashEffect.Play();
     Invoke("LoadNextScene", delayInSeconds);
     
     
    }
 
  }
  void LoadNextScene()
  {
    SceneManager.LoadScene(0);
  }
}


