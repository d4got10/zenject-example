using UnityEngine;

namespace Gameplay
{
    public interface IPersistentService
    {
        void DoSomething();
    }
    
    public class PersistentService : IPersistentService
    {
        public void DoSomething()
        {
            Debug.Log("Persistent service fired!");
        }
    }
}