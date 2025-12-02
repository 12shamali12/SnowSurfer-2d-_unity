using UnityEngine;


public class snowinnggg : MonoBehaviour
{
   [SerializeField] ParticleSystem pparticleSystem;

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("floor"))
    {
        pparticleSystem.Play();
    }
  }
  void OnCollisionExit2D(Collision2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("floor"))
    {
        pparticleSystem.Stop();
    }
  }
}
