using UnityEngine;


public class snowinnggg : MonoBehaviour
{
   [SerializeField] ParticleSystem particleSystem;

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("floor"))
    {
        particleSystem.Play();
    }
  }
  void OnCollisionExit2D(Collision2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("floor"))
    {
        particleSystem.Stop();
    }
  }
}
