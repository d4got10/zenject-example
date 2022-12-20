using System.Collections;
using UnityEngine;

namespace Gameplay
{
    public class SomethingThatNeedsPlayer : MonoBehaviour
    {
        [SerializeField] private Player _player;

        public IEnumerator Start()
        {
            yield return new WaitForSeconds(3f);
            
            Debug.Log($"Player field content: {_player}");
        }
    }
}