using UnityEngine;
using UnityEngine.SceneManagement;
public class finishLine : MonoBehaviour
{
  [SerializeField] float delayInSeconds = 1f;
  [SerializeField] ParticleSystem finishEffect;
  void OnTriggerEnter2D(Collider2D collision)
  {
    int layerindex =LayerMask.NameToLayer("player");


    if (collision.gameObject.layer == layerindex)
    {
      finishEffect.Play();
     Invoke("LoadNextScene", delayInSeconds);
    }
 
 
  }
  void LoadNextScene()
  {
    SceneManager.LoadScene(0);
  }
}
