using UnityEngine;

namespace Gameplay
{
    public interface IServiceA
    {
        void DoSomething();
    }
    
    public class ServiceA : IServiceA
    {
        public void DoSomething()
        {
            Debug.Log("Service A");
        }
    }
}